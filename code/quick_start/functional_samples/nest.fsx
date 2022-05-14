let rec nest n f x =
    match n with
    | n -> nest (n - 1) f (f x)

let f''' = nest 3 d f
