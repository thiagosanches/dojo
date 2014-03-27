using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AutoInsurance.Web.Models
{
    public class ProposalViewModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Rg { get; set; }
        public string Gender { get; set; }
        public List<Model.Car> Cars { get; set; }
        public int CarId { get; set; }
        public decimal Value { get; set; }        
    }
}