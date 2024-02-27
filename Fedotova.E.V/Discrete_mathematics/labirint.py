# Функция для чтения входных данных от пользователя
def read_input():
    while True:
        try:
            # Ввод размеров таблицы
            n, m = map(int, input("Введите размеры таблицы (n и m): ").split())
            
            # Ввод карты зараженности местности
            print("Введите карту зараженности местности:")
            matrix = [list(map(int, input().split())) for _ in range(n)]
            
            # Проверка условий
            if 1 <= n <= 30 and 1 <= m <= 30:
                return n, m, matrix
            else:
                print("Неправильные данные. Повторите ввод.")
        except ValueError:
            print("Неправильные данные. Повторите ввод.")

# Функция для решения задачи с использованием динамического программирования
def solve(n, m, matrix):
    # Создание матрицы dp для хранения суммарной дозы радиации
    dp = [[0] * m for _ in range(n)]
    
    # Заполнение первой строки и первого столбца матрицы dp
    dp[0][0] = matrix[0][0]
    for i in range(1, n):
        dp[i][0] = dp[i-1][0] + matrix[i][0]
    for j in range(1, m):
        dp[0][j] = dp[0][j-1] + matrix[0][j]
    
    # Вычисление суммарной дозы радиации для каждой клетки матрицы dp
    for i in range(1, n):
        for j in range(1, m):
            dp[i][j] = matrix[i][j] + min(dp[i-1][j], dp[i][j-1])
    
    # Возвращение суммарной дозы радиации в правой нижней клетке
    return dp[n-1][m-1]

# Основная функция программы
def main():
    # Чтение входных данных
    n, m, matrix = read_input()
    
    # Решение задачи
    result = solve(n, m, matrix)
    
    # Вывод результата
    print("Суммарная доза радиации:", result)

# Вызов основной функции программы
if __name__ == "__main__":
    main()
