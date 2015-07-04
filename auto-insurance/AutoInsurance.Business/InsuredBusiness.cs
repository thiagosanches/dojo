using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoInsurance.Data;
using AutoInsurance.Model;

namespace AutoInsurance.Business
{
    public class InsuredBusiness
    {
        public bool Save(Insured obj)
        {
            InsuredRepository repository = new InsuredRepository();
            return repository.Save(obj);
        }

        public List<Insured> FindAll()
        {
            InsuredRepository repository = new InsuredRepository();
            return repository.FindAll();
        }

        public Insured FindById(int Id)
        {
            InsuredRepository repository = new InsuredRepository();
            return repository.FindById(Id);
        }

        public bool Delete(Insured obj)
        {
            InsuredRepository repository = new InsuredRepository();
            return repository.Delete(obj);
        }
    }
}