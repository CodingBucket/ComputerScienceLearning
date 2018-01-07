from PIL import Image

img = Image.open("130.jpg")
area = (50,50,100,150)
cropped_img = img.crop(area)

cropped_img.show()