let myInteger = 1
let myFloat = 3.
let myString = "Hello from F#"
let myExplicitFloat:float = 2

myInteger = 2

let myArray = [|1.; 5.; 10|]
myArray[0]
myArray[1] = 5.
myArray[1] <- 20.
myArray

let myList = [1; 2; 3;]
myList[2]
myList[2] = 3 
myList[1] <- 3

[1..5]
[|0..5|]
[|10..-2..0|]

let myList = [1; 2; 3;]
-5 :: myList
let head :: tail = myList
myList @ [-5; -10]

let square x  = x * x
square 5

let add x y =
    let z = x + y
    z
add 1 2

let printSum x y =
    printfn "%A" (x + y)
    ()

printSum 2 3

20 |> (10 |> add)
10 |> add 1



