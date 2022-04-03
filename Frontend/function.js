// conditional statement we are using
//1. if else 2.if else elseif

//if else example
var a = 25;
var b = 30;
var c = 10;
if (a < b) {
  console.log("hello a your less than b" + a);
} else {
  console.log("hello a your less than a" + b);
}
// if elseif and else example
if (a > b) {
  console.log("hello a your less than b" + a);
} else if (a > c) {
  console.log("hello c your less than b" + b);
} else {
  console.log("hello b your greater than b" + a);
}

// looping statement
// 1. for loop
let num = 10;
var text5 = "";
for (let i = 0; i < num; i++) {
  text5 += i;
}
console.log(text5);

// 2. while loop
var j = "";
var i = "";
while (i < 10) {
  j += "The number is " + i;
  i++;
}
console.log(j);

// do while loop

//functions in js
// arrow function with parameter
var hello = (name) => {
  console.log("arrow function" + name);
};
hello("sanju");

// arrow function with muli parameter

var hello = (name1, age) => {
  console.log("arrow123" + name1, age);
};
var h = hello("sanju123", 12);
console.log(h);

//events in js
// 1.click 2.onclick 3.mouseover 4.mouseout 5.mousedown 6.mouseup
function clickme() {
  alert("you clicked the button");
}

//confirm and prompt boxes
function myFunction() {
  confirm("Press a button!");
}

// data structure in js

var letters = [];
var word = "racecar";

var rword = "";
// putting word in letters order
for (var i = 0; i < word.length; i++) {
  letters.push(word[i]);
  console.log(letters);
}
console.log(letters, "data");
//pop off the stack in reverse order
for (var i = 0; i < word.length; i++) {
  rword += letters.pop();
  console.log(rword);
}
console.log(rword, "deleting last index and adding rword");

if (rword === word) {
  console.log("word is palindrome ");
} else {
  console.log("word is not a palindrome ");
}

var stack=function(){
    this.count=0;
    this.storage={};

    //adds a value into the ends of the stack
    this.push=function(value){
        this.storage[this.count]=value;
        this.count++;
    }
    console.log(this.storage[this.count],'counted')
   //removes and returns the values at the end of the stack
   this.pop=function(){
    
       if(this.count===0){
           return undefined;
       }
       
       this.count--; //1 
       var result=this.storage[this.count];
       delete this.storage[this.count];
       return result; //1
      
   }
   this.size=function(){
       return this.count;
   }
   this.peek=function(value){
       return this.storage[this.count-1];
   }
}

var mystack=new stack();
mystack.push(1);
mystack.push(2);


console.log(mystack.peek())//2
console.log(mystack.pop())//2
console.log(mystack.peek(),'peek')//1

