let x = "b"

let check x = 
    if x = "a" then 
        "x is a"
    elif x = "b" then
        "x is b"
    else
        $"x is neiter a nor b, it is {x}"

check "a"
check "b"
check "c"

let checkWithMatch x =
    match x with
        | "a" -> "value is a"
        | "b" -> "value is b"
        | _ -> "values is not a or b"

checkWithMatch "a"
checkWithMatch "b"
checkWithMatch "c"

let a = 1
let x = if a=1 then "a is one"

[
    for r in 1..8 do
        for c in 1..8 do
            if r <> c then yield (r,c)
] 