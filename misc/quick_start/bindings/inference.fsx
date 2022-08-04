let a = 1
let b:float = 1
let c = 1.
let d = float 1
let add x y = x + y

let add (x : float) y = x + y

// Type annotations on an expression.
let add x y =
    (x : float) + y

let add x y : float =
   x + y

let add x y  =
   float (x + y)

let replace(str: string) =
    str.Replace("A", "a")

type Person =
    {
        Name: string
        Address: string
    }

type Employee =
    {
        Name: string
        Id: int
    }

let p = { Name = "John"; Address = "Some street" }
let e = { Name = "Sue"; Id=1 }