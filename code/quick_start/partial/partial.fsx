let add x y = x + y
// val add: x:int -> y:int -> int

let add5 = add 5 

add(1)(2)

add(1)

add 1 2


add 1


(fun x -> x * x)(5)
// val it: int = 25

(fun (x:float) -> x * x)(5)
// val it: float = 25

let square = (fun x -> x * x)
square 5

let data = [1;2;3;4]
List.map (fun x -> x * x) data
// val it: int list = [1;4;9;16] 


[1;2;3] |> 
    List.map (fun x -> x*2)

List.map (fun x -> x*2) [1;2;3]

[1..4]
    |> List.filter (fun i -> i % 2 = 0)
    |> List.map ((*) 2) // or List.map (fun i -> i * 2)
    |> List.sum


(List.map (fun x -> x*2)) [1;2;3]

