type vec2 = { mutable x:float; mutable y:float} with
    member r.Length
        with get () =
            sqrt(r.x * r.x + r.y * r.y)
        and set len =
            let s = len / r.Length
            r.x <- s * r.x
            r.y <- s * r.y
