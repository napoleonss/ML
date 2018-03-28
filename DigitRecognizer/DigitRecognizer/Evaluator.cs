using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Csharp
{
    public class Evaluator
    {
        public static double Correct( IEnumerable<Observation> validationSet, BasicClassifier classifier)
        {
            return validationSet.Select(obs => Score(obs, classifier))
                .Average();
        }

        static double Score(Observation obs, BasicClassifier classifier)
        {
            if (classifier.Predict(obs.Pixels) == obs.Label)
                return 1.0;
            else
                return 0.0;
        }
    }
}
