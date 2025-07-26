a = int(input("Enter first integer: "))
b = int(input("Enter second integer: "))
c = int(input("Enter third integer: "))
if a == b or b == c or a == c:
    total = 0
else:
    total = a + b + c

print(f"The result is: {total}")