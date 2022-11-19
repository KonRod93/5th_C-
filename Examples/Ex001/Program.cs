// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.WriteLine("Введите размер массива");
int Length = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение массива");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение массива");
int max = Convert.ToInt32(Console.ReadLine());
int[] Array = GetArray(Length, min, max);
Console.WriteLine($"[{string.Join(", ", Array)}]");
FindEven(Array);

int[] GetArray(int Length, int minValue, int maxValue)
{
    Random rnd = new Random();
    int number = rnd.Next(100, 999);
    int[] result = new int[Length];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = rnd.Next(minValue, maxValue + 1);
    }
    return result;
}

void FindEven(int[] MyArray)
{
    int even = 0;
    for (int i = 0; i < MyArray.Length; i++)
    {
        if (MyArray[i] % 2 == 0)
            even = even + 1;
    }
    Console.WriteLine($"Количество четных чисел {even}");
}