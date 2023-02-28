using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp10Features.Features.LINQExtensions
{
    public class DistinctBy
    {
        public void Execute()
        {
            var list = new List<Person>() 
            {
                new Person {Name = "Jenny", LastName = "Smith", Age = 21, },
                new Person { Name = "Joe", LastName = "Hamilton", Age = 36, }, 
                new Person { Name = "Lucas", LastName = "Terry", Age = 45, },
                new Person { Name = "Lucas", LastName = "McFarral", Age = 55 }
            };

            var searchedValue = list.DistinctBy(x => x.Name);
        }
    }
}
