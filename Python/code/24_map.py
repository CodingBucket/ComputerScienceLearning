income = [10, 20, 30]

def double_money(dollers):
    return dollers * 2

new_income = list(map(double_money, income))
print(new_income)