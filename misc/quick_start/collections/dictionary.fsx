open System.Collections.Generic

let inventory = Dictionary<string, float>()
inventory.Add("Apples", 0.79)
inventory["Oranges"] <- 0.25
inventory["Apples"]

// infer types
let inventory = Dictionary<_, _>()
inventory.Add("Apples", 0.79)

// also infer types
let inventory = Dictionary()
inventory.Add("Apples", 0.79)
inventory["Apples"]

[ "Apples", 10; "Bananas", 20; "Grapes", 15 ] |> dict |> Dictionary

let inventory : IDictionary<_, _> =
    [ "Apples", 0.33; "Oranges", 0.23; "Bananas", 0.45 ]
    |> dict

let bananas = inventory["Bananas"]

// these are errors
inventory["Cherries"] <- 0.76
inventory.Add("Oranges", 0.25)
inventory.Remove("Tangerines")

dict 