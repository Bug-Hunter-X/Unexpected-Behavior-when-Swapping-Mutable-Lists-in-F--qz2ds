let mutable x = 10
let mutable y = 20

let swap x y = 
    let temp = x
    x <- y
    y <- temp

swap x y
printf "%d %d" x y //Prints 20 10 as expected

let mutable a = [1;2;3]
let mutable b = [4;5;6]

let swapList a b = 
    let temp = a
    a <- b
    b <- List.copy temp // Create a copy of list 'a' before assigning 'b'
    
    //instead of above line, you could also do this
    //let temp2 = b
    //b<-temp
    // a <- temp2    

swapList a b
printf "%A %A" a b //Prints [4;5;6] [1;2;3]