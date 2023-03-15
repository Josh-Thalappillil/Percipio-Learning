
let numLet = 10
var numVar = 20
const NUM_CONST = 30


// function secondFunction() {
//     let numLet = 100;
//     var numVar = 200;
//     let NUM_CONST = 300;

//     console.log("Redeclared numLet from inside secondFunction: ", numLet);
//     console.log("Redeclared numLet from inside secondFunction: ", numVar);

// }

// secondFunction();

// console.log("numLet from outside after invoking secondFunction: ", numLet);
// console.log("numVar from outside after invoking secondFunction: ", numVar);
// console.log("NUM_CONST from outside after invoking secondFunction: ", NUM_CONST);


// function thirdFunction() {
//     numLet = 1000;
//     numVar = 2000;
//     console.log("Updated numLet from 3 function: ", numLet)
//     console.log("Updated numVar from 3 function: ", numVar)
//     // We have changed the global variables in third functions
// }

// thirdFunction()

// console.log(numLet)
// console.log(numVar)
// // so now when we call the global variables again they appear redclared by the third function

function fourthFunction() {
    console.log("Starting first for loop...");
    for (let i = 0; i < 10; i++)
    {
        console.log(i)
    }
    // console.log("value of i:", i)  This fails because let function scope only applies to the for function


    console.log("Starting second for loop...");
    for(var j = 0; j < 10; j++)
    {
        console.log(j)
    }
    console.log("value of j: ", j)  
    // This code passes and shows us the value of j because the var function scope extends to the whole function
}

fourthFunction()