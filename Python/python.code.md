> Pyhton file input with EOF

````python
  while True:
      try:
          n = input()
      except EOFError:
          break
````
> Index print of list using enumerate

````python
  list = ['a','b','c']
  for index, i in enumerate(list):
      print(index)
````
