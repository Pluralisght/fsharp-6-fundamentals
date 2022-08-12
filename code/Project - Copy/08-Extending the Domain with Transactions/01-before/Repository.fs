module Transactions.Repository

open Transactions.Domain

module Account =
    let private _accounts = dict [
        (0, { Id = 0; Balance =100m })
    ]

    let get id =
        if _accounts.ContainsKey(id) then Ok _accounts[id]
        else Error $"Account not found: {id}"

    let put account =
        _accounts[account.Id] <- account
        Ok account