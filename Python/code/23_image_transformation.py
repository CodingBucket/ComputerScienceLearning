from PIL import Image

img = Image.open("130.jpg")
sqaure_img = img.resize((100,100))
flip_img = img.transpose(Image.FLIP_LEFT_RIGHT)
spin_img = img.transpose(Image.ROTATE_90)

img.show()
sqaure_img.show()
flip_img.show()
spin_img.show()