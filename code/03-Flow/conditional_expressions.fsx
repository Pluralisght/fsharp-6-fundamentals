let check x = 
    if x = "a" then 
        "x is a"
    elif x = "b" then
        "x is b"
    else
        $"x is not a nor b, it is {x}"
check "a" // val it: string = “x is a”
check "b" // val it: string = “x is 6”
check "c" // val it: string = “x is neither a nor b, it is c”

let a = 2
let x = if a=1 then "a is one" // invalid F#

let checkWithMatch x =
    match x with
    | "a" -> "value is a"
    | "b" -> "value is b"
    | _ -> "values is not a or b"
checkWithMatch "a"
checkWithMatch "b"
checkWithMatch "c"

let a = 2
let x = if a=1 then "a is one“ 
