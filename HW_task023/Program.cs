/*
Задача 23
Напишите программу, которая принимает на вход число (N) 
и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

//1 способ (через for):
Console.Clear();
Console.Write("Введите целое число N: ");
int numberN = Math.Abs(int.Parse(Console.ReadLine()));
for (int count = 1; count < numberN + 1; count++)
{
  Console.Write(Math.Pow(count, 3));
  if (count == numberN)
    Console.Write(" ");
  else
    Console.Write(", ");
}

/*2 способ (через while):
Console.Clear();
Console.Write("Введите целое число N: ");
int numberN = int.Parse(Console.ReadLine());
double result = Math.Abs(numberN);
//или int result = Math.Abs(numberN);
int count = 1;
while (count < result + 1)
{
  Console.Write(Math.Pow(count, 3));
  //Console.Write(count * count * count);
  if (count == result)
    Console.Write(" ");
  else
    Console.Write(", ");
  count++;
}
*/


