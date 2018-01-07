# Flexible number of argument
def add_number(*args):
    total = 0
    for a in args:
        total = total + a
    print(total)

add_number(1)
add_number(1,2)
add_number(1,2,3)