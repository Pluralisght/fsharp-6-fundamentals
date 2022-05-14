open System


[<EntryPoint>]
let main argv = 
    printfn "Hello from the bank"

    (*
    let rec mainLoop () =
        match Bank.Operations.Interaction.doMain() with
        | false -> ()
        | true -> mainLoop ()
    mainLoop()
    *)
    Bank.Operations.Interaction.doMain()

    0
