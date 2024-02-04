

Console.WriteLine("Введите первое число: ");
int x = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число: ");
int y = int.Parse(Console.ReadLine()!);

if (x < 0 && y > 0)
{
    Console.WriteLine("Точка находится в четверти N2");
}
else
{
    if (x < 0 && y < 0)
    {
        Console.WriteLine("Точка находится в четверти N3");
    }
    else
    {
        if (x > 0 && y < 0)
        {
            Console.WriteLine("Точка находится в четверти N4");
        }
        else
        {
            if (x > 0 && y > 0)
                Console.WriteLine("Точка находится в четверти N1");
        }
    }
}