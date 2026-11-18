using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Polyclinic.Entities;
using Polyclinic.Entities.Enums;

namespace Polyclinic.Repositories.Implementations
{
    internal class DoctorRepository : IDoctorRepository
    {
        public IEnumerable<Doctor> ReadDoctors() => [];
        public Doctor ReadDoctorById(int id) => Doctor.CreateEntity(0, "", Specialization.None, "");
        public void CreateDoctor(Doctor doctor) { }
        public void UpdateDoctor(Doctor doctor) { }
        public void DeleteDoctor(int id) { }
    }
}