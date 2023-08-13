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

        // GET: Home/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Home/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Home/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Home/Edit/5
        public ActionResult Edit(int id)
        {
            var app = _service.GetApplicantById(id);
            return View(app);
        }

        // POST: Home/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Home/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Home/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}