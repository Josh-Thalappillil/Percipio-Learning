"use strict"

let num = 25;
let str = "250";
let boolean = true;
let date = new Date('2023-01-22');

// Type conversion num to string
let num_str = String(num)
console.log("Type of num cast to String: ", typeof(num_str));
console.log("Value of num cast to string: ", num_str)

let str_num = Number(num_str)
console.log(typeof(str_num))
console.log((str_num))


let date_num = String(date);
console.log(date_num)

// converting to booleans
console.log(Boolean(num))


// <br>
// Loops

console.log("While Loops")
// console.log("Integers from 1 to 10 : ");
// let i = 1;
// while(i <= 20) {
//     let num = i%2;
//     if(num == 0){
//     console.log(i)
//     }
//     i++;
// }


let i = 11;
while(i > 1) {
    i--;
    if(i == 5){
        continue;
    }
    console.log(i)
    
}
