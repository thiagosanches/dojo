using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;

namespace Model
{
    public class Car
    {
        public virtual int Id { get; set; }
        public virtual int Year { get; set; }
        public virtual string Model { get; set; }
        public virtual string Manufacturer { get; set; }
    }

    public class CarMap : ClassMap<Car>
    {
        public CarMap()
        {
            Id(x => x.Id);
            Map(x => x.Manufacturer);
            Map(x => x.Model);
            Map(x => x.Year);
        }
    }
}
