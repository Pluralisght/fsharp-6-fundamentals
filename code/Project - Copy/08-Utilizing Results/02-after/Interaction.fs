module Transactions.Interaction

open Transactions.Domain
open Transactions.BusinessRules.Accounts
open System

let private promptuser () =
    Console.Write("(d)eposit, (w)ithdraw or e(x)it: ")
    Console.ReadLine()

let private getAmount () =
    Console.Write("Enter the amount of the transaction: ")
    let input = Console.ReadLine() 
    let (success, value) = input |> Decimal.TryParse
    match success with
    | true -> Ok value
    | false -> Error $"Parse of amount failed: {input}"

let private take action account =
    let amount = getAmount()
    match amount with
    | Ok value ->
        match action with 
        | "d" -> Ok (deposit account value)
        | "w" -> Ok (withdraw account value)
        | _ -> Error $"Invalid action: {action}"
    | Error edata -> Error edata

let mainLoop () =
    Console.WriteLine("Hello from the transaction processor!")

    let rec loop account =
        printfn "Balance: %A" account.Balance

        let action = promptuser()
        printfn "You told me to do this: %A" action

        match action with
        | "d" | "w" -> 
            let result = take action account
            match result with
            | Ok account -> loop account
            | Error e ->
                printfn "%A" e
                loop account
        | "x" -> ()
        | _ ->
            printfn "Unknown command: %A" action
            loop account

    loop { Id=0; Balance=0m }

    Console.WriteLine("Bye!")
    0