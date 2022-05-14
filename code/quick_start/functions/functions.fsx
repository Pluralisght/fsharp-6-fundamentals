let square x = x * x
square 3
square 3. // error
square (int 3.)


let square (x: float) = x * x // explicitly make parameter a float

let square x: float = // return type is float
    x * x 

let square x =
    float (x*x)