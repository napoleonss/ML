using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp
{
    public interface IClassifier
    {
        void Train(IEnumerable<Observation> trainingSet);
        string Predict(int[] pixels);
    }
}
