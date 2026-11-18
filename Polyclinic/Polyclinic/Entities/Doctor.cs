using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Polyclinic.Entities.Enums;

namespace Polyclinic.Entities
{
    public class Doctor
    {
        public int Id { get; internal set; }
        public string FullName { get; internal set; } = string.Empty;
        public Specialization Specialization { get; internal set; }
        public string Phone { get; internal set; } = string.Empty;

        public static Doctor CreateEntity(int id, string fullName, Specialization specialization, string phone)
        {
            return new Doctor
            {
                Id = id,
                FullName = fullName ?? string.Empty,
                Specialization = specialization,
                Phone = phone ?? string.Empty
            };
        }
    }
}
