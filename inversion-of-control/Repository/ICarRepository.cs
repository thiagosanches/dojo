using System;
namespace Repository
{
    public interface ICarRepository
    {
        bool Delete(Model.Car obj);
        System.Collections.Generic.List<Model.Car> FindAll();
        void Save(Model.Car obj);
        bool Update(Model.Car obj);
    }
}
