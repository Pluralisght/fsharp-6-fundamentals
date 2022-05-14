// For more information see https://aka.ms/fsharp-console-apps
(*
printfn "Hello from F#"

let square x =
    x * x
let result = square 5
square 5 // error
square 5 |> ignore



let doSomething x =
    square x
    ()
 

let <identifier> = <expression>

let AwesomeFSharpFunction aBool =
    if aBool then
        42
    else   
        0

[EntryPoint]
let main =
    printfn "Hello from F#"

let foo = let bar = 20


System.Environment.GetCommandLineArgs()

let square x = x * x

square 5

let i = 1

let x10 x =
    printfn "Within x10: %A %A" i x
    let i = x * 10
    i

printfn "%A %A" i (x10 5)


let BrilliantFSharpDifference aBool =
    if aBool then 42
    0

let square x = x * x // single line function declaration
let add x y =
    x + y
add 1 2 |> ignore// ok
add 1. 2. |> ignore // compile error

let addFloat (x : float) (y : float) =
    x + y
addFloat 1. 2.  |> ignore // ok
addFloat 1 2  |> ignore // ok

let addGeneric (x : 'a) (y: 'a) =
    x + y

addGeneric 1 2  |> ignore // ok
addGeneric 1. 2.  |> ignore // ok


let showMessage message =
    printfn "%A" message

let aList = [1; 2; 3]
let anArray = [|1; 2; 3|]
let aSeq = seq { 1; 2; 3}
let printCollection collection =
    for item in collection do printf "%A " item
    printfn ""
printCollection aList
printCollection anArray
printCollection aSeq

let func1 x =
    func2 x * 2

let func2 x =
    x + 1

let BrilliantFSharpDifferenceShorter aBool =
    if aBool then 42 else 0
*)

let aCondition = false
let result = match aCondition
    | true -> 42
    | [] -> 0
printfn "%A" result
