// Increment or decrement by one.
type CounterMessage =
    | Increment of int
    | Decrement of int

let createProcessor initialState =
    MailboxProcessor<CounterMessage>.Start(fun inbox ->
        let rec innerLoop state = async {
            printfn "Current state: %i" state
            let! message = inbox.Receive()

            match message with
            | Increment amount->
                printfn "Incremented %A" amount
                do! innerLoop (state + amount)
            | Decrement amount ->
                printfn "Decremented %A" amount
                do! innerLoop (state - amount)
        }
        innerLoop initialState)

let processor = createProcessor 10

processor.Post(Increment 1)
processor.Post(Increment 2)
processor.Post(Decrement 3)
processor.Post(Increment 4)
processor.Post(Increment 0)



