open System.IO

let writetofile filename obj =
    use file1 = File.CreateText(filename)
    file1.WriteLine("{0}", obj.ToString() )
    // file1.Dispose() is called when function returns
writetofile "abc.txt" "Humpty Dumpty sat on a wall."

open System.IO
let writetofile2 filename obj =
    using (System.IO.File.CreateText(filename) ( fun file1 ->
        file1.WriteLine("{0}", obj.ToString() )
    )
writetofile2 "abc2.txt" "The quick sly fox jumps over the lazy brown dog."
