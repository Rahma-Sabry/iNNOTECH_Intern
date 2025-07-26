n = int(input("Enter a positive integer: "))

for i in range(1, n + 1):
    total = 0
    for j in range(1, i + 1):
        print(j, end="")
        total += j
        if j < i:
            print(" + ", end="")
    print(f" = {total}")