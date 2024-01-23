
// Напишите программу, которая на вход принимает два числа
// и проверяет, является ли одно число квадратом второго

Console.Write("Enter the first number: ");
int b1 = int.Parse(Console.ReadLine()!);
Console.Write("Enter the second number: ");
int b2 = int.Parse(Console.ReadLine()!);
if (b1 * b1 == b2) 
    Console.WriteLine("Yes");
else 
    Console.WriteLine("No"); 
    // Первая задача выполнена
