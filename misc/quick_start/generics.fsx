let swapImplicit(a, b) = b,a // 'a * 'b -> 'b * 'a
let swapExplicit (a: 'a) (b: 'b) = b,a

type GenericRecord<'a, 'b> =
    {
        Field1: 'a;
        Field2: 'b;        
    }
let gr1 = { Field1=1.0; Field2=2 }
let gr2 = { Field1="x"; Field2=true }

open System.Collections.Generic
let numbers = List<int>()
numbers.Add(10)
numbers.Add(20)

let numbers = List<_>()
numbers.Add(10)
