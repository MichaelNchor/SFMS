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
        IEnumerable<Models.Document> GetDocuments(int id);
        Application GetApplicantById(int id);
        Application GetApplicationByUserId(string userid);
        void DeleteApplicant(int id);
        IEnumerable<Application> Search(string text = "", int startDate = 1900, int endDate = 2099);
    }
}
