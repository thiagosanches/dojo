using Model;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class CarBusiness : ICarBusiness
    {
        private ICarRepository _carRepository;

        public CarBusiness(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        public void Save(Car obj)
        {
            try
            {                
                _carRepository.Save(obj);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Delete(Car obj)
        {
            bool success = false;

            try
            {
                success = _carRepository.Delete(obj);    
            }
            catch (Exception)
            {
                throw;
            }

            return success;
        }

        public bool Update(Car obj)
        {
            return _carRepository.Update(obj);

        }

        public List<Car> FindAll()
        {
            List<Car> cars = null;

            try
            {
               cars = _carRepository.FindAll();
            }
            catch (Exception)
            {
                throw;
            }

            return cars;
        }
    }
}