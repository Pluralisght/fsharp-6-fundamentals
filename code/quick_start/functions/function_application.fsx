let square x = x * x

square 3 + 1 = 10

let distance x y =
    let delta = x - y
    if delta < 0 then -delta else delta

let distance x y =
     if x>y then x-y else y-x
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

let add_y y = y
let add_x x = x
let add_curreied = (+) add_x = 