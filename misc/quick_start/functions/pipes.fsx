let mymap items mapper = List.map mapper items
mymap [1;2;3] (fun i -> i * 2)
// val it: int list = [2; 4; 6]

mymap [1;2;3] <| fun i -> i * 2
// val it: int list = [2; 4; 6]

[1..3] |> mymap <| fun i -> i * 2 // both forward and back
// val it: int list = [2; 4; 6]

sin 2. + 1.

sin (2. + 1.)

sin <| 2. + 1.


min 15 8

