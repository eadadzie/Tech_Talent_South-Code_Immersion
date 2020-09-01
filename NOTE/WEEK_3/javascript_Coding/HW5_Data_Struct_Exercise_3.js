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
document.getElementById("Integer_array").innerHTML = integerArray;

arrayComputations = sumAndProduct(integerArray)
//console.log(`Array sum is ${arrayComputations[0]}, and products is ${arrayComputations[1]}`);
document.getElementById("Computations_1").innerHTML = `Array's SUM is ${arrayComputations[0]}, and PRODUCT is ${arrayComputations[1]}`;