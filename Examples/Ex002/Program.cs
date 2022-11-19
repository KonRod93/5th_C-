// Задача 36:Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.WriteLine("Введите размер массива");
int Length = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение массива");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение массива");
int max = Convert.ToInt32(Console.ReadLine());
int[] Array = GetArray(Length, min, max);
Console.WriteLine($"[{string.Join(", ", Array)}]");
FindSum(Array);

int[] GetArray(int Length, int minValue, int maxValue)
{
    Random rnd = new Random();
    int[] result = new int[Length];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = rnd.Next(minValue, maxValue + 1);
    }
    return result;
}

void FindSum(int[] MyArray)
{
    int sum = 0;
    for (int i = 1; i < MyArray.Length; i = i + 2)
    {
        sum = sum + MyArray[i];
    }
    Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях {sum}");
}