let square x = 
    let result = x * x
    result

let square x = x * x

square 3
square 3 + 1
square (3 + 1)

// error
square 3.

let square (x: float) = x * x
square 3.
square 3

let square x: float = x * xZ
square 3
square 3.

let add x y = x + y 
add 1 2

let add (x:int) (y:int) : float =
    x + y

let getInput =
    System.Console.Write("enter x to exit")
    System.Console.ReadLine() = "x"

let main =
    while getInput do () // infinite loops

let getInput() =
    System.Console.Write("enter x to exit")
    System.Console.ReadLine() = "x"

let main() =
    while getInput() do () // infinite loops
