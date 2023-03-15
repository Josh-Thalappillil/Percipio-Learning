"use strict"

console.log("Value of Pi : ", Math.PI);
console.log("The Euler's constant is : ", Math.E);

// Round Function

console.log(Math.round(3.2));
console.log(Math.round(3.8));

// Absoulte function

console.log(Math.abs(4))
console.log(Math.abs(-4))

// power function

console.log(Math.pow(4, 2))

// square root

console.log(Math.sqrt(20.08))
console.log(Math.sqrt(42))

// floor function (always round down integer)
console.log(Math.floor(2.5))

// ceiling function (always round up integer)
console.log(Math.ceil(2.5))


// math.max and math. min

console.log(Math.max(10, 20, 100, 200))
console.log(Math.min(10, 100 ,-200))

// a random value between 0 and 1

console.log(Math.random())

// random value between 0 and 9
console.log(Math.floor(Math.random()*10))

// Random integer between 0 and 10
console.log(Math.floor(Math.random()*11))

// random integer between 1 and 10 (the +1 is to offset the starting position of the number)
console.log(Math.floor(Math.random()*10) + 1)



// Arithmetic Operators

var concatenatedString = "We" + " " + "are" + " " + "learning" + " " + "JavaScript"
console.log(concatenatedString)


var x = 20
var y = 6
// Subtraction
console.log(x - y)

// Mulitplication
console.log(x * y)

// Division
console.log(x / y)

// Modulus
console.log(x % y)

// Increment operator
console.log(++x)
console.log(x++)

// post and pre Decrement operator
console.log(--x)
console.log(x--)



y = x
console.log(y)

x += 1
console.log(x)

y -= 1
console.log(y)


// Comparison Operators

let intValue = 70;
let stringValue = "70";




// Logical and Conditional Operators
let A = 13, B = 25
    // AND is representeded by &&
if(A >= 12 && B <= 25)
    console.log("A + B = ", A + B);

    // Means OR ||
let X = 15, Y = 20;
if(X > 20 || Y < 25)
    console.log("X + Y = ", X + Y)

    // =! not equal to