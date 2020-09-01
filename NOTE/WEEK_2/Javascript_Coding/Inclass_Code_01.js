
// Challenge 1

const numOfCups = Number(prompt("How many cups of coffee have you had?"))

if (numOfCups < 3) {
	console.log("Yes I'll take another cup of coffee.");
}
else{
	console.log("I think I'm okay for now.");
}


// Loops
for (let index = 5; index < 20; index++) {
	if (index === 10){
		let continued = true;
		// This means skip to the next iteration
		continue
	}
	console.log(index);
}


// Challenge 2

let price = 10;
let newPrice = 20;
let total = price + newPrice;

if ((price < 10 && newPrice < 20) && total === 30){
	console.log("price < 10 && newPrice && 20 || total === 30");
}
else if (price < 10 || newPrice < 20 || total === 30) {
	console.log("price < 10 || newPrice < 20 || total === 30");
}


// Challenge 3
let temperature = 80;

console.log("the temperature is 80 degrees");

if (temperature > 80) {
	console.log("time to swim!");
}

let precipitation = false;

if (temperature > 80 && precipitation === false) {
	console.log("time to swim");
}

let snowing = false;

if (precipitation === false && snowing === false) {
	// do something
}

let indoors = true;

if (indoors) {
	console.log("Time to swim!");
}

for (let bottles = 99; bottles >= 0; bottles--) {
	console.log('${bottles} bottles of beer on the wall');
}


// Switch Statement
switch (price){
	case price < 20:
		console.log("something 1");
		break;
	case price < 50:
		console.log("something 2")
		break;
	default:
		console.log("something 3")

}

