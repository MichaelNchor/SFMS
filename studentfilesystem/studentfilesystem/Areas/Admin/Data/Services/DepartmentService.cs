using Microsoft.AspNetCore.Hosting;
using studentfilesystem.Models;
using System.Collections.Generic;
using System.Linq;

namespace studentfilesystem.Areas.Admin.Data.Services
{
    public class DepartmentService : IDepartmentService
    {
        private readonly IHostingEnvironment _hostEnvironment;
        private readonly studentfilesystemContext _dbcontext;

        public DepartmentService(IHostingEnvironment hostEnvironment, studentfilesystemContext dbcontext)
        {
            _hostEnvironment = hostEnvironment;
            _dbcontext = dbcontext;
        }

        public IEnumerable<Department> GetDepartments()
        {
            return _dbcontext.Department.ToList();
        }

        public void AddDepartment(Department department)
        {
            _dbcontext.Department.Add(department);
            _dbcontext.SaveChanges();
        }
    }
}
