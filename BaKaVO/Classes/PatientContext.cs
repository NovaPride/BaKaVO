using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace BaKaVO.Classes
{
    class PatientContext : DbContext
    {
        public PatientContext() : base("DefaultConnection")
        { }

        public DbSet<Patient> Patient { get; set; }
    }
}
