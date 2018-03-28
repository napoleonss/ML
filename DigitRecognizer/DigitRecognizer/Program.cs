using Csharp;
using System;

namespace DigitRecognizer
{
    class Program
    {
        static void Main(string[] args)
        {
            const string trainingPath = @"C:\Users\nskolari\Documents\Projects\ML\DigitRecognizer\Data\trainingsample.csv";
            const string validationPath = @"C:\Users\nskolari\Documents\Projects\ML\DigitRecognizer\Data\validationsample.csv";

            var distance = new ManhattanDistance();
            var classifier = new BasicClassifier(distance);

            var training = DataReader.ReadObservations(trainingPath);
            classifier.Train(training);

            var validation = DataReader.ReadObservations(validationPath);

            var correct = Evaluator.Correct(validation, classifier);
            Console.WriteLine("Correctly classified {0:P2}", correct);

            Console.ReadLine();
        }
    }
}
