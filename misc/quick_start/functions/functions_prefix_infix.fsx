let distance x y =
    let delta = x - y
    if delta < 0 then -delta else delta

distance 1 2
(+) 1 2

let add1 x = (+) x 1
add1 5


1 + 2 + 3 // 6
(1 + 2) + 3 // 6, + is associative
1 + (2 + 3) // 6

36 / (6 / 2) // 12 // "/" is not associative
(36 / 6) / 2 // 3

((+) ((+) 1 2) 3) // not as easy to read as 1 + 2 + 3.  You like LISP?

let distance x y = abs (x - y) // or
let distance x y = x - y |> abs

let (|><|) x y = x - y |> abs

5 |><| 2
// val it : int = 3


5 |><| 2 |><| 10 // left associative
// val it : int = 7
