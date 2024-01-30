// нужно написать прогрумму, которая будет из трёхзначного числа вычленять вторую цифру и 
// позводить в степень, равную последней цифре. 

Console.WriteLine("Введите трёхзначное число");
int num = int.Parse(Console.ReadLine()!);
if (num >= 100 && num < 1000)
{
    int a1 = num % 100 / 10;
    int a2 = num % 10;
    double result = Math.Pow(a1, a2);
    Console.WriteLine(result);
}
else
{
    Console.WriteLine("Вы что-то не то ввели");
}

