// // Задача 17. Вводим значения координат (Х,У), программа ввыводит в какой четверти находятся точки причем Х и У не равны 0
// System.Console.Write("Введите значение Х: ");
// int X = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine();
// System.Console.Write("Введите значение Y: ");
// int Y = Convert.ToInt32(Console.ReadLine());
// if (X>0 && Y>0)
// {
//   System.Console.WriteLine(" Мы находимся в первой четверти ");
// }
// else if (X<0 && Y>0)
// {
//   System.Console.WriteLine(" Мы находимся во второй четверти ");
// }
// else if (X<0 && Y<0)
// {
//   System.Console.WriteLine(" Мы находимся в третьей четверти ");
// }
// else if (X>0 && Y<0)
// {
//   System.Console.WriteLine(" Мы находимся в четвертой четверти ");
// }
// else if (X==0 || Y==0)
// {
//   System.Console.WriteLine(" Мы находимся линии координат ");

// Вариант номер 2 решения задачи 17
int[] coord = new int[2];
System.Console.Write("Введите значение Х: ");
coord[0]  = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine();
 System.Console.Write("Введите значение Y: ");
coord[1] = Convert.ToInt32(Console.ReadLine());
if (coord[0]>0 && coord[1]>0)
{
  System.Console.WriteLine(" Мы находимся в первой четверти ");
}
 else if (coord[0]<0 && coord[1]>0)
 {
   System.Console.WriteLine(" Мы находимся во второй четверти ");
 }
 else if (coord[0]<0 && coord[1]<0)
 {
   System.Console.WriteLine(" Мы находимся в третьей четверти ");
 }
 else if (coord[0]>0 && coord[1]<0)
 {
   System.Console.WriteLine(" Мы находимся в четвертой четверти ");
 }
 else if (coord[0]==0 || coord[1]==0)
 {
     System.Console.WriteLine(" Мы находимся линии координат ");
 }