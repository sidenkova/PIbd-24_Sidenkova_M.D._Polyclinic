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
    internal class VisitRepository : IVisitRepository
    {
        private readonly DataContext _context;

        public VisitRepository(DataContext context)
        {
            _context = context;
        }

        public IEnumerable<Visit> ReadVisits(DateTime? dateFrom = null, DateTime? dateTo = null, int? patientId = null)
        {
            var query = _context.Visits.AsNoTracking().AsQueryable();

            if (dateFrom.HasValue)
                query = query.Where(v => v.VisitDate >= dateFrom.Value);

            if (dateTo.HasValue)
                query = query.Where(v => v.VisitDate <= dateTo.Value);

            if (patientId.HasValue)
                query = query.Where(v => v.PatientId == patientId.Value);

            return query.ToList();
        }

        public void CreateVisit(Visit visit)
        {
            _context.Visits.Add(visit);
            _context.SaveChanges();
            Log.Information("Добавлено посещение (ID: {Id}, Пациент: {PatientId}, Врач: {DoctorId})", visit.Id, visit.PatientId, visit.DoctorId);
        }
    }
}