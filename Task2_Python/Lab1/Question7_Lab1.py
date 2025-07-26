# Get the upper limit from user
n = int(input("Enter the value of n: "))

print(f"Even numbers from 1 to {n}:")

for i in range(2, n + 1, 2):
    print(i, end=" ")