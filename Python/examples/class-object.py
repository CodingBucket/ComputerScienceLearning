class Movie:

    def __init__(self, name, description):
        self.name = name
        self.description = description

    def display_employee(self):
        print("Name : ", self.name)
        print("Description: ", self.description)


emp1 = Movie("hasan", "asda")
print(emp1.name)
emp1.display_employee()
