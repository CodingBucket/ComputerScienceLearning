fw = open('sample.txt','w')
fw.write('Write first line\n')
fw.write('Write second line\n')
fw.close()

fr = open('sample.txt','r')
text = fr.read()
print(text)
fr.close()