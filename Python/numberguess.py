import random
num = random.randint(0, 20)
print(num)
i = 0
while i < 3:
    guess = int(input("Guess the number"))
    if guess == num:
        print("You Guess it ")
        break
    elif guess > num:
        print("Your guess is Greator")
        i += 1

    elif guess < num:
        print("Your guess is Less")
        i += 1
