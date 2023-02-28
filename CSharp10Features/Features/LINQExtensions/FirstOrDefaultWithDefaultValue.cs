using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp10Features.Features.LINQExtensions
{
    public class FirstOrDefaultWithDefaultValue
    {
        public void Execute1()
        {
            var list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var searchedValue = list.FirstOrDefault(x => x == 11, -1000);

        }

        public void Execute()
        {
            var list = new List<Person>();
            var searchedValue = list.FirstOrDefault(x => x.Name == "Anna", NullPerson.Instance);
        }


    }

    public class Person
    {
        public string? Name { get; set; }   
        public string? LastName { get; set; }
        public int Age { get; set; }
    }

    public class NullPerson : Person
    {
        public static NullPerson Instance => new() { LastName ="Unknown", Name = "Unknown" };
    }
}
