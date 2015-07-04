using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository;

namespace Business
{
    public class InsuredBusiness : Business.IInsuredBusiness
    {
        public void Save(Insured obj)
        {
            try
            {
                InsuredRepository repository = new InsuredRepository();
                repository.Save(obj);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Delete(Insured obj)
        {
            try
            {
                InsuredRepository repository = new InsuredRepository();
                repository.Delete(obj);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Update(Insured obj)
        {
            try
            {
                InsuredRepository repository = new InsuredRepository();
                repository.Update(obj);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}