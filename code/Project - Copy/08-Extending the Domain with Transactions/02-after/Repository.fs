module Transactions.Repository

open Transactions.Domain
open System.Collections.Generic

module Account =
    let private _accounts = new Dictionary<int, Account>()

    let get id =
        if _accounts.ContainsKey(id) then Ok _accounts[id]
        else Error $"Account not found: {id}"

    let put account =
        _accounts[account.Id] <- account
        Ok account