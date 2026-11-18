using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Polyclinic.Entities;

namespace Polyclinic.Repositories
{
    public interface IPatientDoctorRepository
    {
        IEnumerable<PatientDoctor> ReadPatientDoctors();
        void CreatePatientDoctor(PatientDoctor patientDoctor);
    }
}