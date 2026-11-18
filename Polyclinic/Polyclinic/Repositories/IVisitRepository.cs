using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Polyclinic.Entities;

namespace Polyclinic.Repositories
{
    public interface IVisitRepository
    {
        IEnumerable<Visit> ReadVisits(DateTime? dateFrom = null, DateTime? dateTo = null, int? patientId = null);
        void CreateVisit(Visit visit);
    }
}
