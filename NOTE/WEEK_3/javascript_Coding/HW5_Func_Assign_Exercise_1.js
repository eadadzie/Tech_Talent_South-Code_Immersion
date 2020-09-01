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

