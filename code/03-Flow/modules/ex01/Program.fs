open Bank.Domain

let account =
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
