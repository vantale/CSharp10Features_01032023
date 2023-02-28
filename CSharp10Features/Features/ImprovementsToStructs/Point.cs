using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp10Features.Features.ImprovementsToStructs
{
    // parameterless constructor and initialisers
    public struct Point
    {
        public int X;
        public int Y;
        public int Z { get; set; } = 2; // initialisers

         public Point() // internal, protected ?
        {
            X = 0; // initalisation mandatory
            Y = 0;
        }
    }
}
