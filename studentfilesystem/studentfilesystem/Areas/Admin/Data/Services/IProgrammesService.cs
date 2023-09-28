using studentfilesystem.Models;
using System.Collections.Generic;

namespace studentfilesystem.Areas.Admin.Data.Services
{
    public interface IProgrammesService
    {
        void AddProgramme(Programme programme);
        IEnumerable<Programme> GetProgrammes();
    }
}
