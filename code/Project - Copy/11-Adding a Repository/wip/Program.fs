open System 

[<EntryPoint>]
let main argv =
    Console.WriteLine("Hello from the transaction processor!")
    Transactions.Interaction.mainLoop()
    Console.WriteLine("Bye!")
    0