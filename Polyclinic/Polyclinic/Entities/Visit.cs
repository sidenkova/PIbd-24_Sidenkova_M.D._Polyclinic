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
        public int Id { get; internal set; }
        public int PatientId { get; internal set; }
        public int DoctorId { get; internal set; }
        public int DiseaseId { get; internal set; }
        public DateTime VisitDate { get; internal set; }
        public Symptoms Symptoms { get; internal set; }

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