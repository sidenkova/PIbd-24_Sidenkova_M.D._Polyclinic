using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Polyclinic.Entities.Enums;

namespace Polyclinic.Entities
{
    public class Visit
    {
        public int Id { get; private set; }
        public int PatientId { get; private set; }
        public int DoctorId { get; private set; }
        public int DiseaseId { get; private set; }
        public DateTime VisitDate { get; private set; }
        public Symptoms Symptoms { get; private set; }

        public static Visit CreateOperation(int id, int patientId, int doctorId, int diseaseId, Symptoms symptoms)
        {
            return new Visit
            {
                Id = id,
                PatientId = patientId,
                DoctorId = doctorId,
                DiseaseId = diseaseId,
                VisitDate = DateTime.Now,
                Symptoms = symptoms
            };
        }
    }
}