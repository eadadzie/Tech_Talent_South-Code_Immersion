/////////////////// Exercise 2 /////////////////////

// Function to check a prime for prime number
function checkPrime(num){
    factorCount = 1;
    for(i= 1; i <= num; i++){
        if(num % i == 0 && i != 1){
            factorCount += 1;
        }
    }

    if (factorCount === 2) {
        //console.log(`*** ${num} is Prime`);
        return ` ${num} is Prime`;
    }
    else{
        //console.log(`*** ${num} is NOT Prime`);
        return ` ${num} is NOT Prime`;
    }
}

// Testing function with the primes within a range of numbers (inclusive)
let numbers = [...Array(8).keys()];
document.getElementById("Number_List").innerHTML = numbers;

let output = []
for (j = 0; j < numbers.length; j++) {
    output.push(checkPrime(numbers[j]));   
}

document.getElementById("Check_Prime").innerHTML = output;