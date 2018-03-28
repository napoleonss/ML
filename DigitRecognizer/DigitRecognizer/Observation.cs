using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp
{
    public class Observation
    {
        public Observation(string label, int[] pixels)
        {
            Label = label;
            Pixels = pixels;
        }

        public string Label { get; private set; }

        public int[] Pixels { get;  private set; }
    }
}

