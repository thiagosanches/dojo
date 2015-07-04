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
            return true;
        }

        public List<Insured> FindAll()
        {
            return new List<Insured>();
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