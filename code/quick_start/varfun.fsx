let myInteger = 1

let myFloat = 3.
let myString = "Hello from F#"
let myExplicitFloat:float = 2

myInteger = 2

let myList = [1; 2; 3;]
myList

let myArray = [|1.; 5.; 10|]
myArray

myArray[2]
myList[1]

-5 :: myList
myList @ [-5; -10]

let square (x: float) = x * x
square 5
square 5.

let add x y =
    let z = x + y
    z
add 1 2

let printSum x y =
    printfn "%A" (x + y)
    ()

printSum 2 3

