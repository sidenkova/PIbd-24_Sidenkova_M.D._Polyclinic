using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polyclinic.Entities
{
    public class SickLeave
    {
        public int Id { get; internal set; }
        public int PatientId { get; internal set; }
        public int DoctorId { get; internal set; }
        public DateTime StartDate { get; internal set; }
        public DateTime EndDate { get; internal set; }

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