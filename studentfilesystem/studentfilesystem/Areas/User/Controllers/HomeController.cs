using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using studentfilesystem.Areas.User.Data.Services;
using studentfilesystem.Models;
using studentfilesystem.Controllers;
using System.Linq;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System;

namespace studentfilesystem.Areas.User.Controllers
{
    [Authorize(Roles = "User")] // Apply this attribute to restrict access to Admin role
    [Area("User")]
    public class HomeController : BaseController
    {
        private readonly IUserService _service;
        private readonly UserManager<IdentityUser> _userManager;

        public HomeController(IUserService service, UserManager<IdentityUser> userManager)
        {
            _service = service;
            _userManager = userManager;
        }

        // GET: HomeController
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var user = await _userManager.GetUserAsync(HttpContext.User);

            var applicant = _service.GetApplicationByUserId(user.Id);
            if (applicant != null) ViewBag.IsAlreadyApplied = true;
            else ViewBag.IsAlreadyApplied = false;

            var documents = _service.GetDocuments(user.Id);
            ViewBag.Programmes = _service.GetProgrammes();
            ViewBag.Documents = documents;

            if (applicant != null)
            {
                if (applicant.ProgrammeChoice1 == null && applicant.ProgrammeChoice2 == null && applicant.ProgrammeChoice3 == null)
                {
                    Notify("", "Please Select Programmes", true, notificationType: NotificationType.success);
                }
                else
                {
                    Notify("", "Programmes Stage Complete", true, notificationType: NotificationType.success);
                }
            }

            return View(applicant);
        }

        // GET: Student/Create
        public async Task<IActionResult> Create()
        {
            var user = await _userManager.GetUserAsync(HttpContext.User);
            var appl = _service.GetApplicationByUserId(user.Id);
            if(appl != null) ViewBag.IsAlreadyApplied = true;
            else ViewBag.IsAlreadyApplied = false;

            return View();
        }

        // POST: Student/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Application collection)
        {
            try
            {
                var user = await _userManager.GetUserAsync(HttpContext.User);
                _service.CreateApplicant(collection, user);
                // add modal on Admin/ route
                Notify("", "Application Created", false, notificationType: NotificationType.success);

                return View();
            }
            catch
            {
                //Console.WriteLine("error: " + e);
                // modal for failed to add applicant
                Notify("", "Application Failed", true, notificationType: NotificationType.error);

                return View();
            }
        }

                [HttpGet]
        public async Task<IActionResult> StudentMenu(int id)
        {
            var user = await _userManager.GetUserAsync(HttpContext.User);

            var applicant = _service.GetApplicantById(id);
            var documents = _service.GetDocuments(user.Id);

            ViewBag.Documents = documents;
            ViewBag.Programmes = _service.GetProgrammes();

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
        public async Task<IActionResult> EditPersonal(int id, Application collection)
        {
            try
            {
                var user = await _userManager.GetUserAsync(HttpContext.User);

                _service.EditPersonal(id, collection, user);
                Notify("", "Edited Successfully", false, notificationType: NotificationType.success);
                return RedirectToAction("Index");
            }
            catch(Exception ex)
            {
                Notify("", "Edit Failed", false, notificationType: NotificationType.error);
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> EditProgramme(int id, Application collection)
        {
            var applicant = _service.GetApplicantById(id);

            try
            {
                var user = await _userManager.GetUserAsync(HttpContext.User);

                _service.EditProgramme(id, collection, user);
                Notify("", "Edited Successfully", false, notificationType: NotificationType.success);
                return RedirectToAction("Index");
            }
            catch
            {
                Notify("", "Edited Failed", false, notificationType: NotificationType.error);
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> AddDocument(int id, Models.Document document, string username)
        {
            try
            {
                var user = await _userManager.GetUserAsync(HttpContext.User);

                _service.AddDocument(id, document, user);
                Notify("", "Added Successfully", false, notificationType: NotificationType.success);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                Notify("", "Add Failed", false, notificationType: NotificationType.success);
                return RedirectToAction("Index");
            }
        }
    }
}
