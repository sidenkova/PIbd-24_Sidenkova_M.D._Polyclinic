using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polyclinic.Entities
{
    public class SickLeave
    {
        public int Id { get; private set; }
        public int PatientId { get; private set; }
        public int DoctorId { get; private set; }
        public DateTime StartDate { get; private set; }
        public DateTime EndDate { get; private set; }

        public static SickLeave CreateOperation(int id, int patientId, int doctorId, DateTime startDate, DateTime endDate)
        {
            return new SickLeave
            {
                Id = id,
                PatientId = patientId,
                DoctorId = doctorId,
                StartDate = startDate,
                EndDate = endDate
            };
        }
    }
}