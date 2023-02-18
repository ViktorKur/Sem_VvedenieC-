// // Напишите программу, которая выводит случайное трехзначное
//  число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

Random random = new Random(); 
int RandomN = random.Next(100, 1000);
 Console.WriteLine(RandomN);
  /*int LeftN = RandomN / 100; 
  int RightN = RandomN % 10; 
  Console.WriteLine(LeftN + "" + RightN);*/ 
int LeftN = RandomN / 100 * 10; 
int RightN = RandomN % 10;
 int sum = LeftN + RightN; 
 Console.WriteLine(sum);