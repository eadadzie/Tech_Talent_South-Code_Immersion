////////////////////////// Exercise 2 ////////////////////////

// Function to join array into a string

function joinString(array2){
    let arrayString = array2.toString();
    return arrayString;
}

let myColor = ["Red", "Green", "White", "Black"];
document.getElementById("String_array").innerHTML = myColor;

myArrayString = joinString(myColor)
//console.log("Array to string:", myArrayString);
document.getElementById("Joined_items").innerHTML = myArrayString;
