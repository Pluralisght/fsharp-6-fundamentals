(*
match expr with
| pattern1 -> exp1
| pattern2 -> exp2
...
| patternn -> exprn
| _ -> expr-all-other
*)

let f = function
    | 0 -> "Zero"
    | 3 -> "Three"
    | _ -> "Neither zero nor three"


let f i = // int -> string
    match i with 
    | 0 -> "Zero"
    | 3 -> "Three"
    | _ -> "Neither zero nor three"

f 0 // val it: string = "Zero"
f 1 // val it: string = "Neither zero nor three"
f 2 // val it: string = "Neither zero nor three"
f 3 // val it: string = "Three"

let is_empty_list list =
    list = []

let is_empty_list list =
    match list with
    | [] -> true
    | _ -> false

let is_empty_list = function
    | [] -> true
    | _::_ -> false

let rec pairs = function
    | h1::(h2::_ as t) -> (h1, h2) :: pairs t
    | _ -> []
    pairs [1..5]


let rec positive = function
    | [] -> []
    | h::t when h<0 -> positive t
    | h::t -> h::positive t
    positive [-3..5]

let is_sign = function
    | -1 | 0 | 1 -> true
    | _ -> false
    is_sign -2, is_sign -1, is_sign 0, is_sign 1, is_sign 2
