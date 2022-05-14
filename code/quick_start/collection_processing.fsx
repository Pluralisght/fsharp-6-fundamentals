type item = { Year:int; Amount:float }
let data = [ 
    {Year=2021; Amount=100};
    {Year=2022; Amount=50};
    {Year=2022; Amount= -25}
    ]

List.iter (fun item -> printfn "%A" item) data
let amounts = List.map (fun item -> item.Amount) data

let balance = List.sum amounts

let year2022transactions = List.filter (fun item -> item.Year = 2022) data
let year2022net = year2022transactions |> List.map (fun item -> item.Amount) |> List.sum

let amountFromTransaction transaction = transaction.Amount
let amountsFromTransactions transactions = transactions |> List.map amountFromTransaction
let yearFromTransaction transaction = transaction.Year

let transactionsByYear = data |> List.groupBy yearFromTransaction
let amountsTotal amounts : float = List.sum amounts
let groupTransactionsByYear transactions = transactions |> List.groupBy yearFromTransaction 
let totalOfTransactionsForYear (year, transactions) = (year, transactions |> amountsFromTransactions |> List.sum)
let totalOfEachYears transactions = transactions |> groupTransactionsByYear |> totalOfTransactionsByYear
//let netPerYear (year, transactions) = (year, transactions) |> totalOfTransactionsForYear 

netPerYear data

transactionsByYear 
    |> List.map (fun (year, transactions) -> (year, transactions |> List.map (fun item -> item.Amount) |> List.sum))


open System
type TransactionType = Deposit | Withdrawal | Transfer
    
type Transaction =
    {
        When: System.DateTime
        Amount: float
        Type: TransactionType
    }

let transactions = [
    { When=DateTime(2022, 1, 1); Amount=100.0; Type=Deposit };
    { When=DateTime(2022, 2, 1); Amount=50.0;  Type=Withdrawal };
    { When=DateTime(2022, 4, 1); Amount=150.0; Type=Deposit };
]

List.iter (fun transaction -> printfn "%A" transaction) transactions
let transactionInYearAndQuarter transaction year quarter =
    printfn "%A %A" year transaction.When.Year
    transaction.When.Year = year //&& transaction.When.Month % 4 = quarter

transactionInYearAndQuarter transactions[0] 2022 0


List.filter 
    (fun transaction -> transactionInYearAndQuarter transaction 2002 0) 
    transactions

transactions
