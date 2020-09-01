// Create list
let teachers = ["John", "Mary"];

let teacher1 = "Shane";
let teacher2 = "Emma";

console.log(teachers);

// loop through list/array
teachers.forEach(teacher => console.log(teacher));

// Add items to list
teachers.push(teacher1);
teachers.push(teacher2);
teachers.unshift("Riah");
console.log(teachers); // print after adding Item
teachers.pop();

// Print stuff
console.log(teachers);
console.log("Length:", teachers.length);

// Index
console.log("Index:", teachers.indexOf("Mary"));

// Slicing
let listSlice = teachers.slice(1,3);
console.log("Slice:", listSlice);
console.log("String slice:", "Slice me into two".slice(1,8));
//let listSliceNreplace = teachers.slice(1,3, "Kofi", "Ama");
//console.log("Slice and Replace:", teachers);

// for loop for list
for (let pos= 0; pos < teachers.length; pos++){
    console.log("Looping tru array:", teachers[pos]);
}

// Changing to string, joining and spliting
teacherString = teachers.toString();
console.log("To string:", teacherString);
teacherSlipt = teacherString.split(',');
console.log("Split string:", teacherSlipt);
teacherJoin = teacherSlipt.join('|'); // join only list with multiple items
console.log("Join string:", teacherJoin);
splitJohn = teachers[1].toString().split('');
console.log("Split John:", splitJohn);

// Assign list items to vars
let [w,x,y,z] = teachers
console.log("w, x, y, z:", w, x, y, z);

let [k, ...rest] = teachers; // Using the rest attribute
console.log("rest:", rest); // print the rest of the items

// Challenge 1
let shoppingList = ['pop tarts', 'ramen noodle', 'chips', 'salsa', 'coffee'];
shoppingList.push('fruit loops');
console.log("Shopping list:", shoppingList);
shoppingList[4] = 'fair trade coffee';
shoppingList[2] = 'rice';
shoppingList[3] = 'beans';
console.log("Shopping list:", shoppingList);

// Adding stuff to the cart
let shoppingCart = [];
// last time to cart
shoppingCart.push(shoppingList.pop());
console.log("Shopping cart:", shoppingCart);
// first item to cart
shoppingCart.push(shoppingList[0]);
console.log("Shopping cart:", shoppingCart);
/* for loop
for (let pos= 0; pos < 4; pos++){
    shoppingCart.push(shoppingList.shift());
}*/
// while loop
while(shoppingList.length > 0){
    shoppingCart.push(shoppingList.shift());
}
console.log("Shopping cart:", shoppingCart);
// sort list
let sortCart = shoppingCart.sort();
console.log("Sort cart:", shoppingCart);
//Print items in list only not the array itself
let printCart = sortCart.toString();
console.log("Print cart:", printCart);

// Object in javascript, eg a dictionary
let course = {
    name: "Ama",
    awesome: true,
    courses: ["Math", "Physics", "Programming"],
    student: [
            {
                name: 'Steve',
                computer:{
                    OS: 'Linux',
                    type: 'laptop'
                }
            },
            {
                name: 'John',
                computer:{
                    OS: 'Linux',
                    type: 'Desktop'
                }
            }
    ]
} 

console.log("Dict:", course);

course.letter_grade = 'A'; //use . to access keys since dict is an object
console.log("Dict:", course);

console.log("Student name:", course.student[0].name);
console.log("Student computer's OS:", course.student[0].computer.OS);

// looping through objec
/*
for (let std of course.student){
    if(std.computer.OS === 'Linux'){
        console.log(std.name);
    }
}
*/

const object = { a: 1, b: 2, c: 3 };

for (const property in object) {
  console.log(`${property}: ${object[property]}`);
}

//Using filters


// Reference and bodies
let g = {name: 'Evan'};
let h = {name: 'Evan'};
console.log("Is g = h:", g === h);

j = g;
console.log("Is g = j:", g === j);

//students.find(name => name === 'name')   