let square x = x * x

square 3 + 1 = 10

let distance x y =
    let delta = x - y
    if delta < 0 then -delta else delta

let distance x y = if x>y then x-y else y-x
distance 1 2

distance 2 1

type Line = class
   val X1 : float
   val Y1 : float
   val X2 : float
   val Y2 : float

   new (x1, y1, x2, y2) as this =
      { X1 = x1; Y1 = y1; X2 = x2; Y2 = y2;}
      then
         printfn " Creating Line: {(%g, %g), (%g, %g)}\nLength: %g"
            this.X1 this.Y1 this.X2 this.Y2 this.Length

   member x.Length =
      let sqr x = x * x
      sqrt(sqr(x.X1 - x.X2) + sqr(x.Y1 - x.Y2) )
end
let aLine = new Line(1.0, 1.0, 4.0, 5.0)
aLine.Length


let add x y = x + y
add 5 

let add_x_y x =
    fun y -> x + y
// val add_x_y: x: int -> y: int -> int

let add_5_y = add_x_y 5
// val add_5_y: (int -> int)

// add_5_y is really fun y -> 5 + y
add_5_y 3
// val it: int = 8

let add x y z = x + y + z

let add_x_y_z x =
   fun y -> 
      fun z -> 
         x + y + z

add_x_y_z 2 // is fun y -> fun z -> 2 + x + y
add_x_y_z 2 3 //  is fun z -> 2 + 3 + y
add_x_y_z 2 3 4

// val it: (int -> int -> int)







