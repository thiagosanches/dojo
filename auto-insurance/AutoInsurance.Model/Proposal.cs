using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoInsurance.Model
{
    public class Proposal
    {
        public int Id { get; set; }
        public int Value { get; set; }
        public Car Car { get; set; }
        public Insured Insured { get; set; }
    }
}