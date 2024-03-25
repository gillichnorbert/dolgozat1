using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KockaSol
{
    public class Kocka
    {
        public double EdgeLength { get; set; }

        public Kocka(double edgeLength)
        {
            EdgeLength = edgeLength;
        }
        public double terfogatSzamitas()
        {
            return Math.Pow(EdgeLength, 3);
        }

        public double felszinSzamitas()
        {
            return 6 * Math.Pow(EdgeLength, 2);
        }

    }
}
