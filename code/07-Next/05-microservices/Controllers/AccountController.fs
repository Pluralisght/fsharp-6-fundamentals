namespace api.Controllers

open System
open System.Collections.Generic
open System.Linq
open System.Threading.Tasks
open Microsoft.AspNetCore.Mvc
open Microsoft.Extensions.Logging
open Finance.Domain
open Finance.Account.Repository
open System.Text.Json

[<ApiController>]
[<Route("[controller]")>]
type AccountController (logger : ILogger<AccountController>, accountRepository : IRepository<Account>) =
    inherit ControllerBase()

    [<HttpGet("Balance")>]
    member _.GetBalance(accountId: int) =
        let account = accountRepository.Get accountId
        let json = JsonSerializer.Serialize(account)
        account

    [<HttpPost>]
    member _.Withdraw(accountId:int,  amount:decimal) =
        //accountId
         //|> Repository.Account.get |> deposit amount |> Repository.Account.put
        ""

    [<HttpPost>]
    member _.Deposit(accountId:int,  amount:decimal) =
        ""
    