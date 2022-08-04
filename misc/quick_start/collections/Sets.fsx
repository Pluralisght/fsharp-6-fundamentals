let set1 = ["A"; "B"; "A"; "A"; "C"] |> Set.ofList
let set2 = [| "C"; "D"; "A"; "E"; "C" |] |> Set.ofArray
let set3 = [| "B"; "C"|] |> Set.ofArray

let set4 = set1.Add("Z")
let set5 = set2.Remove("F")

let union = set1 + set2 + set3
let distinctToSet1 = set1 - set2
let intersect = set1 |> Set.intersect set2
let isSubset = set1 |> Set.isSubset set3


type Result<'a> =
| Success of 'a
| Failure of string

type Result<'T,'TError> =
    | Ok of ResultValue:'T
    | Error of ErrorValue:'TError

