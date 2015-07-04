using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Business;
using Repository;
using StructureMap.Configuration.DSL;


namespace Web
{
    public class MyRegistry : Registry
    {
        public MyRegistry()
        {
            For<ICarRepository>().Use<CarRepository>();
            For<ICarBusiness>().Use<CarBusiness>();
        }
    }
}