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
    internal class DiseaseRepository : IDiseaseRepository
    {
        private readonly DataContext _context;

        public DiseaseRepository(DataContext context)
        {
            _context = context;
        }

        public IEnumerable<Disease> ReadDiseases()
        {
            return _context.Diseases.AsNoTracking().ToList();
        }

        public Disease ReadDiseaseById(int id)
        {
            return _context.Diseases.AsNoTracking().FirstOrDefault(d => d.Id == id);
        }

        public void CreateDisease(Disease disease)
        {
            _context.Diseases.Add(disease);
            _context.SaveChanges();
            Log.Information("Добавлена болезнь: {Name} (ID: {Id})", disease.Name, disease.Id);
        }

        public void UpdateDisease(Disease disease)
        {
            _context.Entry(disease).State = EntityState.Detached;
            _context.Diseases.Update(disease);
            _context.SaveChanges();
            Log.Information("Обновлена болезнь: {Name} (ID: {Id})", disease.Name, disease.Id);
        }

        public void DeleteDisease(int id)
        {
            var disease = _context.Diseases.Find(id);
            if (disease != null)
            {
                _context.Diseases.Remove(disease);
                _context.SaveChanges();
                Log.Information("Удалена болезнь: {Name} (ID: {Id})", disease.Name, id);
            }
        }
    }
}