using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp10Features.Features.ImprovementsToLambdas
{
    internal class ReturnTypeForLambda
    {
        public void Execute()
        {
            Func<int[]>? oneTwoThreeArray = () => new[] { 1, 2, 3 }; //  // inferred type is Func<int[]>
            var oneTwoThreeList = IList<int> () => new[] { 1, 2, 3 }; // same body, but inferred type is now Func<IList<int>>

        }
    }
}
