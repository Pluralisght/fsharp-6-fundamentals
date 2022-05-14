[<AutoOpen>] 
module Bank
[<AutoOpen>] 
module Domain =
    type Account = { 
            AccountType: int; 
            Balance: float  
        }
    type Customer = { 
            FirstName: string; 
            LastName: string; 
            Account: Account; 
        }
        
    // indentation here is important to
    let createAccount accountType balance = 
        { AccountType = accountType; 
        Balance = balance; }
    let createCustomer firstName lastName account=
        { FirstName = firstName; 
        LastName = lastName;   
        Account = account } 
