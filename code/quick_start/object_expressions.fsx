type TurtleFunctions = {
    move : Distance -> TurtleState -> TurtleState
    turn : Angle -> TurtleState -> TurtleState
    penUp : TurtleState -> TurtleState
    penDown : TurtleState -> TurtleState
    setColor : PenColor -> TurtleState -> TurtleState
    }

let normalSize() =
    let log = printfn "%s"
    // return a record of functions
    {
        move = Turtle.move log
        turn = Turtle.turn log
        penUp = Turtle.penUp log
        penDown = Turtle.penDown log
        setColor = Turtle.setColor log
    }

let halfSize() =
    let normalSize = normalSize()
    // return a reduced turtle
    { normalSize with
        move = fun dist -> normalSize.move (dist/2.0)
    }

