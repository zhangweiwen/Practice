using FluentNHibernate.Mapping;
using NHibernateDemo.Models;

namespace NHibernateDemo.Mappings
{
    public class ProductMap : ClassMap<Product>
    {
        public ProductMap()
        {
            Id(x => x.Id);
            Map(x => x.Name);
            Map(x => x.Price);
            HasManyToMany(x => x.Stores)
                .LazyLoad()
                .Cascade.All()
                .Inverse()
                .Table("StoreProduct");
        }
    }
}