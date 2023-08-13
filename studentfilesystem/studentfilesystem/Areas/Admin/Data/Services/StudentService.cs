using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using studentfilesystem.Models;
using studentfilesystem.Areas.Admin.Data.Services;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.IO;
using Microsoft.AspNetCore.Http.Internal;
using Microsoft.AspNetCore.Hosting;
using System.Reflection.Metadata;

namespace studentfilesystem.Areas.Admin.Data.Services
{
    public class StudentService : IStudentService
    {
        private readonly IHostingEnvironment _hostEnvironment;
        private readonly studentfilesystemContext _dbcontext;

        public StudentService(IHostingEnvironment hostEnvironment, studentfilesystemContext dbcontext)
        {
            _hostEnvironment = hostEnvironment;
            _dbcontext = dbcontext;
        }

        public IEnumerable<Application> GetApplicants()
        {
            return _dbcontext.Application.ToList();
        }

        public Application GetApplicantById(int id)
        {
            var data = _dbcontext.Application.Find(id);
            //data.PassportImageView = BytesToImage(data.PassportBytes);
            return data;
        }

        public void CreateApplicant(Application collection, string username)
        {
            collection = SaveImage(collection);
            var removeString = "C:\\Users\\UITS-PC\\source\\repos\\studentfilesystem\\studentfilesystem\\wwwroot";
            collection.PassportPath = collection.PassportPath.Replace(removeString, "");

            collection.Status = 0;
            collection.CreatedBy = username;
            collection.CreatedOn = DateTime.Now;
            _dbcontext.Application.Add(collection);
            _dbcontext.SaveChanges();
        }

        public void AddDocument(int id, Models.Document document, string username)
        {
            document = SaveDocument(document);
            document.CreatedOn = DateTime.Now;
            document.CreatedBy = username;
            document.ApplicationId = id;
            _dbcontext.Document.Add(document);
            _dbcontext.SaveChanges();
        }

        public IEnumerable<Application> Search(string text = "", int startDate = 1900, int endDate = 2099)
        {
            var results = _dbcontext.Application.Where(q => 
               q.SchoolEmail.Contains(text) 
            || q.AcademicYear.Contains(text) 
            || q.ApplicationId.ToString().Contains((text))
            || q.BirthDate.ToString().Contains(text)
            || q.Country.Contains(text)
            || q.Denomination.Contains(text)
            || q.Gender.Contains(text)
            || q.KnustmobileNo.ToString().Contains(text)
            || q.Surname.Contains(text)
            || q.OtherNames.Contains(text)
            || q.OtherEmail.Contains(text)
            || q.OtherPhoneNo.ToString().Contains(text)
            //|| q.ResidentialAddress1.Contains(text)
            //|| q.ResidentialAddress2.Contains(text)
            //|| q.ResidentialAddress3.Contains(text)
            //|| q.ResidentialAddress4.Contains(text)
            //|| q.PostalAddress1.Contains(text)
            //|| q.PostalAddress2.Contains(text)
            //|| q.PostalAddress3.Contains(text)
            //|| q.PostalAddress4.Contains(text)
            || q.Religion.Contains(text)
            || q.Region.Contains(text)
            || q.ProgrammeChoice1.Contains(text)
            || q.ProgrammeChoice2.Contains(text)
            || q.ProgrammeChoice3.Contains(text)
            );

            List<int> dates = GetDatesInRange(startDate, endDate);

            foreach (int date in dates)
            {
                results = results.Where(q => q.AcademicYear.Contains(startDate.ToString()));
            }

            return results.ToList();
        }

        public void DeleteApplicant(int id)
        {
            var applicant = _dbcontext.Application.Find(id);
            if (applicant != null) _dbcontext.Application.Remove(applicant);
            _dbcontext.SaveChanges();
        }

        public void EditPersonal(int id, Application collection, string username)
        {
            if (collection.PassportImage != null)
            {
                collection = SaveImage(collection);
                var removeString = "C:\\Users\\UITS-PC\\source\\repos\\studentfilesystem\\studentfilesystem\\wwwroot";
                collection.PassportPath = collection.PassportPath.Replace(removeString, "");
            }

            collection.UpdateBy = username;
            collection.UpdatedOn = DateTime.Now;

            _dbcontext.Entry(collection).State = EntityState.Modified;
            _dbcontext.SaveChanges();
        }

        public void EditProgramme(int id, Application application, string username)
        {
            var applicant = _dbcontext.Application.Find(id);
            applicant.AcademicYear = application.AcademicYear;
            applicant.ProgrammeChoice1 = application.ProgrammeChoice1;
            applicant.ProgrammeChoice2 = application.ProgrammeChoice2;
            applicant.ProgrammeChoice3 = application.ProgrammeChoice3;
            applicant.Type = application.Type;
            applicant.Status = 1;
            applicant.UpdatedOn = DateTime.Now;
            applicant.UpdateBy = username;
            _dbcontext.SaveChanges();
        }

        public List<int> GetDatesInRange(int startDate, int endDate)
        {
            List<int> datesInRange = new List<int>();

            // Add the start date to the list
            datesInRange.Add(startDate);

            // Iterate from start date + 1 day until end date
            int currentDate = startDate+=1;
            while (currentDate <= endDate)
            {
                datesInRange.Add(currentDate);
                currentDate = currentDate+=1;
            }

            return datesInRange;
        }

        public Application SaveImage(Application collection)
        {
            string wwwrootpath = _hostEnvironment.WebRootPath;
            //string imageName = Path.GetFileNameWithoutExtension(collection.PassportImage.FileName);
            string extension = Path.GetExtension(collection.PassportImage.FileName);
            collection.PassportTitle = collection.Surname + collection.OtherNames + DateTime.Now.ToString("yymmssfff") + extension;
            collection.PassportPath = Path.Combine(wwwrootpath + "/images/applicants/", collection.PassportTitle);
            //collection.PassportPath = Path.Combine("/images/applicants/", collection.PassportTitle);

            using (var fileStream = new FileStream(collection.PassportPath, FileMode.Create))
            {
                collection.PassportImage.CopyTo(fileStream);
            }

            return collection;
        }

        public Models.Document SaveDocument(Models.Document document)
        {
            string wwwrootpath = _hostEnvironment.WebRootPath;
            string extension = Path.GetExtension(document.DocumentFile.FileName);
            document.Name = document.Type + DateTime.Now.ToString("yymmssfff") + extension;
            document.DocumentPath = Path.Combine(wwwrootpath + "/documents/applicants/", document.Name);

            using (var fileStream = new FileStream(document.DocumentPath, FileMode.Create))
            {
                document.DocumentFile.CopyTo(fileStream);
            }

            return document;
        }

        public IEnumerable<Models.Document> GetDocuments()
        {
            return _dbcontext.Document.ToList();
        }
    }
}
