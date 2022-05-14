module Bank.Operations

open System

open Bank.Domain

    module Accounts =
        let private deposit amount account=
            { account with Balance = account.Balance + amount }

        let private withdraw amount account =
            { account with Balance = account.Balance - amount }
        
        module Commands =
            type AccountCommands = | Withdraw of int * decimal | Deposit of int * decimal | Invalid

        module Processors =
            open Commands

            let execute command =
                match command with
                    | Withdraw (accountId, amount) ->
                        int accountId |> Repository.Account.get |> deposit amount |> Repository.Account.put
                        true
                    | Deposit (accountId, amount) ->
                        int accountId |> Repository.Account.get |> withdraw amount |> Repository.Account.put
                        true
                    | Invalid -> false

    module Interaction =
        open Accounts.Commands
        open Accounts.Processors

        let getTransactionAmountFromUser () =
            Console.Write "Amount: "
            Console.ReadLine() |> Decimal.Parse
            
        let buildAccountCommand accountId = 
            let action =
                Console.Write "(d)eposit, (w)itdraw or e(x)it: "
                Console.ReadLine()

            match action with 
            | "w" -> Withdraw (accountId, getTransactionAmountFromUser())
            | "d" -> Deposit (accountId, getTransactionAmountFromUser())
            | _ -> Invalid

        let doMain () =
            let rec loop () =
                let account = Repository.Account.get 0
                printfn "Current balance: %A" account.Balance

                execute (buildAccountCommand 0) |> ignore

                loop ()
            loop ()
                    

