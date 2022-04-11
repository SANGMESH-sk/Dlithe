
// javascript objects and properties
const employee=
{
    empid:100,
    empname:"John",
    designation:"HR"
}
document.write(employee.empid+"<br>");
document.write(employee.empname+"<br>");
document.write(employee.designation+"<br>");

var details="";
for (var emp in employee)
{
    details+=employee[emp]+"<br> ";
}
document.write(details+"<br>", "details coming");

//Adding a property to an existing object
employee.Salary=45000;
var details="";
for (var emp in employee)
{
    details+=employee[emp]+"<br> ";
}
document.write(details+"<br>");

//delete a property
delete employee.designation;
var details="";
for (var emp in employee)
{
    details+=employee[emp]+"<br> ";
}
document.write(details+"<br>");

//Nested Objects
const Course=
{
    courseid:100,
    coursename:"WebUI",
    //Nested Object
        coursedetails:
        {
            coursedetail1:"HTML",
            coursedetail2:"CSS",
            coursedetail3:"BOOTSTRAP",
            coursedetail4:"JS"
        }

}
console.log(Course.courseid +"nested object");
//accessing nested object
console.log(Course.coursedetails.coursedetail1 +"nested obj1");
// document.write(Course.courseid+"<br>");


//Function in an object
const Web=
{
    course1:"HTML",
    course2:"CSS",
    course3:"JS",
    //this keyword used for accessing keys in the object
    GetCourses:function()
    {
        return this.course1+","+this.course2+","+this.course3+"<br>";    
    }
}
document.write("<hr>"+Web.GetCourses());

//Pass by reference in objects
//empname and emp1 share the same memory address
function GetName(empname)
{
    empname.employeename="Peter";
}
const emp1=
{
    employeename:"John"
};
document.write(emp1.employeename+"<br>");
GetName(emp1);
document.write(emp1.employeename+"<br>");

// prototype example 
// by using prototype we can crate element in function

function student(){
    this.name="ravi"
    this.gender="male"
}
student.prototype.age=25;
var stu=new student()
console.log(stu);

//1.class example in js

class person{
    constructor(name){
        this.name=name
    }
    // creating methods in js
    greet(){
        console.log(`hi good morning ${this.name} `)
    }
     add(a,b){
        return a+b;
    }
}
var person1=new person("priya");
console.log(person1.name)
console.log(person1.greet())
console.log(person1.add(34,5))

//2. inheritance example parent is person children is programmer
class programmer extends person{
    constructor(name,language){
    super(name);
    this.language=language;
    }
    lang(){
        if(this.language==""){
            return '.net'
        }
        else{
            return 'javascript'
        }
    }
    
}
var person2=new programmer("raj123"); 
console.log(person2.name) //raj 123
console.log(person2.lang()) //


 //3. encapsulation in js :- it is use for wrapping up data its having two methods getter and setter methods
// getter and setter method in js
class employee1 {
    constructor(name){
        this.name=name
    }
   // getter method
   get personName(){
       return this.name
   }
   //setter method for setting or new or changing name
   set personName(x){
       return this.name=x;
   }
}
var emp=new employee1("piri")
console.log(emp.name)
emp.personName="priya reddy"
console.log(emp.name)

// 4.polymorphism in javascript
// polymorphism means many forms  representing

class animal{
    constructor(name1){
        this.name1=name1
    }
    eats(){
        console.log(this.name1+'eats food')
    }
}
class alligator extends animal{
    eats(){                // overiding the eats method
        super.eats         // accessing eats from parent
        console.log(this.name1+'eats fishesh')
    }
}
let murphy=new alligator('murthy')
console.log(murphy.name1) //murthy
console.log(murphy.eats()) // murthy eats fishesh


//5.abstract in js
// Abstraction in js:- An abstraction is a way of hiding the implemention details
// and showing only the functionality to the user 
// to achieve action in a class we have to declare atleast one abstract method



//Creating a constructor function  
function Vehicle()  
{  
    this.vehicleName="vehicleName";  
    throw new Error("You cannot create an instance of Abstract Class");  
}  
Vehicle.prototype.display=function()  
{  
    return "Vehicle is: " + this.vehicleName;  
}  
//Creating a constructor function  
function Bike(vehicleName)  
{  
    this.vehicleName=vehicleName;  
}  
//Creating object without using the function constructor  
Bike.prototype=Object.create(Vehicle.prototype);  
var bike=new Bike("Honda");  
document.writeln(bike.display());  
  
  