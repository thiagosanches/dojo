using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business;
using Model;
using NUnit.Framework;
using Repository;
using StructureMap.Configuration;

namespace Test
{
    [TestFixture]
    public class CarTest
    {
        StructureMap.Container containter;
        
        [SetUp]
        public void Setup() 
        {
            containter = new StructureMap.Container();
            containter.Configure(x => x.For<ICarRepository>().Use<CarRepository>());
        }

        [Test]
        public void AddCar()
        {
             
           ICarBusiness carBusiness = containter.GetInstance<CarBusiness>();

            Car car = new Car()
            {
                Manufacturer = "Ferrari",
                Model = "Spider",
                Year = 2014
            };

            carBusiness.Save(car);

            Assert.Greater(car.Id, 0);
        }

        [Test]
        public void DeleteCar() 
        {
            ICarBusiness carBusiness = containter.GetInstance<CarBusiness>();
            Car car = new Car() { Id = 6 };

            Assert.AreEqual(true, carBusiness.Delete(car));            
        }

        [Test]
        public void UpdateCar()
        {
            ICarBusiness carBusiness = containter.GetInstance<CarBusiness>();
            Car car = new Car() { Id = 6, Model = "F50", Manufacturer = "Mazda" };

            bool status = carBusiness.Update(car);

            Assert.IsTrue(status);


        }

        [Test]
        public void FindAllCar()
        {
            ICarBusiness carBusiness = containter.GetInstance<CarBusiness>();
            var count = carBusiness.FindAll().Count;

            Car car = new Car() { Id = 1, Model = "F50", Manufacturer = "Ferrari" };

            carBusiness.Save(car);

            var count2 = carBusiness.FindAll().Count;
            Assert.AreEqual(++count, count2);
        }
    }
}
