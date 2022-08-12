module Transactions.BusinessRules

open Transactions.Domain

module Accounts =
    let private nextTransactionId account = 
        match account.Transactions with
        | [] -> 0
        | transactions -> transactions.Length 

    let private getAmountForBalance transaction = 
        match transaction.Type with
        | Deposit -> transaction.Amount
        | Withdraw -> -transaction.Amount

    let private getTransactionAmounts transactions = 
        transactions |> List.map (fun transaction -> getAmountForBalance transaction)

    let private calculateBalance transactions =
        transactions |> getTransactionAmounts |> List.sum

    let deposit amount account = 
        let transaction = newDeposit (nextTransactionId account) amount
        let transactions = 
            List.append account.Transactions [transaction]
        { 
            account with 
                Balance = calculateBalance transactions
                Transactions = transactions 
        }

    let withdraw amount account = 
        let transaction = newWithdraw (nextTransactionId account) amount
        let transactions = 
            List.append account.Transactions [transaction]
        { 
            account with 
                Balance = calculateBalance transactions
                Transactions = transactions 
        }
