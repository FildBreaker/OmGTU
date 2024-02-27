# Класс кабинет, который содержит информацию о кабинете
class Cabinet:
    def __init__(self, number, seats, projector, computers):
        self.number = number                # номер кабинета
        self.seats = seats                  # количество посадочных мест
        self.projector = projector          # наличие проектора
        self.computers = computers          # наличие компьютеров


# Класс меню, где реализованы функции
class Menu:
    def __init__(self):
        self.database = None     # база данных для хранения кабинетов

    # Функция создания базы данных
    def create_database(self):
        self.database = []

    # Функция добавления кабинета в базу данных
    def add_cabinet(self):
        if self.database is None:
            print("База данных не создана")
            return

        number = input("Введите номер кабинета: ")
        if not number.isdigit() or int(number) > 999:
            print("Неправильный формат номера кабинета")
            return

        seats = input("Введите количество посадочных мест: ")
        if not seats.isdigit():
            print("Неправильный формат количества посадочных мест")
            return

        projector = input("Наличие проектора (yes/no): ")
        if projector.lower() != "yes" and projector.lower() != "no":
            print("Неправильный формат наличия проектора")
            return

        computers = input("Наличие компьютеров (yes/no): ")
        if computers.lower() != "yes" and computers.lower() != "no":
            print("Неправильный формат наличия компьютеров")
            return

        cabinet = Cabinet(number, int(seats), projector.lower() == "yes", computers.lower() == "yes")
        self.database.append(cabinet)
        print("Кабинет успешно добавлен в базу данных")

    # Функция модификации кабинета по номеру
    def modify_cabinet(self):
        if self.database is None:
            print("База данных не создана")
            return

        number = input("Введите номер кабинета, который нужно изменить: ")
        if not number.isdigit() or int(number) > 999:
            print("Неправильный формат номера кабинета")
            return

        for cabinet in self.database:
            if cabinet.number == number:
                seats = input("Введите новое количество посадочных мест: ")
                if not seats.isdigit():
                    print("Неправильный формат количества посадочных мест")
                    return
                cabinet.seats = int(seats)

                projector = input("Наличие проектора (yes/no): ")
                if projector.lower() != "yes" and projector.lower() != "no":
                    print("Неправильный формат наличия проектора")
                    return
                cabinet.projector = projector.lower() == "yes"

                computers = input("Наличие компьютеров (yes/no): ")
                if computers.lower() != "yes" and computers.lower() != "no":
                    print("Неправильный формат наличия компьютеров")
                    return
                cabinet.computers = computers.lower() == "yes"

                print("Кабинет успешно изменен")
                return

        print("Кабинет с таким номером не найден")

    # Функция выборки кабинетов с количеством посадочных мест, превышающим или равным заданному
    def filter_by_seats(self):
        if self.database is None:
            print("База данных не создана")
            return

        seats = input("Введите количество посадочных мест: ")
        if not seats.isdigit():
            print("Неправильный формат количества посадочных мест")
            return

        filtered_cabinets = [cabinet for cabinet in self.database if cabinet.seats >= int(seats)]

        print("Результаты выборки:")
        for cabinet in filtered_cabinets:
            print(f"Номер кабинета: {cabinet.number}")
            print(f"Количество посадочных мест: {cabinet.seats}")
            print(f"Наличие проектора: {'Да' if cabinet.projector else 'Нет'}")
            print(f"Наличие компьютеров: {'Да' if cabinet.computers else 'Нет'}")

    # Функция выборки кабинетов с проектором
    def filter_by_projector(self):
        if self.database is None:
            print("База данных не создана")
            return

        projector_cabinets = [cabinet.number for cabinet in self.database if cabinet.projector]

        print("Результаты выборки:")
        if projector_cabinets:
            print(", ".join(projector_cabinets))
        else:
            print("Кабинеты с проектором не найдены")

    # Функция выборки кабинетов с компьютером
    def filter_by_computers(self):
        if self.database is None:
            print("База данных не создана")
            return

        computer_cabinets = [cabinet.number for cabinet in self.database if cabinet.computers]

        print("Результаты выборки:")
        if computer_cabinets:
            print(", ".join(computer_cabinets))
        else:
            print("Кабинеты с компьютерами не найдены")

    # Функция вывода всей информации
    def display_all(self):
        if self.database is None:
            print("База данных не создана")
            return

        if not self.database:
            print("База данных пуста")
            return

        sorted_cabinets = sorted(self.database, key=lambda cabinet: cabinet.number)

        print("Информация по всем кабинетам:")
        for cabinet in sorted_cabinets:
            print(f"Номер кабинета: {cabinet.number}")
            print(f"Количество посадочных мест: {cabinet.seats}")
            print(f"Наличие проектора: {'Да' if cabinet.projector else 'Нет'}")
            print(f"Наличие компьютеров: {'Да' if cabinet.computers else 'Нет'}")
            print()

    # Функция выборки кабинетов на конкретном этаже
    def filter_by_floor(self):
        if self.database is None:
            print("База данных не создана")
            return

        floor = input("Введите номер этажа: ")
        if not floor.isdigit():
            print("Неправильный формат номера этажа")
            return

        floor_cabinets = [cabinet.number for cabinet in self.database if cabinet.number[0] == floor]

        print("Результаты выборки:")
        if floor_cabinets:
            print(", ".join(floor_cabinets))
        else:
            print("Кабинеты на данном этаже не найдены")

    # Функция удаления кабинета
    def remove_cabinet(self):
        if self.database is None:
            print("База данных не создана")
            return

        number = input("Введите номер кабинета, который нужно удалить: ")
        if not number.isdigit() or int(number) > 999:
            print("Неправильный формат номера кабинета")
            return

        for cabinet in self.database:
            if cabinet.number == number:
                self.database.remove(cabinet)
                print("Кабинет успешно удален")
                return

        print("Кабинет с таким номером не найден")

    # Функция вывода меню
    def display_menu(self):
        while True:
            print("Меню:")
            print("1. Создать базу данных")
            print("2. Добавить кабинет в базу данных")
            print("3. Изменить кабинет по номеру")
            print("4. Выборка кабинетов по количеству посадочных мест")
            print("5. Выборка кабинетов с проектором")
            print("6. Выборка кабинетов с компьютером")
            print("7. Вывести всю информацию")
            print("8. Выборка кабинетов на конкретном этаже")
            print("9. Удалить кабинет из базы данных")
            print("10. Выйти")

            choice = input("Введите номер функции: ")
            if choice == "1":
                self.create_database()
            elif choice == "2":
                self.add_cabinet()
            elif choice == "3":
                self.modify_cabinet()
            elif choice == "4":
                self.filter_by_seats()
            elif choice == "5":
                self.filter_by_projector()
            elif choice == "6":
                self.filter_by_computers()
            elif choice == "7":
                self.display_all()
            elif choice == "8":
                self.filter_by_floor()
            elif choice == "9":
                self.remove_cabinet()
            elif choice == "10":
                break
            else:
                print("Неправильный выбор")


# Создание экземпляра меню и запуск программы
if __name__ == "__main__":
    menu = Menu()
    menu.display_menu()