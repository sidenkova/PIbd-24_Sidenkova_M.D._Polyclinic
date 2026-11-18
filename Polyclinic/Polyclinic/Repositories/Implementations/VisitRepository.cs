using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Polyclinic.Entities;

namespace Polyclinic.Repositories.Implementations
{
    internal class VisitRepository : IVisitRepository
    {
        public IEnumerable<Visit> ReadVisits(DateTime? dateFrom = null, DateTime? dateTo = null, int? patientId = null) => [];
        public void CreateVisit(Visit visit) { }
    }
}