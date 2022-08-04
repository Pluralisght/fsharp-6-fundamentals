open System

let myInt = 1
let myFloat = 2.
let myString = "hello!"
let myArray = [|1;2;3;4|]
let myList = [1;2;3;4]

let square x = x * x
// square 10

let add x y = x + y
let added = add 2 3
printfn "%A" added

let evens items = 
    let isEven x = x%2 = 0
    List.filter isEven items
(*evens [1..10]
[1..100]
[1..10..100]

[1..5] |> List.sum
[1..5] |> List.map square |> List.sum
*)
let x = 10
let result = 
    if x < 10 then  
        "less than 10"
    else    
        "greater or equal to 10"
printfn "%A" result

