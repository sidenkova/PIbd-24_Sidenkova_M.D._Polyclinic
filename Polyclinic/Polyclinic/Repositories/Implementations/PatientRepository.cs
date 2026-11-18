using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Collections.Generic;
using Polyclinic.Entities;

namespace Polyclinic.Repositories.Implementations
{
    internal class PatientRepository : IPatientRepository
    {
        public IEnumerable<Patient> ReadPatients() => [];
        public Patient ReadPatientById(int id) => Patient.CreateEntity(0, "", DateTime.Now, "", "");
        public void CreatePatient(Patient patient) { }
        public void UpdatePatient(Patient patient) { }
        public void DeletePatient(int id) { }
    }
}