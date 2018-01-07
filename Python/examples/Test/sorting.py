import pprint
from operator import itemgetter

aList = [
    [1, 'http://stackoverflow.com', 'stack', 2],
    [2, 'http://stackoverflow.com', 'stack Overflow', 4]]

#a = sorted(aList, key=itemgetter(3))
aList.sort(key=itemgetter(3), reverse=True)

pprint.pprint(aList)
#pprint.pprint(a)