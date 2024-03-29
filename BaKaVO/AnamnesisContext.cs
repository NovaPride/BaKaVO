using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace BaKaVO.Classes
{
    class AnamnesisContext : DbContext
    {
        public AnamnesisContext() : base("DefaultConnection")
        { }

        public DbSet<Anamnesis> Anamnesis { get; set; }
    }
}
