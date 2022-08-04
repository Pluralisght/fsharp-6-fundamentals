open System
(*
printfn "Hello from F#"
let argv_top = System.Environment.GetCommandLineArgs()
printfn "%A" argv_top
*)

let printArgs argv =
    for arg in argv do
        printfn "%A" arg

let sumArgs argv =
    let vals = [for arg in argv do (int arg)]
    let ints = List.map (fun (a: int) -> (int a))
    ints |> List.sum
    ints

[<EntryPoint>]
let main argv =
    printfn "Hello from main"
    printfn "%A" argv

    printArgs argv
    printfn "%A" (sumArgs argv)
    0


    //System.Console.WriteLine(argv)
(*
    printfn "Enter your input"
    let input = Console.ReadLine()
    printfn "You entered: %A" input
    */
    0*)
