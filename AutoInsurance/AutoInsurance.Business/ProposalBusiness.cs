using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoInsurance.Data;
using AutoInsurance.Model;

namespace AutoInsurance.Business
{
    public class ProposalBusiness
    {
        public bool Save(Proposal obj)
        {
            ProposalRepository repository = new ProposalRepository();
            try
            {
                InsuredBusiness iBusiness = new InsuredBusiness();
                iBusiness.Save(obj.Insured);

                CarBusiness cBusiness = new CarBusiness();
                obj.Car = cBusiness.FindAll().Find(i => i.Id == obj.Car.Id);
                return repository.Save(obj);
            }
            catch (Exception)
            {

                throw;
            }

        }

        public List<Proposal> FindAll()
        {
            ProposalRepository repository = new ProposalRepository();
            return repository.FindAll();
        }

        public Proposal FindById(int Id)
        {
            ProposalRepository repository = new ProposalRepository();
            return repository.FindById(Id);
        }

        public bool Delete(Proposal obj)
        {
            ProposalRepository repository = new ProposalRepository();
            return repository.Delete(obj);
        }
        public decimal Calculate(Proposal obj)
        {
            return (decimal)new Random().Next(1, 50000);
        }
    }
}