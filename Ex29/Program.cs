// Задача 29: Напишите программу, которая задаёт массив из 8 элементов с клавиатуры и выводит массив на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
try
{
int[] array = new int[8];
void FillArray(int[] collection)
{
    int length = array.Length;
    int index = 0;
    while (index < length)
    {
        Console.Write($"Введите целое число {index + 1} для заполнения массива из 8 элементов: ");
        collection[index] = Convert.ToInt32(Console.ReadLine());
        index++;
    }
}
void PrintArray(int[] array)
{
    int count = 8;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
FillArray(array);
PrintArray(array);
}
catch
{
    Console.WriteLine ($"Ошибка! Введите целое число.");
}