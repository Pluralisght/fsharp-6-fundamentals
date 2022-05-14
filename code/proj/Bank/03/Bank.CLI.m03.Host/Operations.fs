module Bank.Operations

open System

open Bank.Domain

    module Accounts =
        let deposit account amount=
            { account with Balance = account.Balance + amount }

        let withdraw account amount =
            { account with Balance = account.Balance - amount }

    module Interaction =
        open Bank.Repository.Account

        let depositOrWithdraw action account =
            let amount = 
                Console.Write "Amount: "
                Console.ReadLine() |> Decimal.Parse
            match action with
                | "w" -> Accounts.withdraw account amount
                | "d" -> Accounts.deposit account amount
                | _ -> account

        let take action account =
            match action with
            | "d" | "w" -> 
                let updated = depositOrWithdraw action account 
                put updated
                true
            | "x" -> false
            | _ -> true


        let doMain ()=
            let account = Bank.Repository.Account.get()
            printfn "Current balance: %A" account.Balance

            let action =
                Console.Write "(d)eposit, (w)itdraw or e(x)it: "
                Console.ReadLine()

            match action with
            | "d" | "w" -> 
                take action account |> ignore
                true
            | "x" -> false
            | _ -> true

