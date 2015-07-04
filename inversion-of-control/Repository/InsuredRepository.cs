using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate.Cfg;
using System.Reflection;
using NHibernate.Driver;
using NHibernate.Dialect;
using NHibernate;

namespace Repository
{
    public class InsuredRepository
    {
        public void Save(Insured obj)
        {
            Configuration config = new Configuration().Configure();

            config.Configure().DataBaseIntegration(n =>
            {
                n.ConnectionString = "Data Source=(localdb)\\v11.0;Initial Catalog=impactanalysis;";
                n.Driver<SqlClientDriver>();
                n.Dialect<MsSql2012Dialect>();
            });

            config.AddAssembly("Model");
            ISessionFactory sessionFactory = config.BuildSessionFactory();

            using (ISession session = sessionFactory.OpenSession())
            {
                using (ITransaction t = session.BeginTransaction())
                {
                    session.Save(obj);
                    t.Commit();
                }
            }
        }

        public void Delete(Insured obj)
        {

        }

        public void Update(Insured obj)
        {

        }
    }
}