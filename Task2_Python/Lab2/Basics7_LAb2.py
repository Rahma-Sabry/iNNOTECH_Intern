num = int(input("Enter number: "))
range_number = ((num - 1) // 10) + 1 if num != 0 else 1
print(f"{num} belongs to Range from {range_number*10-9} to {range_number*10}")
