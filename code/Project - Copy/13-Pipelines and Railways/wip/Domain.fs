module Transactions.Domain

type TransactionType = Deposit | Withdraw
type Transaction = {
    Id: int
    Type: TransactionType
    Amount: decimal
}

let newTransaction transactionType id amount = { Id = id; Type = transactionType; Amount = amount }
let newDeposit id amount = newTransaction Deposit id amount
let newWithdraw id amount = newTransaction Withdraw id amount 

type Account = {
    Id: int
    Balance: decimal
    Transactions: Transaction list
}

let newAccount id balance transactions =
    { Id = id; Balance = balance; Transactions = transactions}

let newAccountWithId id = newAccount id 0m []
     
