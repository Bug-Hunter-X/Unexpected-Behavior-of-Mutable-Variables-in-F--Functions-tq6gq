let mutable x = 10
let mutable y = 20

let swap x y = 
    let temp = x
    x <- y
    y <- temp

swap x y
printf "%d %d" x y //This will print 20 20 as expected

//However, if we try to swap values within a function that takes the values as arguments, it won't work as expected
let swapInFunction x y = 
    let temp = x
    x <- y
    y <- temp
    (x,y)

let x1 = 10
let y1 = 20
let (a,b) = swapInFunction x1 y1
printf "%d %d %d %d" x1 y1 a b //This will print 10 20 20 10, not 20 10 20 10 as expected. 

//The values x and y are passed by value, not by reference.  Therefore the swap function works only if it operates on mutable variables declared outside of the function's scope.
