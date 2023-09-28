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
using Microsoft.AspNetCore.Identity;

namespace studentfilesystem.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")] // Apply this attribute to restrict access to Admin role
    [Area("Admin")]
    public class StudentController : BaseController
    {
        private readonly IStudentService _service;
        private readonly UserManager<IdentityUser> _userManager;

        public StudentController(IStudentService service, UserManager<IdentityUser> userManager)
        {
            _service = service;
            _userManager = userManager;
        }

        // GET: Student
        public ActionResult Index()
        {
            var applicants = _service.GetApplicants();
            return View(applicants);
        }

        [HttpGet]
        public async Task<IActionResult> StudentMenu(int id)
        {
            var applicant = _service.GetApplicantById(id);
            var documents = _service.GetDocuments(id);

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