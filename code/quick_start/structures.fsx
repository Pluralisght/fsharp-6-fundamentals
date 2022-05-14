let aTuple = 1,"a",4.
let (x,y,z) = aTuple

type Person = {First:string; Last:string}
let person1 = {First="John"; Last="Doe"}
let person2 = {First="Jane"; Last="Doe"}
person1=person2
let person3 = {First="John"; Last="Doe"}
person1=person3

type Temperature =
    | DegreesC of float
    | DegreesF of float
let tempInC = DegreesC 100.
let tempInF = DegreesF 212.
tempInC = tempInF
let tempInC2 = DegreesC 100.
tempInC2 = tempInF
tempInC = tempInC2

let withScale temperature =
    match temperature with
    | DegreesC temp -> $"{temp} Centigrade"
    | DegreesF temp -> $"{temp} Fahrenheit"
withScale tempInF
withScale tempInC

type Employee =
    | Worker of Person
    | Manager of Person * Employee list

let manager = Manager (
    {First="Boss";Last="Person"}, 
    [Worker person1; Worker person2])

let validValue = Some(99)
let invalidValue = None

let optionPatternMatch input =
   match input with
    | Some i -> $"input is an int={i}" 
    | None -> "input is missing"

optionPatternMatch validValue
optionPatternMatch invalidValue



