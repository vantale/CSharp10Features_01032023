using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp10Features.Features.LINQExtensions
{
    internal class MaxMinBy
    {
        public void Execute()
        {
            var list = new List<Person>()
            {
                new Person {Name = "Jenny", LastName = "Smith", Age = 21, },
                new Person { Name = "Joe", LastName = "Hamilton", Age = 36, },
                new Person { Name = "Lucas", LastName = "Terry", Age = 45, },
                new Person { Name = "Lucas", LastName = "McFarral", Age = 55 },
                new Person { Name = "Jude", LastName = "McDonalds", Age = 55 } // comment out
            };

            var maxAge = list.Max(x => x.Age);
            var oldest = list.First(x => x.Age == maxAge);
            var oldestInOneGo = list.First(x => x.Age == list.Max(x => x.Age)); // FirstOrDefault or First

            var oldestInOneGo2 = list.First(x => 
            {
                var maxAge = list.Max(x => x.Age);
                WriteOnConsole();

                return x.Age == maxAge;
            });

            Person biggest = list.Aggregate((p1, p2) => p1.Age > p2.Age ? p1 : p2); // iterates only once

            var numbers = new List<int> { 6, 2, 8, 3 };
            var average = numbers.Aggregate(
                seed: 0,
                func: (result, item) => result + item,
                resultSelector: result => (decimal)result / numbers.Count);

            var sumOfAgesCheck = list.Sum(x => x.Age);

            int sum = 0;
            var sumOfAges = list.Aggregate(sum, (accumulator, person) => accumulator + person.Age);
            
            var oldestPerson = list.MaxBy(x => x.Age);

            var youngestPerson = list.MinBy(x => x.Age);

            var youngestPerson2 = list.OrderBy(x => x.Age).FirstOrDefault();
            var youngestPerson3 = list.OrderBy(x => x.Age).Take(1);

        }

        private static void WriteOnConsole() 
            => Console.WriteLine("I am from inside the lambda expression");
    }
}
