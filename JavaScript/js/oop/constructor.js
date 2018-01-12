function Persone(name, age){
	this.name = name;
	this.age = 23;

	this.info = function(){
		return "My name is" + this.name;
	}
}

var bob = new Persion('bob','20');
console.log(bob.info());