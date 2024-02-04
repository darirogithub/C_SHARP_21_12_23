// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно
//23 и 7

Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine()!);
if (n % 7 == 0 && n % 23 == 0)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}