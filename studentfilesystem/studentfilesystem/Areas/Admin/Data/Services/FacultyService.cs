using Microsoft.AspNetCore.Hosting;
using studentfilesystem.Models;
using System.Collections.Generic;
using System.Linq;

namespace studentfilesystem.Areas.Admin.Data.Services
{
    public class FacultyService : IFacultyService
    {
        private readonly IHostingEnvironment _hostEnvironment;
        private readonly studentfilesystemContext _dbcontext;

        public FacultyService(IHostingEnvironment hostEnvironment, studentfilesystemContext dbcontext)
        {
            _hostEnvironment = hostEnvironment;
            _dbcontext = dbcontext;
        }

        public IEnumerable<Faculty> GetFacultys()
        {
            return _dbcontext.Faculty.ToList();
        }

        public void AddFaculty(Faculty faculty)
        {
            _dbcontext.Faculty.Add(faculty);
            _dbcontext.SaveChanges();
        }
    }
}
