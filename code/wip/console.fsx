let a = [|1; 2; 3|]
printfn "%A" a
System.Console.WriteLine(a)


printfn "%A" (2*100)
System.Console.WriteLine($"The value is {2*100}")

open System
printf "Enter your command human: "
let input = Console.ReadLine(); // read input from the console
printfn "The input is: %A" input
