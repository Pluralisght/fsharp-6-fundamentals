namespace Bank.Customers

open Bank.Accounts

type Customer = 
    { 
        FirstName: string; 
        LastName: string; 
        Account: Account; 
    }
