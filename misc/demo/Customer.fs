namespace This.Is.The.Customer.Namespace
open This.Is.The.Account.Namespace
type Customer = 
    { 
        FirstName: string; 
        LastName: string; 
        Account: Account; 
    }
