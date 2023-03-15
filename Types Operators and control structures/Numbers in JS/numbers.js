"use strict";

let n = 123;
console.log("Value of n = ", n);

n = 12.345;
console.log("New value of floating point n = ", n);

console.log("145e4 = ", 145e4)
console.log("145e-4 = ", 145e-4)

console.log(0xEF)



let sum = `${1+2+3}`
console.log(`the expression evaluated to a value of ${sum}`);


let sentence = "I \"love\" spinach"
console.log("String defined with escape characters: ", sentence);

let multiline_str = 
`               This is a
                String which
                spans multiple line`;
console.log("A multi-line string: \n", multiline_str);



var name_str1 = "David";
var name_str2 = "David";

var name_obj1 = new String("David");
var name_obj2 = new String("David");

console.log("Type of name_str1:", typeof name_str1);
console.log("Type of name_obj1: ", typeof name_obj1);


let empName = "Jane Chang";

console.log("Number of characters in empName is : " + empName.length);
console.log("Index of h is : " + empName.lastIndexOf("h"));
console.log("'Ch' occurs at position: " + empName.search("Ch"));


var line = "Fundamentals of JavaScript";

console.log("Original line: ", line)
console.log("slice (1,12): ", line.slice(1, 12));
console.log("Slice (-23, -15): ", line.slice(-23, -15))


console.log("Replacing javascript with programming: ", line.replace("JavaScript", "Programming"))
console.log("Replacing javascript with programming case insensitive: ", line.replace(/javascript/i, "Programming"))
console.log("default replace of 'a' with 'A': ", line.replace("a", "A"));
console.log("Replace globally all a: ", line.replace(/a/g, "A")); 
// g at the end of /a/"g" refers to global replacement 

// splitting a string

var line2 = "Fundamentals of programming"
console.log("Splitting the line on space: ", line2.split (" "))




// Date

var time = new Date();
console.log("Current time : \n", time)

time = new Date(2020, 3, 16, 15, 21, 43);
console.log("Year, Month, Day, hour, min, sec:\n", time)

time = new Date("2020-03-16");
console.log("Initialised with yyyy-mm-dd: \n", time)


console.log("My timezone offset in minutes: ", time.getTimezoneOffset())

console.log("The UTC time is: ",time.toUTCString())
