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

// Clone the original array
let myArray = cloneArray(actualArray);
console.log("Cloned:", myArray);

// Check if the clone is share the same reference with original
if(myArray === actualArray){
    console.log("*** Unsuccessful Cloning!" );
}
else {
    console.log("*** Cloning Successful!" );
}


////////////////////////// Exercise 2 ////////////////////////

// Function to join array into a string

function joinString(array2){
    let arrayString = array2.toString();
    return arrayString;
}

let myColor = ["Red", "Green", "White", "Black"];

myArrayString = joinString(myColor)
console.log("Array to string:", myArrayString);


////////////////////////// Exercise 3 ////////////////////////

// Function to compute both sum and product
function sumAndProduct(array3){
    let arraySum = 0, arrayProduct = 1;
    for (i= 0; i < array3.length; i++) {
        arraySum += array3[i];
        arrayProduct *= array3[i]; 
    }
    return [arraySum, arrayProduct];
}

integerArray = [2,3,4]
arrayComputations = sumAndProduct(integerArray)
console.log(`Array sum is ${arrayComputations[0]}, and products is ${arrayComputations[1]}`);