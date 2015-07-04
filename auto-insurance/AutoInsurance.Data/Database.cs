using AutoInsurance.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoInsurance.Data
{
    public class Database : DbContext
    {
        public DbSet<Insured> Insured { get; set; }
    }
}
