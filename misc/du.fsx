type DaysOfWeek = Sunday | Monday | Tuesday | Wednesday | Friday | Saturday

let day = Sunday;

day = Sunday // val it: bool = true
day = Monday // val it: bool = false

type Shape = 
    | Rectangle
    | Circle
    | Triangle
    | Pentagon

let rect = Rectangle
let circle = Circle

rect


rect = circle // val it: bool = false





type Point = float * float
let tuple  = (1., 2.) // just a tuple
let point = Point(10., 3.)
point // Point = (10.0, 30.0) // like a tuple
fst point




type Shape =

    | Rectangle of width : float * length : float
    | Circle of radius : float
    | Prism of width : float * float * height : float

let rect = Rectangle(length = 1.3, width = 10.0)
let circ = Circle (1.0)
let prism = Prism(5., 2.0, height = 3.0)

