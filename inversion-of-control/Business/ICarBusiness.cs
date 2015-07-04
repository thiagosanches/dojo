using System;
namespace Business
{
    public interface ICarBusiness
    {
        bool Delete(Model.Car obj);
        System.Collections.Generic.List<Model.Car> FindAll();
        void Save(Model.Car obj);
        bool Update(Model.Car obj);
    }
}
