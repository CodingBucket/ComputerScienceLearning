from PIL import Image

image = Image.open("130.jpg")
print(image.size)
print(image.format)

image.show()