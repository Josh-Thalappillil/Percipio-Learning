// let age = 16;
// let name = age > 10 ? "Pedro" : "Jack";

// const Component = () => {
//     return age > 10 ? <div>Pedro</div> : <div>Jack</div>;
// }

// const person = {
//     name: "Pedro",
//     age: 20,
//     isMarried: false,
// };

// const person2 = {...person, name: "Jack Sparrow"}


// List in react
// let names = ["Pedro", "Jack", "Jess"];

// names.map((name) => {
//     <h1>{name}</h1>
// })

// Filter function
// let names = ["Pedro", "Jessica", "Pedro", "Carol", "Pedro"];

// names.filter((name) => {
//     return name !== "Pedro";
// })

// Async with Fetch API

// const loadUsers = async () => {    
//     return (await fetch("data/users.json")).json();
    
// }

// document.addEventListener("DOMContentLoaded", async () => {
//     let users = [];
//     try {
//         users = await loadUsers();
//     } catch (e) {
//         console.log("Error");
//         console.log(e)
//     }
//     console.log(users);
// })

// User input
// let username = window.prompt("Enter a name:");
// console.log(username)
// let username;
// document.getElementById("myButton").onclick = function(){
//     username = document.getElementById("myText").value;
//     console.log(username);
//     document.getElementById("myLabel").innerHTML = "Hello " + username;
// }




document.getElementById("submitButton").onclick = function(){
    a = document.getElementById("aTextBox").value;
    a = Number(a)

    b = document.getElementById("bTextBox").value;
    b = Number(b)

    c = Math.sqrt(Math.pow(a, 2) + Math.pow(b, 2));
    document.getElementById("cLabel").innerHTML = "Side C: " + c;

}