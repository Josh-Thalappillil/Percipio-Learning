document.getElementById("submitButton").onclick = function(){
    let temp;

    if(document.getElementById("cButton").checked){
        temp = document.getElementById("textBox").value;
        temp = Number(temp);
        temp = toCelsius(temp);
        document.getElementById("tempLabel").innerHTML = temp + "°C";
    }
    else if(document.getElementById("fButton").checked){
        temp = document.getElementById("textBox").value;
        temp = Number(temp);
        temp = toFarenheit(temp);
        document.getElementById("tempLabel").innerHTML = temp + "°";
    }
    else{
        document.getElementById("tempLabel").innerHTML = "Please select a temperature";
    }
}

let temp = 32;
temp = toCelsius(temp);
console.log(temp);

function toCelsius(temp) {
    return (temp - 32) * (5 / 9);
}

function toFarenheit(temp) {
    return (temp * 9 / 5) + 32;
}