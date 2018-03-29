open System.IO

type Observation = { Label:string; Pixels:int[]}

let trainingPath = @"C:\Users\nskolari\Documents\Projects\ML\DigitRecognizer\Data\trainingsample.csv"
let validationPath = @"C:\Users\nskolari\Documents\Projects\ML\DigitRecognizer\Data\validationsample.csv"

let toObservation (csvData:string) = 
    let columns = csvData.Split(',')
    let label = columns.[0]
    let pixels = columns.[1..] |> Array.map int
    { Label=label; Pixels = pixels}

let reader path = 
    let data = File.ReadAllLines path
    data.[1..] |> Array.map toObservation

let trainingData = reader trainingPath
