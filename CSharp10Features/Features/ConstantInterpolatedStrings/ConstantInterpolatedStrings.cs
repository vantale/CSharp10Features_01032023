using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp10Features.Features.ConstantInterpolatedStrings
{
    public class ConstantInterpolatedStrings
    {
        public void Execute(string firstName, string lastName)
        {
            // const string person = $"{firstName} {lastName}";
        }

        private const string firstName ="K";
        private const string lastName = "L";
        public void Execute()
        {
            const string person = $"{firstName} {lastName}";
        }
    }
}
