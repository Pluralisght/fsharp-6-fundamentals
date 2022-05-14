let rec fib = function
| 0 | 1 as n -> n
| n -> fib (n-1) + fib(n-2)

time fib 35
