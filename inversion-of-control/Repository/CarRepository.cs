using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using NHibernate.Linq;
using NHibernate.Cfg;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using FluentNHibernate.Conventions.Helpers;

namespace Repository
{
    public class CarRepository : ICarRepository
    {
        public CarRepository()
        {

        }

        public ISessionFactory GetSession()
        {
            var connectionString = "server=(localdb)\\v11.0;database=inversionofcontrol;Integrated Security=true;";

            return Fluently.Configure()
               .Database(MsSqlConfiguration.MsSql2008.ConnectionString(connectionString).AdoNetBatchSize(30))
               .Mappings(m => m.FluentMappings.AddFromAssemblyOf<Car>().Conventions.Add(AutoImport.Never()))
               .BuildSessionFactory();
        }

        public void Save(Car obj)
        {
            var sessionFactory = GetSession();
            using (var session = sessionFactory.OpenSession())
            {
                session.Save(obj);
            }
        }

        public bool Delete(Car obj)
        {
            var sessionFactory = GetSession();

            using (var session = sessionFactory.OpenSession())
            {
                try
                {
                    session.Delete(obj);
                    session.Flush();

                    return true;
                }
                catch (Exception)
                {
                    return false;
                }

            }
        }

        public bool Update(Car obj)
        {
            var sessionFactory = GetSession();
            
            using (var session = sessionFactory.OpenSession())
            {
                try
                {
                    session.Update(obj);
                    session.Flush();

                    return true;
                } catch(Exception) 
                {
                    return false;
                }
                
            }
        }

        public List<Car> FindAll()
        {
            ISessionFactory sessionFactory = GetSession();
            using (ISession session = sessionFactory.OpenSession())
            {
                return session.Query<Car>().ToList();
            }
        }
    }
}