let a = 1

let square x =
    x * x

printfn "%A" (2*100)
System.Console.WriteLine($"The value is {2*100}")

open System
printf "Enter your command human: "
let input = Console.ReadLine();
printfn "The input is: %A" input

let list = [1; 2; 3; 4; 5]
for i in list do
    printfn "%A" i

for i = 1 to 5 do
    printfn "%A" i

let mutable i = 0;
while i < 5 do
    printfn "%A" i
    i <- i + 1

do printf "%A" 1


