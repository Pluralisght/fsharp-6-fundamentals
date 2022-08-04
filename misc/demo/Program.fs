(*open This.Is.The.Account.Namespace
open This.Is.The.Customer.Namespace

let account = { AccountType = 0; Balance = 0.0 }
let customer= { FirstName = "John"; LastName = "Doe"; Account = account }
*)

open Bank.Api
let account = createAccount 0 0.0
let customer = createCustomer "John" "Doe" account
printfn "%A" customer
