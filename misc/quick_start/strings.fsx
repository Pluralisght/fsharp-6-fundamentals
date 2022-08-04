let astring = "Hello from F#"
astring[1] = 'a'
astring[2..5]
astring[1] <- 'a' // no can do

let str1 = "abc
def"
let str2 = "abc\
def"

// Using a verbatim string
let xmlFragment1 = @"<book author=""Milton, John"" title=""Paradise Lost"">"

// Using a triple-quoted string
let xmlFragment2 = """<book author="Milton, John" title="Paradise Lost">"""

let builder = System.Text.StringBuilder()
builder.Append("abc")
builder.Append("123")
let s = builder.ToString()

let a = 1
let b = 2.
let interpolated = $"Use $ and handlebars: a={a} b={b}"

printf "Hello\n"
printfn "Hello\rY"

let s = sprintf "String: \"%s\", int: %d, float: %f\n" "foo" 3 7.4

