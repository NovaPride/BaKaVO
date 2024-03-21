using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace BaKaVO.Classes
{
    class DiaryContext : DbContext
    {
        public DiaryContext() : base("DefaultConnection")
        { }

        public DbSet<Diary> Diary { get; set; }
    }
}
