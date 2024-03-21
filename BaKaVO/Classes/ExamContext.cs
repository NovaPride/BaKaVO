using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace BaKaVO.Classes
{
    class ExamContext : DbContext
    {
        public ExamContext() : base("DefaultConnection")
        { }

        public DbSet<Exam> Exam { get; set; }
    }
}
