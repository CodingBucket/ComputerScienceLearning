function Mammal(name){
	this.name = name;
	this.getInfo = function(){
		return "This mammal name is" + this.name; 
	}
}

Mammal.prototype.sound = "Grrrr";

Mammal.prototype.makeSound = function(){
	return this.name + " says " + this.sound;
}

var grover = new Mammal('Grover');

document.write(grover.makeSound());