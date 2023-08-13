using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using studentfilesystem.Models;
using studentfilesystem.Areas.Admin.Data.Services;
using System.IO;
using studentfilesystem.Controllers;

namespace studentfilesystem.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")] // Apply this attribute to restrict access to Admin role
    [Area("Admin")]
    public class StudentController : BaseController
    {
        private readonly IStudentService _service;

        public StudentController(IStudentService service)
        {
            _service = service;
        }

        // GET: Student
        public ActionResult Index()
        {
            var applicants = _service.GetApplicants();
            return View(applicants);
        }

        [HttpGet]
        public ActionResult StudentMenu(int id)
        {
            var applicant = _service.GetApplicantById(id);
            var documents = _service.GetDocuments();

            ViewBag.Documents = documents;

            if (applicant.ProgrammeChoice1 == null && applicant.ProgrammeChoice2 == null && applicant.ProgrammeChoice3 == null)
            {
                Notify("", "Please Select Programmes", true, notificationType: NotificationType.success);
            }
            else
            {
                Notify("", "Programmes Stage Complete", true, notificationType: NotificationType.success);
            }
            return View(applicant);
        }

        [HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult EditPersonal(int id, Application collection, string username)
        {
            try
            {
                _service.EditPersonal(id, collection, User.Identity.Name);
                Notify("", "Edited Successfully", false, notificationType: NotificationType.success);
                return RedirectToAction("StudentMenu", new { id = collection.ApplicationId });
            }
            catch(Exception ex)
            {
                Notify("", "Edit Failed", false, notificationType: NotificationType.error);
                return RedirectToAction("StudentMenu", new { id = collection.ApplicationId });
            }
        }

        [HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult EditProgramme(int id, Application collection, string username)
        {
            var applicant = _service.GetApplicantById(id);

            try
            {
                _service.EditProgramme(id, collection, User.Identity.Name);
                Notify("", "Edited Successfully", false, notificationType: NotificationType.success);
                return RedirectToAction("StudentMenu", new { id = id });
            }
            catch
            {
                Notify("", "Edited Failed", false, notificationType: NotificationType.error);
                return RedirectToAction("StudentMenu", new { id = id });
            }
        }

        [HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult AddDocument(int id, Models.Document document, string username)
        {
            try
            {
                _service.AddDocument(id, document, User.Identity.Name);
                Notify("", "Added Successfully", false, notificationType: NotificationType.success);
                return RedirectToAction("StudentMenu", new { id = id });
            }
            catch (Exception ex)
            {
                Notify("", "Add Failed", false, notificationType: NotificationType.success);
                return RedirectToAction("StudentMenu", new { id = id });
            }
        }

        [HttpGet]
        // GET: Search
        public ActionResult Search()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        // POST: Search
        public ActionResult Search(SearchQuery searchQuery)
        {
            try
            {
                // TODO: Add update logic here
                return RedirectToAction("SearchResults", new { text = searchQuery.text, startDate = searchQuery.startDate, endDate = searchQuery.endDate });
            }
            catch
            {
                return View();
            }
        }

        // GET: SearchResult
        public ActionResult SearchResults(string text, int startDate, int endDate)
        {
            var results = _service.Search(text, startDate, endDate);
            return View(results);
        }

        // GET: Student/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Student/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Application collection)
        {
            try
            {
                _service.CreateApplicant(collection, User.Identity.Name);
                // add modal on Admin/ route
                Notify("","Application Created", false, notificationType: NotificationType.success);

                return View();
            }
            catch
            {
                //Console.WriteLine("error: " + e);
                // modal for failed to add applicant
                Notify("","Application Failed", true, notificationType: NotificationType.error);

                return View();
            }
        }

        // POST: Student/Delete/5
        [HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        public JsonResult DeleteApplicant(int id)
        {
            bool result = false;
            try
            {
                // TODO: Add delete logic here
                _service.DeleteApplicant(id);
                result = true;
                return Json(new { success = result });
            }
            catch (Exception ex)
            {
                return Json(new { error = ex });
            }
        }
    }
}