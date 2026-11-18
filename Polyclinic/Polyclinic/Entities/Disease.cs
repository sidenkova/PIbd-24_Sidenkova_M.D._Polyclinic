using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polyclinic.Entities
{
    public class Disease
    {
        public int Id { get; internal set; }
        public string Name { get; internal set; } = string.Empty;
        public string Code { get; internal set; } = string.Empty;

        public static Disease CreateEntity(int id, string name, string code)
        {
            return new Disease
            {
                Id = id,
                Name = name ?? string.Empty,
                Code = code ?? string.Empty
            };
        }
    }
}
