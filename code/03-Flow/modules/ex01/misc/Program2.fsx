namespace Bank.Accounts 
type Account = 
    { 
        AccountType: int; 
        Balance: float
    }

namespace Bank.Customers
open Bank.Accounts

type Customer = 
    { 
        FirstName: string; 
        LastName: string; 
        Account: Account; 
    }

module Program =
    let account=
        { 
            AccountType = 0; 
            Balance = 0.0 
        }

    let customer =
        { 
            FirstName = "John"; 
            LastName = "Doe"; 
            Account = account 
        }

    printfn "%A" customer
