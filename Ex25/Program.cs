// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
try
{
    int Pow(int a, int b)
    {
        int res = 1;
        for (int i = 1; i <= b;i++) res = res * a;
        return res;
    }
    Console.Write("Введите целое число 1:");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите целое число 2:");
    int b = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Число {a} в степени {b} равно {Pow(a,b)}.");
}
catch
{
    Console.WriteLine ($"Ошибка! Введите целое число.");
}