namespace Finance.Domain

type TransactionType = | Withdraw | Deposit

type Transaction = {
    Id: int
    Type: TransactionType
    Amount: decimal
}

type Account = {
    Id: int
    Balance: decimal
    Transactions: Transaction list
}


