open Bank.Runners
open System

let printPrompt () = 
    Console.Write "guess:>"

let getLine = fun _ -> 
    printPrompt ()
    System.Console.ReadLine ()

let writeResponse (s:string) =
    printfn "You typed: %s" s

let progLoop =
    let lines = Seq.initInfinite getLine
    Seq.iter writeResponse lines

printfn "HI"
ConsoleRunner
(*Console.WriteLine("Enter your input")
let x = Console.ReadLine()
Console.WriteLine(x)
*)
printfn "Bye!"
