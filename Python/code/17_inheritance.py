class Parent():

    def print_first_name(self):
        print("First name")

class Child(Parent):

    def print_last_name(self):
        print("Last name")

name = Child()
name.print_first_name()
name.print_last_name()