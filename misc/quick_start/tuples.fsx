let tuple1 = 1, "a"
let tuple2 = (1, "a")
let tuple3 = (1, "b")
let tuple4 = (1, "a", 2.0, true) // int * string * float * bool
tuple1 = tuple2 // true
tuple1 = tuple3 // false
tuple1 = tuple4 // error

let a,b = (1, 2)
