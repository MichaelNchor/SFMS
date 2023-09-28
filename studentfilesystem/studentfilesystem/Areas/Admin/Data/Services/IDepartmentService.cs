using studentfilesystem.Models;
using System.Collections.Generic;

namespace studentfilesystem.Areas.Admin.Data.Services
{
    public interface IDepartmentService
    {
        void AddDepartment(Department department);
        IEnumerable<Department> GetDepartments();
    }
}