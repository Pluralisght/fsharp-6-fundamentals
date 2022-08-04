open System

[<EntryPoint>]
let main argv = 
    printfn "Hello from the transaction processor"

    while true do
        Console.Write "(d)eposit, (w)ithdraw or e(x)it: "
        let input = Console.ReadLine()
    0
