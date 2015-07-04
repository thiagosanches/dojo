using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AutoInsurance.Web.Models
{
    public class ProposalViewModel
    {
        public List<Model.Car> Cars { get; set; }
        public Model.Proposal Proposal { get; set; }
        public int CarId { get; set; }
    }
}