namespace Bank

open System
open System.ComponentModel.DataAnnotations

module Domain =
    type BankOperation = Deposit | Withdraw

    type Customer = { Name : string }

    type Account = 
        { 
            AccountId : Guid; 
            Owner : Customer; 
            [<Required>] Balance : decimal 
        }

    type Transaction = 
        { 
            [<Required>] Timestamp : DateTime; 
                         Operation : BankOperation; 
            [<Required>] Amount : decimal 
        }