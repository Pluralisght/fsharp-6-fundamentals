module Project.Domain

type TransactionTypes = Deposit | Withdrawal 
type Transaction = { Year:int; Amount:float; Type: TransactionTypes }

type Account =
    {
        Id: int;
    }

type State = 
    {
        Account: Account;
        Transactions: Transaction list;
    }

    