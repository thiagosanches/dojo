using AutoInsurance.Business;
using AutoInsurance.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AutoInsurance.Web.Controllers
{
    public class ProposalController : Controller
    {
        //
        // GET: /Proposal/

        public ActionResult Index(ProposalViewModel pvModel)
        {
            ProposalBusiness business = new ProposalBusiness();
            pvModel.Value = business.Calculate(new Model.Proposal());

            return View(pvModel);
        }

        public ActionResult List()
            
        {
            ProposalBusiness business = new ProposalBusiness();
            
            return View(business.FindAll());
        }
        public ActionResult Search(string search)
        {
            ProposalBusiness business = new ProposalBusiness();
            return View("List",business.FindAll().
                FindAll(i => i.Insured.FirstName.
                    Contains(search)));
        }
    }
}