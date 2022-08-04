open System.Diagnostics
let time f x =
    let timer = new System.Diagnostics.Stopwatch()
    timer. Start()
    try f x finally
    printf "Took %dms" timer.ElapsedMilliseconds


let rec loop n f x =
    if n > 0 then
        f x |> ignore
    loop (n - 1) f x

let x : float = 10

