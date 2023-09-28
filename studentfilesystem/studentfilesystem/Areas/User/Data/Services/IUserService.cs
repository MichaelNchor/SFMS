using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using studentfilesystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace studentfilesystem.Areas.User.Data.Services
{
    public interface IUserService
    {
        IEnumerable<Application> GetApplicants();
        IEnumerable<Models.Document> GetDocuments(string id);
        Application GetApplicantById(int id);
        void CreateApplicant(Application collection, IdentityUser user);
        void DeleteApplicant(int id);
        void EditPersonal(int id, Application collection, IdentityUser user);
        void EditProgramme(int id, Application collection, IdentityUser user);
        void AddDocument(int id, Models.Document document, IdentityUser user);
        IEnumerable<Application> Search(string text = "", int startDate = 1900, int endDate = 2099);
        Application GetApplicationByUserId(string userid);
        IEnumerable<Programme> GetProgrammes();
    }
}
