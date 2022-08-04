    member this.Exec move turn penUp penDown setColor (commandStr:string) =
    ...

    // return Success of unit, or Failure
    match tokens with
    | [ "Move"; distanceStr ] -> result {
        let! distance = validateDistance distanceStr
        let newState = move distance state   // use `move` function that was passed in
        updateState newState
        }
    | [ "Turn"; angleStr ] -> result {
        let! angle = validateAngle angleStr
        let newState = turn angle state   // use `turn` function that was passed in
        updateState newState
        }


let log = printfn "%s"
let move = Turtle.move log
let turn = Turtle.turn log
let penUp = Turtle.penUp log
let penDown = Turtle.penDown log
let setColor = Turtle.setColor log

let normalSize() =
    let api = TurtleApi()
    // partially apply the functions
    api.Exec move turn penUp penDown setColor
    // the return value is a function:
    //     string -> Result<unit,ErrorMessage>

let halfSize() =
    let moveHalf dist = move (dist/2.0)
    let api = TurtleApi()
    // partially apply the functions
    api.Exec moveHalf turn penUp penDown setColor
    // the return value is a function:
    //     string -> Result<unit,ErrorMessage>

    // the API type is just a function
type ApiFunction = string -> Result<unit,ErrorMessage>

let drawTriangle(api:ApiFunction) =
    result {
        do! api "Move 100"
        do! api "Turn 120"
        do! api "Move 100"
        do! api "Turn 120"
        do! api "Move 100"
        do! api "Turn 120"
        }

let apiFn = normalSize()  // string -> Result<unit,ErrorMessage>
drawTriangle(apiFn)

let apiFn = halfSize()
drawTriangle(apiFn)

