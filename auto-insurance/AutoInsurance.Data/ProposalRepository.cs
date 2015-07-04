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
            return new List<Proposal>();
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