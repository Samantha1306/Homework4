// Задача 30: - HARD необязательная Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.. 
// Далее надо посчитать количество нулей и единиц, если единиц больше чем нулей то вывести TRUE на экран, иначе вывести False.

int[] array = new int[8];
void FillArray(int[] collection)
{
    int length = array.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(0,2);
        index++;
    }
}
void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
FillArray(array);
PrintArray(array);

int num1 = 0;
int count = 8;
for (int i = 0; i < count; i++)
{
    if (array [i] == 1) num1 = num1 + 1;
}
int num2 = count - num1;
bool x = num1 > num2;
Console.WriteLine($"Количество нулей в массиве: {num2}");
Console.WriteLine($"Количество единиц в массиве: {num1}");
Console.WriteLine(x);