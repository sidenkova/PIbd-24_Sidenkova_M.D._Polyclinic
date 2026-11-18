using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace Polyclinic.Entities.Enums
{
    [Flags]
    public enum Symptoms
    {
        None = 0,
        Cough = 1,
        Fever = 2,
        RunnyNose = 4,
        Headache = 8,
        Fatigue = 16
    }
}
