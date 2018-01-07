class Parent:

    def __init__(self, last_name, eye_color):
        print("Parent constructor called")
        self.last_name = last_name
        self.eye_color = eye_color


class Child(Parent):

    def __init__(self, last_name, eye_color, toys):
        print("Child constructor called")
        Parent.__init__(self, last_name, eye_color)
        self.toys = toys


hasan = Child("Khan", "Black", "Mac")
print(hasan.last_name)
print(hasan.toys)
