module Bank.Repository

open Bank.Domain

module Account =
    let mutable private account = { Balance = 0.0m }

    let get () = account
    let put accountToPut = account <- accountToPut
