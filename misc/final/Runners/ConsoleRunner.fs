namespace Bank
open System

module Runners =
    let showMenu =
        printf "Enter selection: ";


    let selectAccount =
        printfn "Select account"
        ()
(*
    let processInput =
        let input = Console.ReadLine()
        printfn "You entered: %A" input
        let result = match input with
            | "x" -> 
                printfn "entered x"
                true
            | "1" -> 
                selectAccount
                false
            | _ ->    
                printfn "Unrecognized input"
                false
        printfn "Exit processInput"
        result
*)
    let ConsoleRunner =
        let mutable isDone = false

        while not isDone do
            showMenu
            // processInput |> ignore
            printfn "looping back"


        printfn "All done"


