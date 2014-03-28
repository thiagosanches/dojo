using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoInsurance.Model;

namespace AutoInsurance.Data
{
    public class InsuredRepository
    {
        public bool Save(Insured obj)
        {
            try
            {
                Db db = new Db();
                db.Insured.Add(obj);
                db.SaveChanges();
                return true;
            } 
            catch (Exception)
            {
                
                throw;
            }
           
        }

        public List<Insured> FindAll()
        {
            try
            {
                Db db = new Db();
                return db.Insured.Where(i => i.Id > 0).ToList();
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public Insured FindById(int Id)
        {
            return new Insured();
        }

        public bool Delete(Insured obj)
        {
            return true;
        }
    }
}