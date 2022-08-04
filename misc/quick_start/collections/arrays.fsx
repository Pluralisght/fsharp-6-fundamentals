[||]  // empty array... val it : 'a[]
[| //[]<int>
    1
    2
    3
|]
[|1..5|] // []<int>
[|for x in 1..5 -> x*x|] // []<int>

let array : float array = [|1;2;3|]

let array = [|1..5|]
array.Length
array[1]
array[1]=3 

array.[0]

array[1] <- -2
array

let array = [| 1; 2; 3 |]
printfn "array.Length is %A" (array.Length) // 3
printfn "array.GetValue(1) is %A" (array.GetValue(1)) // 2

let arrayOfArrays = [| [| 1..3 |]; [| 4..6 |] |]
arrayOfArrays[1][2]

let my2DArray = array2D [ [ 1..3]; [4..6] ]
my2DArray

my2DArray[1,2]


Array.empty
Array.create 5 1.0
let array : int array = Array.zeroCreate 5
Array.init 5 (fun index -> index * index)


let array1 = [|1..3|]
let array2 = [|4..5|]
let array3 = [|6|]
Array.append array1 array2
Array.concat [array1; array2; array3]
Array.copy array1

