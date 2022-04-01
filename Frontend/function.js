
// conditional statement we are using
//1. if else 2.if else elseif

//if else example
var a=25;
var b=30;
var c=10;
if(a<b){
    console.log('hello a your less than b' + a)
} else{
    console.log('hello a your less than a' + b)
}
// if elseif and else example
if(a>b){
    console.log('hello a your less than b' + a)
}else if(a>c){
    console.log('hello c your less than b' + b)
}
else{
    console.log('hello b your greater than b' + a)
}

// looping statement
// 1. for loop
let num = 10
var text5= ""
for (let i = 0; i < num; i++) {
  text5 +=  i ;
}
console.log(text5)

// 2. while loop 
var j=""
var i=""
while ( i < 10) {
    j += "The number is " + i;
    i++;
  }
  console.log(j)

// do while loop

//functions in js
// arrow function with parameter
var hello = (name) =>{
    console.log('arrow function' +name)
}
hello('sanju');

// arrow function with muli parameter

var hello = (name1,age) =>{
    
    console.log ("arrow123"+ name1,age)
   
}
var h=hello('sanju123',12);
console.log(h)

