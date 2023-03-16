"use strict";

let add;
// how to add arrays
function sum(...nums) {
    add = 0;
    for (var num of nums){
        add += num;
    }
    return add;
}

let addition = sum(1, 2, 3, 4);

console.log(addition);


function studentDetails(...courses) {
    let sub;
    for(sub = 0; sub < courses.length; sub++) {
        console.log("Name of student: ", courses[sub]);
    }
}

studentDetails("Chris", "JavaScript", "Python", "Scala")





// The spread syntax and rest parameters
console.log("SPREAD SYNTAX")

console.log("The min of 1,2,3 : ", Math.min(1,2,3));

let arr1 = [1,2,3];

console.log("The min of arr1 (without spread) :", Math.min(arr1))
console.log("Min of arr1 (with spread) : ", Math.min(...arr1));


let arr2 = [4,5,6];
let arr3 = [3,7,2];

console.log("Min of arr2 and arr3 :", Math.min(...arr2,0,...arr3,8))


let arrays = [...arr1, 10, ...arr3, 20];
console.log("arrays created by combining the spread operator with integers: \n", arrays);


let str = "Skillsoft";
console.log("str = : ", [...str])
console.log("Array formed with Array.from(str): \n", Array.from(str))

// Destructuring arrays

let numbers = [10, 20, 30, 40];
let [a, b, c, d] = numbers;


[a, ...b] = numbers

console.log("Values after [a, ...b] = numbers : \n");
console.log("Value of a : " + a);
console.log("Value of b : " + b);

// Copying arrays

let prices = new Array(10, 20, 36, 40, 47);
let shallowCopy = prices;

console.log(prices);

shallowCopy[0] = 70;

let deepCopy = prices.slice();
console.log("Before modifying deepcopy: ", deepCopy);

deepCopy[0] = "Eighty";

console.log("After modifying deepcopy: ", deepCopy);

// Adds at the end of the array
prices.push(100);
console.log(prices)

// Adds 0 at the front of the array
prices.unshift(0);
console.log(prices)

// Removes number added at the end of the array
prices.pop()
console.log(prices)

// Removes the number added at start of the array
prices.shift()
console.log(prices)

// Delete at value in an array at specific index
delete prices[2];
console.log("Contents of prices after a delete at index 2 : \n", prices)



// Splicing and slicing arrays

let dogBreeds = ['Labrador', 'Beagle', 'Golden Retriever', 'Doberman', 'German Shepherd', 'Boxer'];
console.log("Original contents of dogBreeds \n", dogBreeds)

// dogBreeds.splice(3,0, 'Poodle', 'Dalmatian');
// console.log("After splicing :", dogBreeds)

// dogBreeds.splice(1,2,'Indi');
// console.log("After splicing :", dogBreeds)

// let sliceOfDogBreeds = dogBreeds.slice(3, 5);
// console.log("dogBreeds.slice(3) = \n", sliceOfDogBreeds);

let sliceOfDogBreeds = dogBreeds.slice(-3, -1);
console.log("dogBreeds.slice(-3,-1) = \n", sliceOfDogBreeds);