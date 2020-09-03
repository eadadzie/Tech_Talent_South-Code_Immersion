////////////////////////// Exercise 1 ////////////////////////

// Function to clone an array
function cloneArray(array1){
    //let clone = [...array1]; //Another approach
    clone = []
    for(i= 0; i < array1.length; i++){
        clone.push(array1[i])
    }
    return clone;
}

// Create an array as the original
let actualArray = [0,2,4,4,3,3,8];
document.getElementById("Array_input").innerHTML = actualArray;

// Clone the original array
let myArray = cloneArray(actualArray);
//console.log("Cloned:", myArray);
document.getElementById("Cloned_array").innerHTML = myArray;

// Check if the clone is share the same reference with original
if(myArray === actualArray){
    //console.log("*** Unsuccessful Cloning!" );
    document.getElementById("Output").innerHTML = "Unsuccessful Cloning!";
}
else {
    //console.log("*** Cloning Successful!" );
    document.getElementById("Output").innerHTML = "Cloning Successful!" ;
}
