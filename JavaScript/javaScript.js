/* Create an empty object */
var obj = new Object();

/* Another way to create empty object */
var obj = {}

/* JSON object */
var obj = {
	firstName: "Hasan",
	lastName: "Khan",
	age: 26,
	"for": "Max",
	detail: {
		color: "Blue",
		size: 22
	}
}

/* 
----------------------------
 # JSON object data access 
----------------------------
 */
obj.detail.color            // Blue
obj['detail']['size']       // 22 

/* 
--------------------------------------------------------
 # Create object prototype & instance of that prototype 
--------------------------------------------------------
*/
function Persion(name, age){  // Persion is the object prototype
    this.firstName = name;
    this.lastName = name;
    this.age = age;
    this.eyeColor = eyecolor;
    this.name = function() {
    	return this.firstName + " " + this.lastName;
    };
}

// Define an object, var you is the instance of the Persion prototype.
var you = new Persion('Khan', 26);  
you.firstName  // Khan
you.age        // 26
