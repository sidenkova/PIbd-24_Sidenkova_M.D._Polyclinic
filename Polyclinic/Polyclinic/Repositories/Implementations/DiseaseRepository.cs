using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Polyclinic.Entities;

namespace Polyclinic.Repositories.Implementations
{
    internal class DiseaseRepository : IDiseaseRepository
    {
        public IEnumerable<Disease> ReadDiseases() => [];
        public Disease ReadDiseaseById(int id) => Disease.CreateEntity(0, "", "");
        public void CreateDisease(Disease disease) { }
        public void UpdateDisease(Disease disease) { }
        public void DeleteDisease(int id) { }
    }
}