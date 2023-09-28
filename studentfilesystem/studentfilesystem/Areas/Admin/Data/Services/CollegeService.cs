using Microsoft.AspNetCore.Hosting;
using studentfilesystem.Models;
using System.Collections.Generic;
using System.Linq;

namespace studentfilesystem.Areas.Admin.Data.Services
{
    public class CollegeService : ICollegeService
    {
        private readonly IHostingEnvironment _hostEnvironment;
        private readonly studentfilesystemContext _dbcontext;

        public CollegeService(IHostingEnvironment hostEnvironment, studentfilesystemContext dbcontext)
        {
            _hostEnvironment = hostEnvironment;
            _dbcontext = dbcontext;
        }

        public IEnumerable<College> GetColleges()
        {
            return _dbcontext.College.ToList();
        }

        public void AddCollege(College college)
        {
            _dbcontext.College.Add(college);
            _dbcontext.SaveChanges();
        }

        public College GetCollegeById(int id)
        {
            return _dbcontext.College.Find(id);
        }
    }
}
