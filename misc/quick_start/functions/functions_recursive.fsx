// rec lets a variable definition to refer to itself

let rec ipow n m =
    if m=0 then 1 
           else n * ipow n (m-1)

ipow 2 4

let length_imperative l =
    let mutable length = 0
    for item in l do length <- length + 1
    length 
length_imperative [1;2;3]

let rec length = function
    | [] -> 0
    | x::xs -> 1 + length xs
length_imperative [1;2;3]


let rec length x = 
    match x with
    | [] -> 0
    | x::xs -> 1 + length xs
length [1;2;3]


let sum_imperative l =
    let mutable total = 0  // uh oh
    for item in l do total <- total + item
    total
sum_imperative [1..3]

let rec sum_recursive items = 
    match l with
    | [] -> 0
    | head::tail -> head + sum tail


let rec sum  = function
    | [] -> 0
    | head::tail -> head + sum tail


let rec sum  = function
    | [] -> 0
    | head::tail -> head + sum tail
sum [1..3]

let sum items = 
    let rec loop items accum =
        match items with
        | [] -> accum
        | head::tail -> loop tail (accum  + head)
    loop items 0
sum [1..3]

List.fold (+) 0  [1;2;3]
