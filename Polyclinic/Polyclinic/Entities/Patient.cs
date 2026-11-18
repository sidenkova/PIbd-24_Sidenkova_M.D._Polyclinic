using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polyclinic.Entities
{
    public class Patient
    {
        public int Id { get; private set; }
        public string FullName { get; private set; } = string.Empty;
        public DateTime BirthDate { get; private set; }
        public string Phone { get; private set; } = string.Empty;
        public string Address { get; private set; } = string.Empty;

        public static Patient CreateEntity(int id, string fullName, DateTime birthDate, string phone, string address)
        {
            return new Patient
            {
                Id = id,
                FullName = fullName ?? string.Empty,
                BirthDate = birthDate,
                Phone = phone ?? string.Empty,
                Address = address ?? string.Empty
            };
        }
    }
}
