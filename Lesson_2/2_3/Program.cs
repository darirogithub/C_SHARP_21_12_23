// вводим два числа, делятся ли они без остатка? Если нет, то выводим остаток

Console.WriteLine("Enter the first digit");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter the secind digit");
int m = int.Parse(Console.ReadLine()!);

if (n % m == 0)
    Console.WriteLine("Yes");

else 
    Console.WriteLine("No " + n % m);