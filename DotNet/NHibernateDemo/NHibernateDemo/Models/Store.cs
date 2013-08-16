using System.Collections.Generic;

namespace NHibernateDemo.Models
{
    public class Store
    {
        private IList<Product> _products;
        private IList<Employee> _employees;

        public virtual int Id { get; set; }

        public virtual string Name { get; set; }

        public virtual IList<Product> Products
        {
            get { return _products ?? (_products = new List<Product>()); }
            set { _products = value; }
        }

        public virtual IList<Employee> Employees
        {
            get { return _employees ?? (_employees = new List<Employee>()); }
            set { _employees = value; }
        }

        public virtual void AddProduct(Product product)
        {
            product.Stores.Add(this);
            Products.Add(product);
        }

        public virtual void AddEmployee(Employee employee)
        {
            employee.Store = this;
            Employees.Add(employee);
        }
    }
}