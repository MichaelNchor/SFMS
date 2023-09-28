using studentfilesystem.Models;
using System.Collections.Generic;

namespace studentfilesystem.Areas.Admin.Data.Services
{
    public interface ICollegeService
    {
        void AddCollege(College college);
        IEnumerable<College> GetColleges();
        College GetCollegeById(int id);
    }
}