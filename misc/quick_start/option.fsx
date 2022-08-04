type 'a option =
    | None
    | Some of 'a

let someThing = Some(1)
let noneThing = None

let isItSomething thing =
    match thing with
    | None -> "nope, it's nothing"
    | Some i -> $"Yes, it is something: {i}"

isItSomething someThing // val it: string = "Yes, it is something: 1"
isItSomething noneThing // val it: string = "nope, it's nothing"
