
// proto type in js
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

//class example in js

class person{
    constructor(name){
        this.name=name
    }
    // creating methods in js
    greet(){
        console.log(`hi good morning ${this.name} `)
    }
}
var person1=new person("priya");
console.log(person1.name)
console.log(person1.greet())

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