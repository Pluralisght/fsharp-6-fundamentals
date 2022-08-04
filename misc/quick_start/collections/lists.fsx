let list0 = []

let list2 = [ // multi-line list<int>
    1
    2
    3
]
let list1 = [1; 2; 3] 
let list3 : float list = [1.; 2; 3.] 
let list4 = [1..5] 

let list1 = [1;2;3]
let list2 = [4;5;6]
list1[1] // 2 (i+1 element in 0 based list)
list2[2] = 6
list2[0] <- 0 // error

10 :: list1 // [19;1;2;3]
list1 :: 10  // can't do this

// but you can do this
list1 @ [10]
list1 @ list2 // [1;2;3;4;5;6]

let list = [ 1; 2; 3 ]
list.IsEmpty 
list.Length
list.Head
list.Tail
list.Tail.Head
list.Tail.Tail.Head
list.Item(1)


let head :: tail = [1;2;3;4]

// comprehensions
[for x in 1..5 do yield x*x]
[for x in 1..5 -> x*x]
[
    for r in 1..8 do
        for c in 1..8 do
            if r <> c then yield (r,c)
]

let list = List.init 5 (fun x -> x*2)

// list of random numbers
let list = let r = System.Random() in List.init 10 (fun x -> r.Next(0, 10));;


List.sort [5..-1..0]
List.sortDescending [1..5]
List.rev ["a"; "b"; "c"]

List.exists (fun x -> x > 2) [1..5]
List.where (fun x -> x <3) [1..5]

List.findIndex (fun x -> x = "b") ["z"; "e"; "a"; "b"; "4"]
List.find (fun x -> x%2=0) [1; -1; 9; 4; 3]

let list1d = [1; 3; 7; 9; 11; 13; 15; 19; 22; 29; 36]
let isEven x = x % 2 = 0
match List.tryFind isEven list1d with
| Some value -> printfn "The first even value is %d." value
| None -> printfn "There is no even value in the list."

match List.tryFindIndex isEven list1d with
| Some value -> printfn "The first even value is at position %d." value
| None -> printfn "There is no even value in the list."

List.zip ["a"; "b"; "c"] [1..3]
List.unzip [("a",  1); ("b", 2); ("c", 3)]

let list = [1.; 2.; 10.; 3.; 2.; 5.]
List.sum list, List.average list, List.min list, List.max list
