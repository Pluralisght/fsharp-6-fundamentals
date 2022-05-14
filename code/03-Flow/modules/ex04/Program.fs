let account = Bank.Domain.createAccount 0 0.0
let customer = Bank.Domain.createCustomer "John" "Doe" account

printfn "%A" customer
