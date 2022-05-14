let values = [10; 3; 100]

for value in values do
    printfn "%A" value

for i in 0..values.Length-1 do
    printfn "%A" values[i]

let mutable i = 0
while i < values.Length do
    printfn "%A" values[i]
    i <- i + 1

[0..6]
[0..2..10]

let square x = x * x

[for value in values do square value]

List.map square values

List.sum (List.map square values)

values |> List.map square
values |> List.map square |> List.sum

[0..10] |> List.filter (fun x -> x%2=0)

[0..10]
    |> List.filter (fun x -> x%2=0)
    |> List.map (fun x -> x * x)
    |> List.sum

// imperative / old school
let data = [1; 2; 3]
let mutable mutableSum = 0;
for value in data do mutableSum <- mutableSum + value

// functional / expression way
let sum = List.sum(data)


// instead of a for loop to print
let data = [1; 2; 3]
List.iter (fun x -> printfn "%A" x) data

let square x = 
    let result = x * x
    result

let square x = 
    let result = x * x
    result

let add x y =  x + y

let (|><|) x y = x - y |> abs


let add = function x =
    function y = 
        x + y

