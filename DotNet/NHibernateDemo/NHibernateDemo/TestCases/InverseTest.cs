using System.Collections.Generic;
using System.Linq;
using NHibernate.Linq;
using NHibernateDemo.Models;
using NUnit.Framework;

namespace NHibernateDemo.TestCases
{
    [TestFixture]
    public class InverseTest : TestBase
    {
        [TearDown]
        public void Cleanup()
        {
            Session.Flush();
            Transaction.Commit();
            Session.Dispose();
        }

        /// <summary>
        /// 需要修改Map文件
        /// </summary>
        [Test]
        public void 插入数据测试_非反转()
        {
            var s1 = new Student
            {
                Name = "Wenshao",
                No = "3105777",
            };
            var c1 = new Class
            {
                Name = "05级一班",
                Students = new List<Student> { s1 }
            };
            Session.Save(c1);
            Session.Flush();
        }

        [Test]
        public void 插入数据测试_反转()
        {
            var c2 = new Class
            {
                Name = "一年级2班",
            };
            var s2 = new Student
            {
                Name = "weiwen",
                No = "123456",
                Class = c2
            };

            var classes = Session.Query<Class>()
                .Where(c => c.Name == c2.Name)
                .ToList();
            var students = Session.Query<Student>()
                .Where(s => s.No == s2.No)
                .ToList();

            foreach (var @class in classes)
            {
                Session.Delete(@class);
                Session.Flush();
            }
            foreach (var student in students)
            {
                Session.Delete(student);
                Session.Flush();
            }
            Session.Save(c2);
            Session.Save(s2);
            Session.Flush();
        }
    }
}