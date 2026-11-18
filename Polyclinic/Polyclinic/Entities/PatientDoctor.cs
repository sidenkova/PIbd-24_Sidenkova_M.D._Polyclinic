using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polyclinic.Entities
{
    public class PatientDoctor
    {
        public int Id { get; internal set; }
        public int PatientId { get; internal set; }
        public int DoctorId { get; internal set; }

        public static PatientDoctor CreateLink(int id, int patientId, int doctorId)
        {
            return new PatientDoctor
            {
                Id = id,
                PatientId = patientId,
                DoctorId = doctorId
            };
        }
    }
}
