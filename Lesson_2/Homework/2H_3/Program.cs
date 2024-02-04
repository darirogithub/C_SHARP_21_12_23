//Напишите программу, которая принимает на вход целое число из отрезка [10, 99] и показывает наибольшую
//цифру числа.

Console.WriteLine("Напишите число от 10 до 99: ");
int n = int.Parse(Console.ReadLine()!);
if (n >= 10 && n <= 99)
{
   int N1 = n / 10;
   int N2 = n % 10;
   if (N1 >= N2)
   {
    Console.WriteLine(N1);
   }
   else
   {
    Console.WriteLine(N2);
   }

}
else
{
    Console.WriteLine("Вы ввели неправильное число, попробуйте снова");
}
//Задача решена