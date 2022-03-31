let x = 1 // bound to an integer
let y = 1. // bound to a float
let z : int = 10 // forced to be an float

let result = x + 1 // bound to an expression evaluation
let square x = x * x // binding is a function
// x here is a different scope than the earlier x
let x = 2 // compile error – x is already defined in the same scope
x = 2 // evaluates to true
let mutable y = 100
y <- 200 // ok as y is mutable, but frowned up :(


let BrilliantFSharpDifference aBool =
    if aBool then
        42
    else  
        0
// implicit startup
printfn "Hello from F#"
for arg in System.Environment.GetCommandLineArgs() do
    printfn "%A" arg

[<EntryPoint>]
let main argv = 
    printfn "Hello from F - explicit start"

    printfn "%A" argv

    for arg in argv do
        printfn "%A" arg

    0


