let capitals = 
    ["USA", "Washington D.C"; "Canada", "Ottawa"; "France", "Paris"]
    |> Map.ofList
let usa = capitals["USA"]
let canada = capitals["Canada"]
let newCapitals = 
    capitals
    |> Map.add "Japan" "Tokyo"
    |>  Map.remove "France"