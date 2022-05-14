(+);;

1 + 3
(+) 1 3

let add1 = (+) 1

add1 5

1 + 2 + 3 
(1 + 2) + 3
1 + (2 + 3)
24 / (4 / 2)
(24 / 4) / 2 
((+) ((+) 1 2) 3) 

let distance x y = if x>y then x-y else y-x

let (|><|) x y = x - y |> abs

9 |><| 3
5 |><| 2 |><| 10 // left associative
