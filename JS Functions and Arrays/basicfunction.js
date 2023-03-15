"use strict"

// BASIC Function

// window.onload = firstFunction;

// function firstFunction() {
//     var x = 15;

//     console.log("firstFunction: x = ", x)

//     secondFunction();
// }   

// function secondFunction() {
    
//     console.log("Before declaration: ", x)
//     var x = 20;
    
//     console.log("After declaration: ", x)
// }




// Variables

let globalLet = "This is a global variable declared with let";
var globalVar = "This is a global variable declared with var";

let numLet = 1000;
let numVar = 2000;

const NUM_CONST = 3000;

function firstFunction(){
    let localLet = "this is a local variable";
    var localVar = "This is a local variable";

    undeclaredLocalVar = "Undeclared local variable"

   
}

console.log(globalLet)
console.log(globalVar)

console.log(numLet)
console.log(numVar)
console.log(NUM_CONST)
