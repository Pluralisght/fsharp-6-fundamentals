

let add x y= x + y
let add1 = add 1
let times2 x = x * 2
let add1thenTimes2 = add1 >> times2
let times2thenAdd1 = add1 << times2
add1thenTimes2 5

times2thenAdd1 5

(15, 8) ||> min
min <|| (15,8)

let aTernary a b c = a * b * c
(2, 4, 8) |||> aTernary


