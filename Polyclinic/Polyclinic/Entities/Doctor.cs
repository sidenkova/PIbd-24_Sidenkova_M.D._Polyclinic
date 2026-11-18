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
        public int Id { get; private set; }
        public string FullName { get; private set; } = string.Empty;
        public Specialization Specialization { get; private set; }
        public string Phone { get; private set; } = string.Empty;

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
