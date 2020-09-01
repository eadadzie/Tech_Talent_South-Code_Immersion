/////////////////// Exercise 2 /////////////////////

// Function to reverse a number
function checkPrime(num){
    factorCount = 1;
    for(i= 1; i <= num; i++){
        if(num % i == 0 && i != 1){
            factorCount += 1;
        }
    }

    if (factorCount === 2) {
        console.log(`*** ${num} is Prime`) ;
    }
    else{
        console.log(`*** ${num} is NOT Prime`);
    }
}

// Testing function with the primes within a range of numbers (inclusive)
let numbers = 5;

for (j = 0; j <= numbers; j++) {
    checkPrime(j);   
}
