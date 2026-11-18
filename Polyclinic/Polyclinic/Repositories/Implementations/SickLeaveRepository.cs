using System;
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
    internal class SickLeaveRepository : ISickLeaveRepository
    {
        private readonly DataContext _context;

        public SickLeaveRepository(DataContext context)
        {
            _context = context;
        }

        public IEnumerable<SickLeave> ReadSickLeaves(DateTime? dateFrom = null, int? patientId = null)
        {
            var query = _context.SickLeaves.AsNoTracking().AsQueryable();

            if (dateFrom.HasValue)
                query = query.Where(s => s.StartDate >= dateFrom.Value);

            if (patientId.HasValue)
                query = query.Where(s => s.PatientId == patientId.Value);

            return query.ToList();
        }

        public void CreateSickLeave(SickLeave sickLeave)
        {
            _context.SickLeaves.Add(sickLeave);
            _context.SaveChanges();
            Log.Information("Добавлен больничный (ID: {Id}, Пациент: {PatientId})", sickLeave.Id, sickLeave.PatientId);
        }

        public void DeleteSickLeave(int id)
        {
            var sickLeave = _context.SickLeaves.Find(id);
            if (sickLeave != null)
            {
                _context.SickLeaves.Remove(sickLeave);
                _context.SaveChanges();
                Log.Information("Удален больничный (ID: {Id})", id);
            }
        }
    }
}