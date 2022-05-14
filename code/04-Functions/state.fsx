let mutable state = 100.0
let modify action = 
    state <- state -
        match action with
        | "half" -> state / 2.0
        | "small" -> 1.0
        | "large" -> 10.0
        | _ -> 0.0
modify "half"
modify "large"
modify "small"
state

let modify state action = 
    match action with
    | "half" -> state / 2.0
    | "small" -> state - 1.0
    | "large" -> state - 10.0
    | _ -> state
let initialState = 100.0
let newState1 = modify initialState "half"
let newState2 = modify newState1 "large"
let endState = modify newState2 "small"
endState

let modify state action = 
    match action with
    | "half" -> state / 2.0
    | "small" -> state - 1.0
    | "large" -> state - 10.0
    | _ -> state
let mutable currentState = 100.0
while true do
    let action = System.Console.ReadLine()
    let newState = modify currentState action
    currentState <- newState


let main () =
    // tail recursive loop solely for repeating a task with a new state
    let rec loop state =
        let action = System.Console.ReadLine()
        let newState = modify currentState action
        loop newState // tail recurse with the new state
    
    loop 100.0 // start recursive loop with initial state

type Person = { ID:int; Name:string }
type PersonRepository = { FindById: int -> Person; Update: Person -> bool }
let updatePersonName personRepository personId newName=
    let user = personRepository.FindById personId
    let updatedUser = { user with Name = newName }
    personRepository.Update updatedUser

type Message = Set of float | Get of AsyncReplyChannel<float> | Half | Small | Large 
let item1 = MailboxProcessor<Message>.Start(
    fun inbox ->
        let rec loop state = async {
            printfn "State is: %A" state
            let! msg = inbox.Receive()
            match msg with
            | Set v -> do! loop v
            | Get replyChannel -> 
                replyChannel.Reply state
                do! loop state
            | Half -> do! loop (state / 2.0)
            | Small -> do! loop (state - 1.0)
            | Large -> do! loop (state - 10.0)
        }
        loop 0.0)

item1.Post(Set 100.0)
item1.Post(Half)
let v = item1.PostAndReply(Get)
v

