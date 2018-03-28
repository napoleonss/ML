using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Csharp
{
    public class DataReader
    {
        private static Observation ObservationFactory (string data)
        {
            var comaSeparated = data.Split(",");
            var label = comaSeparated[0];
            var pixels = comaSeparated.Skip(1)
                .Select(x => Convert.ToInt32(x))
                .ToArray();

            return new Observation(label, pixels);
        }

        public static Observation[] ReadObservations(string dataPath)
        {
            var data = File.ReadAllLines(dataPath)
                .Skip(1)
                .Select(ObservationFactory)
                .ToArray();

            return data;
        }
    }
}
