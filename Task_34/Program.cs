// Задача 34: Задайте массив заполненный случайными положительными
// трёхзначными числами. Напишите программу, которая покажет количество
// чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

(int size, int start, int finish) AskArray ()
{
    Console.Write("Задайте размер одномерного массива: ");
    int size = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите значение начала массива: ");
    int start = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите значение конца массива: ");
    int finish = Convert.ToInt32(Console.ReadLine());
    if (start < 99 || start > 999 || finish < 99 || finish > 999)
    {
        Console.Write("Вы ввели неверное значение, должно быть 3-х значное число");
        Console.WriteLine(" ");
        AskArray();
    }
    return (size, start, finish);
}

int CountEvenNumber (int[] array)
{
    int numberOfEvenNumbers = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (0 == array[i] % 2)
        {
            numberOfEvenNumbers++;
        }
    }
    return numberOfEvenNumbers;
}

int[] GenerateRandomArray (int size, int start, int finish)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(start, finish + 1);
    }
    return array;
}

(int size, int start, int finish) = AskArray ();
int[] array = GenerateRandomArray (size, start, finish);
Console.Write($"[{String.Join(", ", array)}]");
int numberOfEvenNumbers = CountEvenNumber (array);
Console.Write($" -> {numberOfEvenNumbers}");
