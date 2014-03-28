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
            try
            {
                Db db = new Db();
                db.Entry(obj.Car).State = System.Data.EntityState.Unchanged ;
                db.Entry(obj.Insured).State = System.Data.EntityState.Unchanged;
                db.Proposal.Add(obj);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public List<Proposal> FindAll()
        {
            try
            {
                Db db = new Db();
                return db.Proposal.Include("Car").Include("Insured").Where(i => i.Id > 0).ToList();
            }
            catch (Exception)
            {
                
                throw;
            }
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