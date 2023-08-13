using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using studentfilesystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace studentfilesystem.Areas.Admin.Data.Services
{
    public interface IStudentService
    {
        IEnumerable<Application> GetApplicants();
        IEnumerable<Models.Document> GetDocuments();
        Application GetApplicantById(int id);
        void CreateApplicant(Application collection, string username);
        void DeleteApplicant(int id);
        void EditPersonal(int id, Application collection, string username);
        void EditProgramme(int id, Application collection, string username);
        void AddDocument(int id, Models.Document document, string username);
        IEnumerable<Application> Search(string text = "", int startDate = 1900, int endDate = 2099);
    }
}
