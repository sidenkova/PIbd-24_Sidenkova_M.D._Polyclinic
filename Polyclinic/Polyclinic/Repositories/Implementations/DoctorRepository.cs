using System;
using System.Collections.Generic;
using System.Collections.Generic;
using System.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Polyclinic.Data;
using Polyclinic.Entities;
using Polyclinic.Entities.Enums;
using Serilog;

namespace Polyclinic.Repositories.Implementations
{
    internal class DoctorRepository : IDoctorRepository
    {
        private readonly DataContext _context;

        public DoctorRepository(DataContext context)
        {
            _context = context;
        }

        public IEnumerable<Doctor> ReadDoctors()
        {
            return _context.Doctors.AsNoTracking().ToList();
        }

        public Doctor ReadDoctorById(int id)
        {
            return _context.Doctors.AsNoTracking().FirstOrDefault(d => d.Id == id);
        }

        public void CreateDoctor(Doctor doctor)
        {
            _context.Doctors.Add(doctor);
            _context.SaveChanges();
            Log.Information("Добавлен врач: {FullName} (ID: {Id})", doctor.FullName, doctor.Id);
        }

        public void UpdateDoctor(Doctor doctor)
        {
            _context.Entry(doctor).State = EntityState.Detached;
            _context.Doctors.Update(doctor);
            _context.SaveChanges();
            Log.Information("Обновлен врач: {FullName} (ID: {Id})", doctor.FullName, doctor.Id);
        }

        public void DeleteDoctor(int id)
        {
            var doctor = _context.Doctors.Find(id);
            if (doctor != null)
            {
                _context.Doctors.Remove(doctor);
                _context.SaveChanges();
                Log.Information("Удален врач: {FullName} (ID: {Id})", doctor.FullName, id);
            }
        }
    }
}