import os

def rename_files():
    # get file names from a folder
    file_list = os.listdir(r"C:\Images")
    saved_path = os.getcwd()
    print("Current working directory is" + saved_path)
    os.chdir(r"C:\Images")

    # rename each file
    for file_name in file_list:
        print("Old name - " + file_name)
        print("New name - " + file_name.translate(None, "0123456789"))
        os.rename(file_name, file_name.translate(None, "0123456789"))
    os.chdir(saved_path)

rename_files()
