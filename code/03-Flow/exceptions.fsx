exception Error1 of string
exception Error2 of string * int
let function1 x y =
    try
        if x = y then raise (Error1("x"))
        else raise (Error2("x", 10))
    with
        | Error1(str) -> printfn "Error1 %s" str
        | Error2(str, i) -> printfn "Error2 %s %d" str i
        | _ -> ()
function1 10 10
function1 9 2

let function1 x y =
    try
        try
            if x = y then raise (Error1("x"))
            else raise (Error2("x", 10))
        with
            | Error1(str) -> printfn "Error1 %s" str
            | Error2(str, i) -> printfn "Error2 %s %d" str i
    finally
        printfn "all done"
