using AutoInsurance.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoInsurance.Data
{
    public class Db : DbContext
    {
        public DbSet<Car> Car { get; set; }
        public DbSet<Insured> Insured { get; set; }
        public DbSet<Proposal> Proposal { get; set; }
    }
   
}
