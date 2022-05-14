open System


[<EntryPoint>]
let main argv = 
    printfn "Hello from the bank"

    let mutable running = true
    while running do
        running <- Bank.Operations.Interaction.doMain()
        printfn "%A" running
    0
