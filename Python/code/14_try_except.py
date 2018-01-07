while True:
    try:
        number = int(input("What is your fab number\n"))
        print(10/number)
        break
    except ValueError:
        print("Please enter a number")
    except ZeroDivisionError:
        print("Please dont enter zero")
    except:
        break
    finally:
        print("Loop Completed")


