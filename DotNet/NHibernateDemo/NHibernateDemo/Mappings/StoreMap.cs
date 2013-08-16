using FluentNHibernate.Mapping;
using NHibernateDemo.Models;

namespace NHibernateDemo.Mappings
{
    public class StoreMap : ClassMap<Store>
    {
        public StoreMap()
        {
            Id(x => x.Id);
            Map(x => x.Name);
            HasMany(x => x.Employees)
                .Inverse()
                .Cascade.All();
            HasManyToMany(x => x.Products)
                .LazyLoad()
                .Cascade.All()
                .Table("StoreProduct");
        }
    }
}