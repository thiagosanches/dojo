using System;
namespace Business
{
    public interface IInsuredBusiness
    {
        void Delete(Model.Insured obj);
        void Save(Model.Insured obj);
        void Update(Model.Insured obj);
    }
}
