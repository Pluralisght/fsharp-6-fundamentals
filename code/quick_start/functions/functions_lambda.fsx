let square x = x * x
let square = fun x -> x* x

let ipow3, ipow4 =
    let square x = x * x
    (fun x -> x * square x), (fun x -> square(square x))


List.map (fun x -> x * x) [1;2;3]
// [1;4;9]

(fun x y -> x – y |> abs) 10 20
// 10

// with types on the arguments

(fun (x:int) (y:int) -> x – y |> abs) 10 20
// 10
