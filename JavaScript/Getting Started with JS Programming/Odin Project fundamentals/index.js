
// Write a function called add7 that takes one number and returns that number + 7.

document.getElementById("addSevenButton").onclick = function(){
    let num;
    
    num = document.getElementById("addSeven").value;
    num = Number(num);
    num = addSeven(num);
    document.getElementById("result").innerHTML = num
    console.log(num)

}

function addSeven(num){
    return (num + 7);
}

// Write a function called multiply that takes 2 numbers and returns their product.

document.getElementById("multSubmit").onclick = function(){
    let mul1;
    let mul2;
    
    mul1 = document.getElementById("multiply1").value;
    mul2 = document.getElementById("multiply2").value;

    mul1 = Number(mul1);
    mul2 = Number(mul2);
    result = multiply(mul1, mul2);
    document.getElementById("resultMult").innerHTML = result;
    console.log(result);

}

function multiply(mul1, mul2){
    return (mul1 * mul2);
}

// Write a function called capitalize that takes a string and returns that string with only the first letter capitalized. Make sure that it can take strings that are lowercase, UPPERCASE or BoTh.


document.getElementById("capSubmit").onclick=function(){
    let cap;

    cap = document.getElementById("cap").value;
    cap = String(cap);
    cap = cap.toLowerCase();
    cap = cap.charAt(0).toUpperCase() + cap.slice(1);
    document.getElementById("capResult").innerHTML = cap;
    console.log(cap);
}
