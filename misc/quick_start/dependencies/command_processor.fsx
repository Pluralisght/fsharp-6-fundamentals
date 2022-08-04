/// An alias for a float
type Distance = float

/// Use a unit of measure to make it clear that the angle is in degrees, not radians
type [<Measure>] Degrees

/// An alias for a float of Degrees
type Angle  = float<Degrees>

/// Enumeration of available pen states
type PenState = Up | Down

/// Enumeration of available pen colors
type PenColor = Black | Red | Blue

/// A structure to store the (x,y) coordinates
type Position = {x:float; y:float}

exception TurtleApiException of string

type Turtle(log) =

    let mutable currentPosition = initialPosition
    let mutable currentAngle = 0.0<Degrees>
    let mutable currentColor = initialColor
    let mutable currentPenState = initialPenState

    member this.Move(distance) =
        log (sprintf "Move %0.1f" distance)
        // calculate new position
        let newPosition = calcNewPosition distance currentAngle currentPosition
        // draw line if needed
        if currentPenState = Down then
            dummyDrawLine log currentPosition newPosition currentColor
        // update the state
        currentPosition <- newPosition

    member this.Turn(angle) =
        log (sprintf "Turn %0.1f" angle)
        // calculate new angle
        let newAngle = (currentAngle + angle) % 360.0<Degrees>
        // update the state
        currentAngle <- newAngle

    member this.PenUp() =
        log "Pen up"
        currentPenState <- Up

    member this.PenDown() =
        log "Pen down"
        currentPenState <- Down

    member this.SetColor(color) =
        log (sprintf "SetColor %A" color)
        currentColor <- color

type TurtleApi(turtle: ITurtle) =

    // other code
    member this.Exec turtleFn (commandStr:string) =

        let tokens = commandStr.Split(' ') |> List.ofArray |> List.map trimString
        
        match tokens with
        | [ "Move"; distanceStr ] -> result {
            let! distance = validateDistance distanceStr
            let command =  Move distance      // create a Command object
            let newState = turtleFn command state
            updateState newState
            }
        | [ "Turn"; angleStr ] -> result {
            let! angle = validateAngle angleStr
            let command =  Turn angle      // create a Command object
            let newState = turtleFn command state
            updateState newState
            }
        | _ ->
            let msg = sprintf "Instruction '%s' is not recognized" commandStr
            raise (TurtleApiException msg)
    

let log = printfn "%s"
let move = Turtle.move log
let turn = Turtle.turn log
let penUp = Turtle.penUp log
let penDown = Turtle.penDown log
let setColor = Turtle.setColor log

let normalSize() =
    let turtleFn = function
        | Move dist -> move dist
        | Turn angle -> turn angle
        | PenUp -> penUp
        | PenDown -> penDown
        | SetColor color -> setColor color

    // partially apply the function to the API
    let api = TurtleApi()
    api.Exec turtleFn
    // the return value is a function:
    //     string -> Result<unit,ErrorMessage>

let halfSize() =
    let turtleFn = function
        | Move dist -> move (dist/2.0)
        | Turn angle -> turn angle
        | PenUp -> penUp
        | PenDown -> penDown
        | SetColor color -> setColor color

    // partially apply the function to the API
    let api = TurtleApi()
    api.Exec turtleFn
    // the return value is a function:
    //   
    
let api = normalSize()
drawTriangle(api)

let api = halfSize()
drawTriangle(api)