// Выводим третье число с конца или сообщаем, что его нет

Console.WriteLine("Enter a number");
int n = int.Parse(Console.ReadLine()!);

if (n >= 100)
{
    Console.WriteLine(n / 100);
}
else
{
    Console.WriteLine("There are no three digits in this number");
}    