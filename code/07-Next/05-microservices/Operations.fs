module Finance.Operations

open System
open Result

open Finance.Domain

    module Accounts =
        let private deposit amount account=
            { account with Balance = account.Balance + amount }

        let private withdraw amount account =
            if amount <= account.Balance then
                Ok { account with Balance = account.Balance - amount }
            else
                Error("Insuffienct Funds")
        
        module Commands =
            type AccountCommands = | Withdraw of int * decimal | Deposit of int * decimal | Invalid

        module Processors =
            open Commands
            open Finance.Account.Repository

            let (>>=) result func = Result.bind func result

            let execute command =
                match command with
                    | Withdraw (accountId, amount) ->
                        accountId |> Memory.get |> deposit amount |> Memory.put |> ignore
                        true
                    | Deposit (accountId, amount) ->
                        accountId |> Memory.get |> withdraw amount |> Result.bind Memory.put |> ignore
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
                //let account = Repository.Account.get 0
                //printfn "Current balance: %A" account.Balance

                //execute (buildAccountCommand 0) |> ignore

                loop ()
            loop ()
                    

