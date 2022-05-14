open System.Net
open Microsoft.FSharp.Control.WebExtensions
open System.Net.Http

let urlList = [ "Microsoft.com", "https://smac.io"
                "MSDN", "http://msdn.microsoft.com/"
                "Bing", "http://www.bing.com"
              ]

let fetchAsync(name, url:string) =
    async {
        try
            let client = new HttpClient()
            let! html = (client.GetStringAsync(new System.Uri(url)) |> Async.AwaitTask)
            printfn "Read %d characters for %s" html.Length name
        with
            | ex -> printfn "%s" (ex.Message);
    }

let runAll() =
    urlList
    |> Seq.map fetchAsync
    |> Async.Parallel
    |> Async.RunSynchronously
    |> ignore

runAll()
