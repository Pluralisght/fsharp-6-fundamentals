module Transactions.DataSeeder

open Transactions.Domain
open Transactions.Repository

let doSeed () =
    Account.put { 
                Id = 0; 
                Balance = 100m;
                Transactions = [ {Id = 0; Type = Deposit; Amount = 100m} ]
            }
    |> ignore