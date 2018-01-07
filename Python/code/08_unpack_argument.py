# Unpack argument
def calculate(first, second, third):
    total = first + second + third
    print(total)

argArray = [1,2,3]
calculate(argArray[0],argArray[1],argArray[2])
calculate(*argArray)
