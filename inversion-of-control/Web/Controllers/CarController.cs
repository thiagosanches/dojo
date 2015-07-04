using Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StructureMap.Configuration;
using StructureMap;

namespace Web.Controllers
{
    public class CarController : Controller
    {
        public ICarBusiness CarBusiness{get;set;}


        public CarController() 
        {
            CarBusiness = ObjectFactory.GetInstance<ICarBusiness>();
        }
        public ActionResult Index()
        {

            return View(CarBusiness.FindAll());
     
        }

        public ActionResult Edit(int id)
        {
            return View();

        }
    }
}