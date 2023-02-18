// Напишите программу, которая принимает на вход число и проверяет, 
// кратно ли оно одновременно 
// 7 и 23.

// 14 -> нет 
// 46 -> нет 
// 161 -> да
System.Console.Write("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());

if (numberA % 7 == 0 && numberA % 23 == 0)
{
    System.Console.WriteLine("Число кратно");
}
else
{
    System.Console.WriteLine("Число не кратно");
}