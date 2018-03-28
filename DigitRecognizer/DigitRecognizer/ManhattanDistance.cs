using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp
{
    public class ManhattanDistance : IDistance
    {
        public double Between(int[] pixels1, int[] pixels2)
        {
            if (pixels1.Length != pixels2.Length)
                throw new ArgumentException("Inconsistent image sizes.");

            var length = pixels1.Length;
            var distance = 0;

            for (var i = 0; i < length; i++)
                distance += Math.Abs(pixels1[i] - pixels1[i]);

            return distance;
        }
    }
}
