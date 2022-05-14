List.map (fun x -> x*2) [1;2;3] // val it: [2;4;6]

(|>) // val it: ('a -> ('a -> 'b) -> ‘b)
let (|>) = x f = f x // actual definition

[1;2;3] |> List.map (fun x -> x*2)-// val it: int list = [2;4;6]

[1..4]
    |> List.filter (fun i -> i % 2 = 0) // [2;4]
    |> List.map ((*) 2) // or List.map (fun i -> i * 2) 
    |> List.sum

List.sum (
    List.map ((*) 2) (
        List.filter (fun i -> i % 2 = 0) [1..4]
    ) 
)


sin 2. + 1.
// val it: float = 1.909297427
sin (2. + 1.)
// val it: float = 0.1411200081
// left associative no need for parentheses
sin <| 2. + 1.
// val it: float = 0.1411200081

min 15 8
// val it: int = 8
15 |> min |< 8
// val it: int = 8

min 			// val it: ('a -> 'a -> 'a) when 'a: comparison
min 15 8		// val it: int = 8


(||>)
(<||)

min
min 15 8

(15, 8) ||> min
min <|| (15,8)

let aTernary a b c = a * b * c
(2, 4, 8) |||> aTernary
aTernary <||| (2, 4, 8)



