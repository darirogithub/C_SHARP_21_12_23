﻿//Напишите программу, которая на вход принимает натуральное число N, 
// а на выходе показывает его цифры через запятую.

string MaxNum(int num)
{
Console.WriteLine(num);
string allNums = "";

while (num > 0)
{
    allNums = num % 10 + "," + allNums;
    num /=10;
}
return allNums;
}

Console.WriteLine(MaxNum(new Random().Next(1, 100000)));
// Задача списана 