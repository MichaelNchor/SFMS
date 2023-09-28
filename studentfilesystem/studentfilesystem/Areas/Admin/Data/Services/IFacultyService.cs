using studentfilesystem.Models;
using System.Collections.Generic;

namespace studentfilesystem.Areas.Admin.Data.Services
{
    public interface IFacultyService
    {
        void AddFaculty(Faculty faculty);
        IEnumerable<Faculty> GetFacultys();
    }
}