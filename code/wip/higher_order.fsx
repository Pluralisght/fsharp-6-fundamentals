let map mapper items =
    [for item in items -> mapper item]

map (fun i -> i * 2) [1..3]

let filter filterfunc items =
    [for item in items -> if filterfunc item then item else []]

filter (fun i -> i % 2 == 0) [1..10]
(*
let filter f list =
    let rec loop f list acc =
        match list with
        | head :: tail -> if f head then head else (filter f tail acc
        | [] -> acc
    loop f list []
*)

let rec filter f list acc =
    printfn "%A %A" list acc
    match list with
    | head :: tail -> 
        if f head then 
            filter f tail  (acc @ [head])
        else 
            filter f tail acc
    | [] -> acc

let rec filter2 f list =
    let rec loop f list acc =
        match list with
        | head :: tail -> 
            if f head then 
                loop f tail (acc @ [head])
            else 
                loop f tail acc
        | [] -> acc
    loop f list []

filter2 (fun i -> i % 2 = 0) [1..10] 



filter (fun i -> i % 2 = 0) [1..10]

