using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using studentfilesystem.Areas.Admin.Data.Services;
using studentfilesystem.Controllers;
using studentfilesystem.Models;

namespace studentfilesystem.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")] // Apply this attribute to restrict access to Admin role
    [Area("Admin")]
    public class HomeController : BaseController
    {
        private readonly IStudentService _service;

        public HomeController(IStudentService service)
        {
            _service = service;
        }

        // GET: Home
        public ActionResult Index()
        {
            if(User.Identity.IsAuthenticated == true) { 
                Notify("", "Logged In", true, notificationType: NotificationType.success);
            }

            var applicants = _service.GetApplicants();

            ViewBag.All = applicants.Count();

            var countp = 0;
            foreach (var appl in applicants)
            {
                if (appl.Status == 0)
                {
                    countp++;
                }
            }
            ViewBag.ProgramUpload = countp;

            var countd = 0;
            foreach (var appl in applicants)
            {
                if (appl.Status == 1)
                {
                    countd++;
                }
            }

            ViewBag.DocUpload = countd;

            return View(applicants);
        }
    }
}