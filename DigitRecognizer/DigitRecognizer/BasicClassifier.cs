using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp
{
    public class BasicClassifier : IClassifier
    {
        IEnumerable<Observation> _data;
        readonly IDistance _distance;

        public BasicClassifier(IDistance distance)
        {
            _distance = distance;
        }

        public string Predict(int[] pixels)
        {
            Observation cussrentBest = null;
            var shortest = double.MaxValue;

            foreach(var obs in _data)
            {
                var dist = _distance.Between(obs.Pixels, pixels);
                if (dist < shortest)
                {
                    shortest = dist;
                    cussrentBest = obs;
                }
            }

            return cussrentBest.Label;
        }

        public void Train(IEnumerable<Observation> trainingSet)
        {
            _data = trainingSet;
        }
    }
}
