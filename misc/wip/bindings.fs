let x = 1
let result = x + 1
let square x = x * x // x here is a different scope than the earlier x
let x = 2 // compile error – x is already defined in the same scope
x = 2 // evaluates to true
let mutable y = 100
y <- 200 // ok as y is mutable

