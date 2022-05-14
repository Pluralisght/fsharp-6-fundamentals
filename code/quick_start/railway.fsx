type Request = { Name: string; Email: string }
let validateName request = 
    match request.Name with
    | null -> Error "No name specified"
    | "" -> Error "Name is empty"
    | _ -> Ok request
let validateEmail request = 
    match request.Name with
    | null -> Error "No name specified"
    | "" -> Error "Name is empty"
    | _ -> Ok request


type Request = {name:string; email:string}

let validateInput input =
    match input with
        | "" -> Failure "Name must not be blank"
        | else if input.email = "" then Failure "Email must not be blank"
   else Success input  // happy path


