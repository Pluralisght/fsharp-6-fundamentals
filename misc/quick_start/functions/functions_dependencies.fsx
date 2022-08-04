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

type Person = { Name: string; Age: int }
let people = [{ Name="John"; Age=35 }; { Name="Jane"; Age = 30 }]

let log logger message = message |> logger
log (getLogger "console") "HI!"

let log = getLogger "console"
log "Message"

module CompositionRoot =
    let env = System.Environment.GetEnvironmentVariables()
    let defaultLoggerMedium = 
        match string (env["LOGGER_MEDIUM"]) with
            | "file" -> "file"
            | null | "console" | _ -> "console"
        
    let defaultLogger = getLogger defaultLoggerMedium
    let log = defaultLogger

open CompositionRoot

log "Writes the the logger configured in composition by environment"
