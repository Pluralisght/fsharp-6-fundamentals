let f x  = x * x
let g x = x + 1
let composed x = g(f(x))
g (f 3)

f >> g

let composed_right = f >> g // notice, no parameter
composed_right 3

let composed_left = g << f
composed_left 3

(f >> g) 3
(>>) f g 3


let add x y = x + y
let add1 = add 1
add1 10

let times2 x = x * 2
let add1thenTimes2 = add1 >> times2
let times2thenAdd1 = add1 << times2
add1thenTimes2 5

times2thenAdd1 5
