open System
open System.IO

open Transactions.Repository.Account
open Transactions.Domain
open Transactions.BusinessRules.Accounts

[<EntryPoint>]
let main argv =
    Console.WriteLine("Hello from the transaction processor!")

    Directory.GetFiles(".", "account_*.json") |> Array.iter File.Delete 

    newAccountWithId 0
    |> deposit 100m
    |> withdraw 25m
    |> put
    |> ignore

    printfn "%A" (get 0)
    printfn "%A" (get 1)

    Console.WriteLine("Bye!")
    0