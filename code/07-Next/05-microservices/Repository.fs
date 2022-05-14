module Finance.Account.Repository
open Finance.Domain
open System.Text.Json
open Result

type IRepository<'T> = {
    Get: int -> 'T
    Put: 'T -> Result<'T, string>
}

module Memory =
    let mutable private accounts = [|{ Id = 0; Balance = 0.0m; Transactions = [] }|]

    let get accountId = 
        accounts[int accountId]
    let put (account : Account) = 
        let json = JsonSerializer.Serialize(account)
        accounts[account.Id] <- account
        Ok account

module File =
    let get accountId = { Id=0; Balance =0.0m; Transactions = []}
    let put (account : Account) = Error "Not Implemented"

