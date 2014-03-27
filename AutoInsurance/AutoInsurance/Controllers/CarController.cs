using AutoInsurance.Business;
using AutoInsurance.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AutoInsurance.Web.Controllers
{
    public class CarController : Controller
    {
        //
        // GET: /Car/

        public ActionResult Index(ProposalViewModel dados)
        {

            CarBusiness CarBusiness = new CarBusiness();
            dados.Cars = CarBusiness.FindAll();


            
            return View(dados);
        }

    }
}
