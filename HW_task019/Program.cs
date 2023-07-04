/*
Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, 
является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/
Console.Clear();
Console.Write("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
int num1 = num / Convert.ToInt32(Math.Pow(10, 4));
int num2 = num / Convert.ToInt32(Math.Pow(10, 3)) % 10;
int num4 = (num / 10) % 10;
int num5 = num % 10;
if (num1 == num5 && num2 == num4)
Console.Write($"Число {num}: является палиндромом");
else
Console.Write($"Число {num}: НЕ является палиндромом");