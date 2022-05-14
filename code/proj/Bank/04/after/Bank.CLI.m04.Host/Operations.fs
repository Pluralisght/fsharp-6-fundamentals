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
                updated
            | _ -> account

        let doMain () =
            let rec loop account =
                printfn "Current balance: %A" account.Balance

                let action =
                    Console.Write "(d)eposit, (w)itdraw or e(x)it: "
                    Console.ReadLine()

                match action with
                | "x" -> ()
                | "d" | "w" -> 
                    let updatedAccount = take action account
                    loop updatedAccount
                | _ -> loop account

            let account = Bank.Repository.Account.get()
            loop account
                    

