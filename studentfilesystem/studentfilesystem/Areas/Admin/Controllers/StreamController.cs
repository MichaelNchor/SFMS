using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using studentfilesystem.Areas.Admin.Data.Services;
using studentfilesystem.Models;
using System.Collections.ObjectModel;
using System;
using studentfilesystem.Controllers;
using System.Threading.Tasks;

namespace studentfilesystem.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")] // Apply this attribute to restrict access to Admin role
    [Area("Admin")]
    public class StreamController : BaseController
    {
        private readonly IProgrammesService _programmesService;
        private readonly ICollegeService _collegeService;
        private readonly IFacultyService _facultyService;
        private readonly IDepartmentService _departmentService;

        public StreamController(IProgrammesService programmesService, ICollegeService collegeService, IFacultyService facultyService, IDepartmentService departmentService)
        {
            _programmesService = programmesService;
            _collegeService = collegeService;
            _facultyService = facultyService;
            _departmentService = departmentService;
        }

        public IActionResult Index()
        {
            ViewBag.colleges = _collegeService.GetColleges();
            ViewBag.faculties = _facultyService.GetFacultys();
            ViewBag.departments = _departmentService.GetDepartments();
            ViewBag.Programmes = _programmesService.GetProgrammes();

            ViewBag.selectedCollege = null; 
            ViewBag.selectedFaculty = null; 
            ViewBag.selectedDepartment = null; 
            ViewBag.selectedProgramme = null;

;            return View();
        }

        [HttpPost]
        public ActionResult AddCollege(College college)
        {
            try
            {
                _collegeService.AddCollege(college);

                Notify("", "Add Successfully", false, notificationType: NotificationType.success);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                Notify("", "Add Failed", false, notificationType: NotificationType.error);
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public ActionResult EditCollege(College college)
        {
            try
            {
                _collegeService.AddCollege(college);

                Notify("", "Add Successfully", false, notificationType: NotificationType.success);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                Notify("", "Add Failed", false, notificationType: NotificationType.error);
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public ActionResult AddFaculty(Faculty faculty)
        {
            try
            {
                _facultyService.AddFaculty(faculty);

                Notify("", "Add Successfully", false, notificationType: NotificationType.success);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                Notify("", "Add Failed", false, notificationType: NotificationType.error);
                return RedirectToAction("Index");
            }
        }

        [HttpGet]
        public ActionResult EditFaculty(int id)
        {
            return View();
        }

        [HttpPost]
        public ActionResult EditFaculty(Faculty faculty)
        {
            try
            {
                _facultyService.AddFaculty(faculty);

                Notify("", "Add Successfully", false, notificationType: NotificationType.success);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                Notify("", "Add Failed", false, notificationType: NotificationType.error);
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public ActionResult AddDepartment(Department department)
        {
            try
            {
                _departmentService.AddDepartment(department);

                Notify("", "Add Successfully", false, notificationType: NotificationType.success);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                Notify("", "Add Failed", false, notificationType: NotificationType.error);
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public ActionResult EditDepartment(Department department)
        {
            try
            {
                _departmentService.AddDepartment(department);

                Notify("", "Add Successfully", false, notificationType: NotificationType.success);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                Notify("", "Add Failed", false, notificationType: NotificationType.error);
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public ActionResult AddProgramme(Programme programme)
        {
            try
            {
                _programmesService.AddProgramme(programme);

                Notify("", "Add Successfully", false, notificationType: NotificationType.success);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                Notify("", "Add Failed", false, notificationType: NotificationType.error);
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public ActionResult EditProgramme(Programme programme)
        {
            try
            {
                _programmesService.AddProgramme(programme);

                Notify("", "Add Successfully", false, notificationType: NotificationType.success);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                Notify("", "Add Failed", false, notificationType: NotificationType.error);
                return RedirectToAction("Index");
            }
        }
    }
}
