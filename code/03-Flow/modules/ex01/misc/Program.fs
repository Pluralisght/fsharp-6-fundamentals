#load "Account.fsx"
#load "Customer.fsx"

let account: Bank.Accounts = 
	{ 
		AccountType = 0; 
		Balance = 0.0 
	}

let customer: Bank.Customers = 
	{ 
		FirstName = "John"; 
		LastName = "Doe"; 
		Account = account 
	}

printfn "%A" customer
