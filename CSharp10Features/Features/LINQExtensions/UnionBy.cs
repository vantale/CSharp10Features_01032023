using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp10Features.Features.LINQExtensions
{
    internal class UnionBy
    {
        public void Execute() { 
        var list1 = new List<Person>()
            {
                new Person {Name = "Jenny", LastName = "Smith", Age = 21, },
                new Person { Name = "Joe", LastName = "Hamilton", Age = 36, },
            };

        var list2 = new List<Person>()
            {
                new Person {Name = "Jenny", LastName = "Smith", Age = 29, },
                new Person { Name = "Joe", LastName = "Hamilton", Age = 39, },
                new Person { Name = "Lucas", LastName = "Terry", Age = 45, },
                new Person { Name = "Lucas", LastName = "McFarral", Age = 55 }
            };

            var result0 = list1.Union(list2);

         var result = list1.UnionBy(list2, x => x.Name);
        }
    }
}
