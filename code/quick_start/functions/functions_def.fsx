let f x = x * x

let g x = x + 1

let gf x =  (g << f) x

f 1
f 2
g 1
g 2

gf 2 




let square x: float = 
    x * x 

let square (x:int) :float = x * x

let add x y = x + y
add 1 2

let add (x:int) (y:int) : float = 
    x + y