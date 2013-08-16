using System.Collections.Generic;

namespace NHibernateDemo.Models
{
    public class Product
    {
        public virtual int Id { get; protected set; }

        public virtual string Name { get; set; }

        public virtual double Price { get; set; }

        public virtual IList<Store> Stores { get; protected set; }
    }
}