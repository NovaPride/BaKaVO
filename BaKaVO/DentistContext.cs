using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace BaKaVO.Classes
{
    class DentistContext : DbContext
    {
        public DentistContext() : base("DefaultConnection")
        { }

        public DbSet<Dentist> Dentist { get; set; }
    }
}
