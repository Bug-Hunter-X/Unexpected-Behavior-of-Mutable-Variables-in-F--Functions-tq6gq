let mutable x = 10
let mutable y = 20

let swap x y = 
    let temp = x
    x <- y
    y <- temp

swap x y
printf "%d %d" x y //This will print 20 20 as expected

//Instead of trying to modify the inputs inside the function, let's return the swapped values.
let swapInFunction x y = 
    let temp = x
    x <- y
    y <- temp
    (x,y)

let x1 = 10
let y1 = 20
let (a,b) = swapInFunction x1 y1
printf "%d %d %d %d" x1 y1 a b //This will print 10 20 20 10

//Now, let's use the correct approach: using mutable variables declared outside the function
let mutable x2 = 10
let mutable y2 = 20

let swapUsingRefs (xRef: byref<int>) (yRef: byref<int>) = 
    let temp = xRef
    xRef <- yRef
    yRef <- temp

swapUsingRefs &x2 &y2
printf "%d %d" x2 y2 // This will print 20 10 as expected

//Alternatively, avoid mutable variables and use tuples instead 
let swapTuple (x,y) = (y,x)
let (a1, b1) = swapTuple (10, 20)
printf "%d %d" a1 b1 //This prints 20 10
