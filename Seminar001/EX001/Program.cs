﻿// // // Задача №1. Напишите программу, которая на вход принимает 
// два числа и проверяет, является ли первое число квадратом второго.
// a = 25, b = 5 -> да 
// a = 2, b = 10 -> нет 
// a = 9, b = -3 -> да 
// a = -3 b = 9 -> нет

System.Console.WriteLine("Введите первое число");
int numA = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите второе число");
int numB = Convert.ToInt32(Console.ReadLine());

if (numA == numB * numB)
{
  System.Console.WriteLine($" Первое введенное число {numA} является квадратом второго {numB} - да");
}
else
{
  System.Console.WriteLine($"Первое введенное число {numA} не является квадратом второго {numB} - нет");
}
