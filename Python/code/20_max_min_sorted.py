stocks = {
    'GooG' : 55,
    'FB' : 44,
    'Apple' : 33,
    'yahoo' : 22
}

print(max(zip(stocks.values(),stocks.keys())))
print(min(zip(stocks.values(),stocks.keys())))
print(sorted(zip(stocks.values(),stocks.keys())))
