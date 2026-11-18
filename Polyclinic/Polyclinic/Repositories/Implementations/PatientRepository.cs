using System;
using System;
using System.Collections.Generic;
using System.Collections.Generic;
using System.Collections.Generic;
using System.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Polyclinic.Data;
using Polyclinic.Entities;
using Serilog;

namespace Polyclinic.Repositories.Implementations
{
    internal class PatientRepository : IPatientRepository
    {
        private readonly DataContext _context;

        public PatientRepository(DataContext context)
        {
            _context = context;
        }

        public IEnumerable<Patient> ReadPatients()
        {
            return _context.Patients.AsNoTracking().ToList();
        }

        public Patient ReadPatientById(int id)
        {
            return _context.Patients
                .AsNoTracking()
                .FirstOrDefault(p => p.Id == id);
        }

        public void CreatePatient(Patient patient)
        {
            _context.Patients.Add(patient);
            _context.SaveChanges();
            Log.Information("Добавлен пациент: {FullName} (ID: {Id})", patient.FullName, patient.Id);
        }

        public void UpdatePatient(Patient patient)
        {
            _context.Entry(patient).State = EntityState.Detached;
            _context.Patients.Update(patient);
            _context.SaveChanges();
            Log.Information("Обновлен пациент: {FullName} (ID: {Id})", patient.FullName, patient.Id);
        }

        public void DeletePatient(int id)
        {
            var patient = _context.Patients.Find(id);
            if (patient != null)
            {
                _context.Patients.Remove(patient);
                _context.SaveChanges();
                Log.Information("Удален пациент: {FullName} (ID: {Id})", patient.FullName, id);
            }
        }
    }
}