// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76


(double minValue, double maxValue) FindMinMax(double[] array)
{
    double minValue = array[0];
    double maxValue = array[0];

    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < minValue)
        {
            minValue = array[i];
        }

        if (array[i] > maxValue)
        {
            maxValue = array[i];
        }
    }

    return (minValue, maxValue);
}

double[] GenerateRandomArray(int size, double minValue, double maxValue)
{
    double[] array = new double[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().NextDouble() * (maxValue - minValue) + minValue;
    }
    return array;
}

double[] array = GenerateRandomArray(10, -100, 100);
Console.Write($"[{String.Join(", ", array.Select(x => x.ToString("F2"))) }]");

(double minValue, double maxValue) = FindMinMax(array);
double differenceMaxAndMin = maxValue - minValue;

Console.Write($" => {maxValue:F2} - {minValue:F2} = {differenceMaxAndMin:F2}");
