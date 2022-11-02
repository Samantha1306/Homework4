// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. Через строку решать нельзя.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
try
{
int SumNumbers(int x)
{
    int sum = 0;
    while (x > 0)
    {
       int num = x % 10;
        x = x / 10;
        sum = sum + num;

    }
    
    return sum;
}
Console.WriteLine("Введите целое число");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Сумма всех цифр в числе {n} равна {SumNumbers(n)}.");
}
catch
{
    Console.WriteLine ($"Ошибка! Введите целое число.");
}
