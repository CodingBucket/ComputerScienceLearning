````python
  n_list = []
  first = True
  while True:
      try:
          n = input()
      except EOFError:
          break
      if n:
          output = ''
          for i in n:
              if i == '"' and first is True:
                  i = '``'
                  first = False
              elif i == '"' and first is False:
                  i = "''"
                  first = True
              output += i
          n_list.append(output)
      else:
          break

  result = ''
  list_len = len(n_list)
  for index, i in enumerate(n_list):
      if index == list_len-1:
          result += i
      else:
          result += i + "\n"
  print(result)
````
