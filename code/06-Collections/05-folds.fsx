let sumImperative items =
    let mutable accum = 0 // empty accumulator
    for item in items do // go through every item
        accum <- accum + item // update accumulator
    accum // return accumulator
sumImperative [1..10]

let rec sum items accum =
    match items with 
    | [] -> accum
    | h::t -> sum t (h + accum)


sum [1..10] 0


let rec sum items =
    let rec internalRecursiveSum items accum =
        match items with 
        | [] -> accum
        | h::t -> internalRecursiveSum t (h + accum)
    internalRecursiveSum items 0

sum [1..10]

let sum items =
    Seq.fold
        (fun state item -> state + item)
        0
        items

sum[1..10] 
// val it: int = 55

let sum items =
    Seq.fold
        (fun state item -> 
        let newState = state + item
        printfn "Current: %A, item: %A, new: %A" state item newState
        newState)
        0
        items

sum[1..5]

// using infix plus operator, forward through collection
let sum items = Array.fold (+) 0 items
sum [|1..10|]

// array to list, but walking from end to from
let toList array = Array.foldBack (fun h t -> h :: t) array []
toList [|1..10|]

