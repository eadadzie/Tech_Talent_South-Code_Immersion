/////////////////// Exercise 1 /////////////////////

// Function to reverse a number
function reverseNumber(num){
    numToString = num.toString();
    reverseNum = numToString.split('').reverse().join('');
    return reverseNum;
}

let myNumber = 123456;

myReverNumber = reverseNumber(myNumber);

console.log("My reversed number:", myReverNumber);



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



/////////////////// Exercise 3 /////////////////////

// Function to count a charater in a string
function countLetter(str, chr){
  occurrences = 0;
  for(k= 0; k < str.length; k++){
      if (chr === str.toLowerCase()[k]) {
        occurrences += 1;
      }
  }

  console.log(`The letter, "${chr}", occurs ${occurrences} time(s) in the string, "${str}".`);
}

// Calling the function
myString = "Emmanuel is lagging behind";

countLetter(myString, 'm');
