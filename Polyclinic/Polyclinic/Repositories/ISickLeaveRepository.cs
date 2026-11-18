using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Polyclinic.Entities;

namespace Polyclinic.Repositories
{
    public interface ISickLeaveRepository
    {
        IEnumerable<SickLeave> ReadSickLeaves(DateTime? dateFrom = null, int? patientId = null);
        void CreateSickLeave(SickLeave sickLeave);
    }
}