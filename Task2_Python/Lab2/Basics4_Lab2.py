hours_worked = float(input("Enter number of hours worked: "))
hourly_rate = float(input("Enter hourly pay rate: "))
gross_pay = hours_worked * hourly_rate
tax = 0.20 * gross_pay
net_pay = gross_pay - tax
print(f"\nGross Pay: ${gross_pay:.2f}")
print(f"Tax Deducted (20%): ${tax:.2f}")
print(f"Net Pay: ${net_pay:.2f}")