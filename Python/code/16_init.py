# Class and object
class Enemy:
    life = 5

    def __init__(self):
        print("In eneny class")

    def attack(self):
        print("One life gone")
        self.life -= 1
        print("life left" + str(self.life))

enemy1 = Enemy()
enemy1.attack()
