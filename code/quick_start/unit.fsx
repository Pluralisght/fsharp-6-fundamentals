printfn "HI!" // val it : unit = ()

let myFunWithUnit a b =
    printfn "%A" (a+b)
    () // not strictly needed as printfn returns () too

myFunWithUnit 1 2

