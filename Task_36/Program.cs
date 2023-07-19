// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int FindSumOfElementsInOddPosition(int[] array)
{
    int sumOfOddNumbers = 0;
    for (int i = 0; i < array.Length; i = i + 2)
    {
        sumOfOddNumbers += array[i];
    }
    return sumOfOddNumbers;
}

int[] GenerateRandomArray(int size, int start, int finish)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(start, finish + 1);
    }
    return array;
}

int[] array = GenerateRandomArray(2, -100, 100);
Console.Write($"[{String.Join(", ", array)}]");
int sumOfOddNumbers = FindSumOfElementsInOddPosition(array);
Console.Write($" -> {sumOfOddNumbers}");