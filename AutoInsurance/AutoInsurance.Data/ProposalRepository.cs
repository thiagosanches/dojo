using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoInsurance.Model;

namespace AutoInsurance.Data
{
    public class ProposalRepository
    {
        public bool Save(Proposal obj)
        {
            return true;
        }

        public List<Proposal> FindAll()
        {
            
            List<Proposal> proposal = new List<Proposal>();
            Proposal proposalObj = new Proposal();
            proposalObj.Id = 1;
            proposalObj.Value = 4000;
            proposalObj.Insured = new Insured();
            proposalObj.Insured.FirstName = "Joao";
            proposalObj.Car = new Car();
            proposalObj.Car.Model = "Ferrari";
            proposal.Add(proposalObj);

            return proposal;

        }

        public Proposal FindById(int Id)
        {
            return new Proposal();
        }

        public bool Delete(Proposal obj)
        {
            return true;
        }
    }
}