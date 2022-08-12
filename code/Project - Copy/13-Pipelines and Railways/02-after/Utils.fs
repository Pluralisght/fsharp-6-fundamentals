module Transactions.Utils

module Railway =
    let (>>=) result func = Result.bind func result
    let (>>>) result func = Result.map func result

module Json =
    module Serialization =
        open System.Text.Json
        open System.Text.Json.Serialization

        let private jsonOptions () =
            let options = JsonSerializerOptions()
            options.Converters.Add(JsonFSharpConverter())
            options

        open Transactions.Domain

        module Accounts =
            let serialize account = 
                JsonSerializer.Serialize( account, jsonOptions() )

            let deserialize (json:string) =
                JsonSerializer.Deserialize<Account> (json, jsonOptions())

