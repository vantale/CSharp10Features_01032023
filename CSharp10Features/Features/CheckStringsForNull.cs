using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp10Features.Features
{
    internal class CheckStringsForNull
    {
        public void Execute(string firstName, string lastName)
        {
            if(firstName == null)
                throw new ArgumentNullException(nameof(firstName));
        }

        public void Execute2(string firstName, string lastName)
        {
            ArgumentNullException.ThrowIfNull(nameof(firstName), nameof(lastName));
        }
    }


}
