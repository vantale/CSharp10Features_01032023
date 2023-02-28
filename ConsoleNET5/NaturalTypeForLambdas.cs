using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp10Features.Features.ImprovementsToLambdas
{
    internal class NaturalTypeForLambdas
    {

        public void Execute()
        {
            Func<int, bool> isEven = (n) => n % 2 == 0;
            var isEven2 = (int n) => n % 2 == 0; // before it was not possible to infer the type so the var was not possible
        }
    }
}
