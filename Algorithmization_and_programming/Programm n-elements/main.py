def count_sign_changes(nums):
    count = 0
    for i in range(1, len(nums)):
        if nums[i] * nums[i-1] < 0:
            count += 1
    return count

def count_elements_less_than_neighbors(nums):
    count = 0
    for i in range(1, len(nums)-1):
        if nums[i] < nums[i-1] and nums[i] < nums[i+1]:
            count += 1
    return count

def max_sequence_length(nums):
    max_length = 1
    current_length = 1
    for i in range(1, len(nums)):
        if nums[i] == nums[i-1]:
            current_length += 1
        else:
            current_length = 1
        max_length = max(max_length, current_length)
    return max_length

def min_negative_subsequence(nums):
    if not any(num < 0 for num in nums):
        print("Нет отрицательных элементов в последовательности")
        return

    min_length = float('inf')
    current_length = 0
    for num in nums:
        if num < 0:
            current_length += 1
        else:
            current_length = 0
        min_length = min(min_length, current_length)

    print("Минимальный размер подпоследовательности из отрицательных элементов:", min_length)

n = int(input("Введите количество элементов: "))
nums = []
for i in range(n):
    element = int(input("Введите элемент " + str(i+1) + ": "))
    nums.append(element)

result1 = count_sign_changes(nums)
print("Количество смены знака:", result1)

result2 = count_elements_less_than_neighbors(nums)
print("Количество элементов, значение которых меньше соседа слева и справа:", result2)

result3 = max_sequence_length(nums)
print("Максимальный размер последовательности из одинаковых элементов:", result3)

min_negative_subsequence(nums)