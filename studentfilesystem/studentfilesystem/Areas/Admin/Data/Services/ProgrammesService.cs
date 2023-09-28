using Microsoft.AspNetCore.Hosting;
using studentfilesystem.Models;
using System.Collections.Generic;
using System.Linq;

namespace studentfilesystem.Areas.Admin.Data.Services
{
    public class ProgrammesService : IProgrammesService
    {
        private readonly IHostingEnvironment _hostEnvironment;
        private readonly studentfilesystemContext _dbcontext;

        public ProgrammesService(IHostingEnvironment hostEnvironment, studentfilesystemContext dbcontext)
        {
            _hostEnvironment = hostEnvironment;
            _dbcontext = dbcontext;
        }

        public IEnumerable<Programme> GetProgrammes()
        {
            return _dbcontext.Programme.ToList();
        }

        public void AddProgramme(Programme programme)
        {
            _dbcontext.Programme.Add(programme);
            _dbcontext.SaveChanges();
        }
        public void AddCollege(College college)
        {
            _dbcontext.College.Add(college);
            _dbcontext.SaveChanges();
        }
    }
}
