
let x;
let y;
let z;
let a;

document.getElementById("rollButton").onclick = function(){
    let x = Math.floor(Math.random() * 6) + 1;
    let y = Math.floor(Math.random() * 10) + 1;
    let z = Math.floor(Math.random() * 12) + 1;

    let a = x + y + z;

    document.getElementById("xLabel").innerHTML = x;
    document.getElementById("yLabel").innerHTML = y;
    document.getElementById("zLabel").innerHTML = z;
    document.getElementById("aLabel").innerHTML = a;
}