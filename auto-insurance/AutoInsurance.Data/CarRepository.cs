using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoInsurance.Model;

namespace AutoInsurance.Data
{
    public class CarRepository
    {
        public bool Save(Car obj)
        {
            return true;
        }

        public List<Car> FindAll()
        {
            return new List<Car>();
        }

        public Car FindById(int Id)
        {
            return new Car();
        }

        public bool Delete(Car obj)
        {
            return true;
        }
    }
}