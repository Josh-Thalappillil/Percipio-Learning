
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