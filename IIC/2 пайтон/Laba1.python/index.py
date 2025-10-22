import math

x=float(input("Введіть значення x:"))

if x == 0:
    print("Помилка: x не може бути рівним 0")
elif x < 0:
    print("Помилка: x не може бути від'ємним")
else:
    y=(math.exp(-x) - 4*x - math.log(x)**3 )/ ( math.log10(abs(x + 1)) + 1 / math.tan(x**2 - 1) )

print("Результат:",y)