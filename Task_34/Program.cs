// Задача 34: Задайте массив заполненный случайными положительными
// трёхзначными числами. Напишите программу, которая покажет количество
// чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int ShowEvenNumber(int[] array)
{
    int numberOfEvenNumbers = 0;
    int remainderOfTheDivision = 0;
    for (int i = 0; i < array.Length; i++)
    {
        remainderOfTheDivision = array[i] % 2;
        if (remainderOfTheDivision == 0)
        {
            numberOfEvenNumbers++;
        }
    }
    return numberOfEvenNumbers;
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

int[] array = GenerateRandomArray(10, 100, 999);
Console.Write($"[{String.Join(", ", array)}]");
int numberOfEvenNumbers = ShowEvenNumber(array);
Console.Write($" -> {numberOfEvenNumbers}");
