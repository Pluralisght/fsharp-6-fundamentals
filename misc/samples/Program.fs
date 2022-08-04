// For more information see https://aka.ms/fsharp-console-apps
printfn "Hello from F#"

let argv = System.Environment.GetCommandLineArgs()

for arg in argv do
    printfn "%A" arg