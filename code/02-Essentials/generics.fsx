// implicit, inferred by compiler
let swapImplicit (a, b) = b, a 

let swapExplicit (a: 'a) (b: 'b) = b, a


type GenericRecord<'a, 'b> = // C# would be GenericRecord<T,V>
    {
        Field1: 'a;
        Field2: 'b; 
    }

let record1 = { Field1=1.0; Field2=2 }
let record2 = { Field1="x"; Field2=true }

// _ for each generic parameter will be inferred
let inventory = Dictionary<_, _>()
inventory.Add("Apples", 0.79)
inventory

// also infer types if omitted
let inventory = Dictionary()
inventory.Add("Apples", 1)
