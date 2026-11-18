using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Polyclinic.Entities;

namespace Polyclinic.Repositories
{
    public interface IDoctorRepository
    {
        IEnumerable<Doctor> ReadDoctors();
        Doctor ReadDoctorById(int id);
        void CreateDoctor(Doctor doctor);
        void UpdateDoctor(Doctor doctor);
        void DeleteDoctor(int id);
    }
}