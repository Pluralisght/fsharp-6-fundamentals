open System
open System.IO

open Transactions.Repository.Account
open Transactions.Domain
open Transactions.BusinessRules.Accounts
open Transactions.Utils.Railway

[<EntryPoint>]
let main argv =
    Console.WriteLine("Hello from the transaction processor!")

    Directory.GetFiles(".", "account_*.json") |> Array.iter File.Delete 

    // create new account with a few transactions
    newEmptyAccountWithId 0
    |> deposit 100m
    |> withdraw 25m
    |> put
    |> ignore

    // get an existing and non-existing account
    get 0 |> printfn "%A"
    get 1 |> printfn "%A"

    // get and update an existing account
    get 0 
    >>> deposit 40m
    >>= put
    |> ignore

    // check that on reload it is a new balance
    get 0 |> printfn "%A"

    // railway flows this error right through
    get 1
    >>> deposit 40m
    >>= put
    |> printfn "%A"

    Console.WriteLine("Bye!")
    0