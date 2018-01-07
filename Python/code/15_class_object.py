# Class and object
class Enemy:
    life = 5

    def attack(self):
        print("One life gone")
        self.life -= 1

    def checkLife(self):
        if self.life <= 0:
            print("You are dead")
        else:
            print(str(self.life) + "life left")


enemy1 = Enemy()

enemy1.attack()
enemy1.checkLife()