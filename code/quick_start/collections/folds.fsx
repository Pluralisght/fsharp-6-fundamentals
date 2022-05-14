
let sum items = Array.fold (+) 0 items
sum [|1..10|]
Array.mapFold

let toList array = Array.foldBack (fun h t -> h :: t) array []
toList [|1..10|]

let sumImperative items =
    let mutable accum = 0
    for item in items do accum <- accum + item
    accum

sumImperative [1..10]

let rec sumRecursive items accum =
    match items with 
    | [] -> accum
    | h::t -> sumRecursive t (h + accum)
sumRecursive [1..10] 0

let rec sum items =
    let rec internalRecursiveSum items accum =
        match items with 
        | [] -> accum
        | h::t -> internalRecursiveSum t (h + accum)
    internalRecursiveSum items 0
sum [1..10]

let sum items = 
    Seq.fold (+) 0 items

let sum items =
    Seq.fold
        (fun state item -> state + item)
        0
        items
sum[1..10]

let sum items =
    Seq.fold
        (fun state item -> 
        let newState = state + item
        printfn "Current state: %A, item: %A, new state: %A"
            state
            item
            newState
        newState)
        0
        items
sum[1..5]
