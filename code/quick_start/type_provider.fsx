#r "nuget: ExcelProvider"
open FSharp.Interop.Excel

type MyExcelProvider = ExcelFile<"F:\\fsharp-6-fundamentals\\code\\02\\quick_start\\data.xlsx">
let file = new MyExcelProvider()
let row = file.Data |> Seq.head
(row.Date, row.Item)