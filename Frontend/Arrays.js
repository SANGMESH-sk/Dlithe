// strings

var s="hello world"
var s2="good morning"
document.write(s+s2)
document.write(s2.length +"<br>");
let str = "Apple,Banana,Kiwi";

document.write(str.substring(2)+"substr");

let text = "Please visit Microsoft!";
let newText = text.replace("Microsoft", "Schools");
document.write(newText); // it will repace microsoft to schools

let x="lowercase" 
let y="uppercase" // toUppercase and toLowerCase
document.write(x.toUpperCase())

//concat method
var text1 = "Hello";
var text2 = "World!";
var text3 = text1.concat(" ",text2 );
document.write("concat",text3 +"<br>")

// trim method it use for removing white spaces
var trm1 = "   guru   bhai      ";
var trm2 = trm1.trim();
document.write(trm2);

// The charAt() method returns the character at a specified index (position) in a string:
let char1 = "HELLO WORLD";
let char = char1.charAt(6);

document.write(char +"<br>")
// index of method
var h="hello world";
document.write(h.indexOf("d")+"<br>")

//================ array method ===========
// array methods in js are 
// pop, push,shift,unshift,

var a=[1,2,3,4,5]
document.write(a)
var z=a.pop() // it will delete last index of value
document.write(a +"<br>")
a.push(7); // it will add the new array elememt

document.write(a+"<br>")
a.shift() // it will delete first index of array
document.write(a+"<br>")
a.unshift(7) // it will add elements in first index of array
document.write(a+"<br>")

//=== join method===
const fruits = ["Banana", "Orange", "Apple", "Mango"];
document.write(fruits.join("*"+"<br>")); // it will jion * with all the array values

// sort method
document.write(fruits.sort()+"<br>"); // it will sort the array value in a letter wise

// ==== splice method  ==== 
var f=fruits.splice(1); //splice method it is use for deleteing and adding it will 0 & 1 index 

document.write(f+"<br>");

const fruits1 = ["Banana", "Orange", "Apple", "Mango"];
var f=fruits1.splice(1,0,"green"); // it will add the element in 1 index
document.write(fruits1 +"<br>");
var f=fruits1.splice(1,3,"green"); //it will delete 2 & 3 index
document.write(fruits1 + "<br>");

// for loop for iterating array 
for(var i=0; i<fruits1.length; i++){

    document.write("<br>"+fruits1[i] +"<br>")
   
}
// by using using entries method we iterate index values
var entry=fruits1.entries();
// by using for loop we iterate array values
for(var elememt of entry){
    document.write(elememt +"iteration" +"   ")
}