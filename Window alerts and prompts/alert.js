"use strict"

alert("This is an alert message");

let name = prompt("The prompt message is: \nPlease Enter your name:");
console.log("You have entered " + name);

let subject = prompt("Please enter your selected subject", "JavaScript");
console.log("Your selected subject is " + subject);


let a = prompt("Please enter a value to get squared");
let b = a * a;
alert("Square value of " + a + " is: " + b);

let output = confirm("Confirmation Message: \nReady to move to the next demo?");
if(output) {
    console.log("Your pressed OK")
}
    else {
        console.log("You pressed cancel")
    }

