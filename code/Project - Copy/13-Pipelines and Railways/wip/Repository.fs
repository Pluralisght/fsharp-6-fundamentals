module Transactions.Repository

open Transactions.Domain
open System.IO
open System.Text.Json.Serialization
open System.Text.Json

module Account =
    let (>>=) result func = Result.bind func result

    let private jsonOptions =
        let options = JsonSerializerOptions()
        options.Converters.Add(JsonFSharpConverter())
        options

    let private serializeAccount account = 
        JsonSerializer.Serialize( account, jsonOptions )

    let private deserializeAccount (json:string) =
        JsonSerializer.Deserialize<Account> (json, jsonOptions)

    let private getAccountFileName accountId =
        $"account_{accountId}.json"

    let nextAccountId () =     
        let extractAccountId (filename:string) =
            let part1 = filename.Split('_')[1]
            let part2 = part1.Split('.')[0]
            int (part2)
        match Directory.GetFiles(".", "account_*.json") with
        | [||] -> 0
        | _ as files -> files |> Array.map extractAccountId |> Array.max |> (+) 1

    let exists accountId =
        File.Exists(getAccountFileName accountId)

    let private getAccountData accountId =
        match exists accountId with
        | true -> Ok (File.ReadAllText (getAccountFileName accountId))
        | false -> Error $"Account file not found: {accountId}"

    let private buildAccount json =
        Ok (deserializeAccount json)

    let private save account =
        File.WriteAllText(getAccountFileName account.Id, serializeAccount account)
        account

    let get accountId =
        accountId |> getAccountData >>= buildAccount

    let put account =
        try
            Ok (account |> save)
        with e -> Error e.Message
