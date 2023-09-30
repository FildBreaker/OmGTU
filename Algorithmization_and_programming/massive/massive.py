import time 
# Функция для определения суммы цифр числа
def sum_of_digits(num):
    return sum(int(digit) for digit in str(abs(num)))

# Ввод числа n
n = int(input("Введите число n: "))

# Инициализация массива для хранения элементов
numbers = []

# Цикл для ввода элементов
for _ in range(n):
    num = int(input("Введите число: "))
    numbers.append(num)

# Инициализация переменных
max_even = float('-inf')  # Максимальное значение среди четных чисел
count_with_5 = 0  # Количество чисел, содержащих цифру "5"
min_sum_digits = float('inf')  # Минимальная сумма цифр числа

# Цикл для обработки элементов массива
for num in numbers:
    # Проверка на четность
    if num % 2 == 0:
        if num > max_even:
            max_even = num  # Обновляем максимальное значение

    # Проверка на наличие цифры "5"
    has_5 = False  # Флаг для отслеживания наличия цифры "5" в числе
    current_num = abs(num)  # Получаем модуль числа для итерации по цифрам
    while current_num > 0:
        if current_num % 10 == 5:
            has_5 = True
            break
        current_num //= 10

    if has_5:
        count_with_5 += 1  # Увеличиваем счетчик

    # Проверка на минимальную сумму цифр
    if sum_of_digits(num) < min_sum_digits:
        min_sum_digits = sum_of_digits(num)  # Обновляем минимальную сумму

# Вывод результатов
print("Максимальное среди четных чисел:", max_even)
print("Количество чисел с цифрой 5:", count_with_5)
print("Элемент с наименьшей суммой цифр (по модулю):", min_sum_digits)

input("")
