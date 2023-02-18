// Задача №7. Напишите программу, которая принимает на вход трёхзначное 
// число и на выходе показывает последнюю цифру этого числа.	
// 456 -> 6	
// 782 -> 2
// 918 -> 8
 
Console.Write("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());
int ost=num%10;
if (num>99 && num<1000) 
{
Console.Write($"{ost} ");
}
else 
{
Console.WriteLine($" Число {num} не является трехзначным");
}
