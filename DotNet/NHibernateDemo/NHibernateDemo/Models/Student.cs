namespace NHibernateDemo.Models
{
    public class Student
    {
        public virtual int Id { get; protected set; }
        public virtual string No { get; set; }
        public virtual string Name { get; set; }
        public virtual Class Class { get; set; }
    }
}