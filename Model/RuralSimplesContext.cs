using RuralSimples.Classes;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuralSimples.Model
{
    class RuralSimplesContext:DbContext
    {
        public RuralSimplesContext():base("PgRuralSimples")
        {
        }
        public DbSet<Pessoa> pessoas { get; set; }
    }
}
