for i in range(1, 11):
    input_filename = f"data\\input{i}.txt"
    output_filename = f"data\\output{i}.txt"

    data = []

    with open(input_filename, "rt") as f:
        n = int(f.readline())

        min_price = float("inf")
        firm = 0

        for i in range(n):
            x1, y1, z1, x2, y2, z2, p1, p2 = [float(i) for i in f.readline().split()]

            v1 = x1 * y1 * z1
            s1 = 2 * x1 * y1 + 2 * y1 * z1 + 2 * z1 * x1

            v2 = x2 * y2 * z2
            s2 = 2 * x2 * y2 + 2 * y2 * z2 + 2 * z2 * x2

            milk_price = (p2 * s1 - p1 * s2) / (v2 * s1 - v1 * s2)

            if milk_price < min_price:
                min_price = milk_price
                firm = i + 1

    min_price = round(min_price * 1000, 2)

    with open(output_filename, "w") as file:
        file.write(f"{firm} {min_price}\n")
