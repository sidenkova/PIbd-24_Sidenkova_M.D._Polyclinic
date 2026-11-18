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
using Serilog;

namespace Polyclinic.Repositories.Implementations
{
    internal class PatientDoctorRepository : IPatientDoctorRepository
    {
        private readonly DataContext _context;

        public PatientDoctorRepository(DataContext context)
        {
            _context = context;
        }

        public IEnumerable<PatientDoctor> ReadPatientDoctors()
        {
            return _context.PatientDoctors.AsNoTracking().ToList();
        }

        public void CreatePatientDoctor(PatientDoctor patientDoctor)
        {
            using var transaction = _context.Database.BeginTransaction();
            try
            {
                _context.PatientDoctors.Add(patientDoctor);
                _context.SaveChanges();
                transaction.Commit();
                Log.Information("Добавлена связка Пациент-Врач (Пациент: {PatientId}, Врач: {DoctorId})", patientDoctor.PatientId, patientDoctor.DoctorId);
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                Log.Error(ex, "Ошибка при добавлении связки Пациент-Врач");
                throw;
            }
        }
    }
}