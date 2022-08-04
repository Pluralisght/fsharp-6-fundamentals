let map mapper items =
    [for value in items -> mapper value]

map (fun x -> x*x) [1..3]

List.map (fun x -> x*x) [1..3]

type Person = { Name: string; Age: int }
let people = [{ Name="John"; Age=35 }; { Name="Jane"; Age = 30 }]
List.map (fun person -> person.Name) people


let filter f list=
    let rec loop f list accumulator=
        match list with
        | [] -> accumulator
        | head :: tail -> 
            if f head then loop f tail (accumulator @ [head])
                      else loop f tail accumulator
    loop f list []
filter (fun person -> person.Age < 32) people

List.filter (fun person -> person.Age < 32) people

let aggregate f items  =
    let rec loop f items accumulator=
        match items with
        | [] -> accumulator
        | head :: tail -> loop f tail (f accumulator head)
    loop f items 0
aggregate (+) (List.map (fun person -> person.Age) people)

List.fold (+) 0 (List.map (fun person -> person.Age) people)
List.sum (List.map (fun person -> person.Age) people)


let add x y = x + y
let buildAdder amount = 
    add amount

let add0 = buildAdder 0
let add10 = buildAdder 10


let getLogger medium =
    let log writer text = 
        writer text
        text
    match medium with
    | "console" -> log (fun (text:string) -> System.Console.WriteLine(text)) 
    | "file" -> log (fun text -> System.IO.File.AppendAllLines("log.txt", [text]))
    | _ -> fun text -> text

let getConsoleLogger = getLogger "console"
let getFileLogger = getLogger "file"

let consoleLogger = getConsoleLogger 
consoleLogger "Console only"
let fileLogger = getFileLogger
fileLogger "File only"
let composite = getFileLogger >> getConsoleLogger
composite "Goes to console and file"
