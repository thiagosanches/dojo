using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoInsurance.Data;
using AutoInsurance.Model;

namespace AutoInsurance.Business
{
    public class CarBusiness
    {
        public bool Save(Car obj)
        {
            CarRepository repository = new CarRepository();
            return repository.Save(obj);
        }

        public List<Car> FindAll()
        {
            CarRepository repository = new CarRepository();
            return repository.FindAll();
        }

        public Car FindById(int Id)
        {
            CarRepository repository = new CarRepository();
            return repository.FindById(Id);
        }

        public bool Delete(Car obj)
        {
            CarRepository repository = new CarRepository();
            return repository.Delete(obj);
        }
    }
}
