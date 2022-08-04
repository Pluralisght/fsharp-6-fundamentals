let a = 1
let afunc =
    printfn "%A" a  // prints 1
    let a = 2 // now can't access outer a
    a
    
printfn "%A" a  // prints 1
printfn "%A" afunc  // prints 2

let a = 10 // error
