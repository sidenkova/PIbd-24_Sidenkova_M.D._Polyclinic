using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Polyclinic.Entities;

namespace Polyclinic.Repositories.Implementations
{
    internal class SickLeaveRepository : ISickLeaveRepository
    {
        public IEnumerable<SickLeave> ReadSickLeaves(DateTime? dateFrom = null, int? patientId = null) => [];
        public void CreateSickLeave(SickLeave sickLeave) { }
    }
}