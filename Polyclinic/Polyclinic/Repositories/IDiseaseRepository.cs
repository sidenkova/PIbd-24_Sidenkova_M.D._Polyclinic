using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Polyclinic.Entities;

namespace Polyclinic.Repositories
{
    public interface IDiseaseRepository
    {
        IEnumerable<Disease> ReadDiseases();
        Disease ReadDiseaseById(int id);
        void CreateDisease(Disease disease);
        void UpdateDisease(Disease disease);
        void DeleteDisease(int id);
    }
}