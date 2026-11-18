using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Polyclinic.Entities;

namespace Polyclinic.Repositories.Implementations
{
    internal class PatientDoctorRepository : IPatientDoctorRepository
    {
        public IEnumerable<PatientDoctor> ReadPatientDoctors() => [];
        public void CreatePatientDoctor(PatientDoctor patientDoctor) { }
    }
}