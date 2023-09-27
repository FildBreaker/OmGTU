import os

# Создание папки "results", если она не существует
if not os.path.exists("results"):
    os.makedirs("results")

for i in range(1, 11):
    input_filename = f"data\\input{i}.txt"
    output_filename = f"results\\output{i}.txt"  # Файлы помещаются в папку "results"

    with open(output_filename, "w") as output_file:
        data = []

        with open(input_filename, "rt") as input_file:
            n = int(input_file.readline())  # Читаем количество фирм из файла

            min_price = float(
                "inf"
            )  # Инициализируем минимальную цену как положительную бесконечность
            firm = 0  # Переменная для хранения номера фирмы с минимальной ценой

            # Читаем данные для каждой фирмы и рассчитываем цену на молоко
            for j in range(n):
                # Читаем значения параметров фирмы из файла и присваиваем значения переменным
                x1, y1, z1, x2, y2, z2, p1, p2 = [
                    float(value) for value in input_file.readline().split()
                ]

                # Расчет объема и площади первого и второго сосудов
                v1 = x1 * y1 * z1
                s1 = 2 * x1 * y1 + 2 * y1 * z1 + 2 * z1 * x1

                v2 = x2 * y2 * z2
                s2 = 2 * x2 * y2 + 2 * y2 * z2 + 2 * z2 * x2

                # Рассчитываем цену на молоко для текущей фирмы
                milk_price = (p2 * s1 - p1 * s2) / (v2 * s1 - v1 * s2)

                # Если цена на молоко меньше текущей минимальной цены, обновляем значения минимальной цены и номера фирмы
                if milk_price < min_price:
                    min_price = milk_price
                    firm = j + 1

            min_price = round(
                min_price * 1000, 2
            )  # Переводим минимальную цену в тысячи и округляем до двух знаков после запятой

            output_file.write(
                f"{firm} {min_price}\n"
            )  # Записываем результаты в файл вывода
