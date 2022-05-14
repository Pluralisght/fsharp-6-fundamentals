type Request = { 
    Id: int;
    Name: string; 
    Email: string 
    }

let validateName request = 
    match request.Name with
    | "" -> Error "Name is empty"
    | _ -> Ok request

let validateEmail request =
    match request.Name with
    | "" -> Error "Email is empty"
    | _ -> Ok request

let validateRequest request = 
    let validateResult = 
        (Ok request) 
        |> Result.bind validateName
        |> Result.bind validateEmail
    match validateResult with
    | Ok req -> 
        printfn "request was validated"
    | Error e -> 
        printfn $"request had an error: {e}"

let validRequest =    {
        Id=1;
        Name="John"; 
        Email="john@foo.bar"
    }  
let invalidRequest = { Id=1; Name=""; Email="" }

validateRequest validRequest // succeeds
validateRequest invalidRequest// fails

let validateRequest request = 
    (Ok request) 
    |> Result.bind validateName
    |> Result.bind validateEmail

let storeInDatabase request=
    try
        // store in sqlserver, mongo, ...
        Ok request
    with
        | _ -> Error "Database issue"

let (>>=) result func = Result.bind func result

let validateRequest request = (Ok request) >>= validateName >>= validateEmail

validateRequest validRequest // succeeds
validateRequest invalidRequest// fails

let returnStatus result =
    match result with
    | Ok data-> $"return 200 / Ok and data: {data}"
    | Error e->
        match e with
        | _ -> "return other code / message"

let requestProcessor request=
    (Ok request)
        >>= validateRequest
        >>= storeInDatabase
        |> returnStatus

requestProcessor validRequest
requestProcessor invalidRequest