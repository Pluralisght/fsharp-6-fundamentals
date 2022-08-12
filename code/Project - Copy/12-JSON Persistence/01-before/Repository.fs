module Transactions.Repository

open Transactions.Domain

open System.IO

module Account =
    open Transactions.Utils.Json.Serialization.Accounts
    open Transactions.Utils.Railway

    let private getAccountFileName accountId =
        $"account_{accountId}.json"

    let private getAccountData accountId =
        try
            Ok (getAccountFileName accountId |> File.ReadAllText)
        with e -> Error e.Message

    let private buildAccount json =
        Ok (json |> deserialize)

    let private save account =
        try
            (getAccountFileName account.Id, serialize account)
            |> File.WriteAllText
            Ok account
        with e -> Error e.Message

    let get accountId =
        accountId |> getAccountData >>= buildAccount

    let put account =
        account |> save
