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
