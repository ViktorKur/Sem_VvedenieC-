System.Console.Write("Введите номер четверти  ");
int number = Convert.ToInt32(Console.ReadLine());
if (number == 1)
{
  System.Console.WriteLine("x > 0 && y > 0");
}
else if (number == 2)
{
  System.Console.WriteLine("x<0 && y>0");
}
else if (number == 3)
{
  System.Console.WriteLine("x<0 && y<0");
}
else if (number == 4)
{
  System.Console.WriteLine("x>0 && y<0");
}
else
{
  System.Console.WriteLine("Такой четверти нет");
}

// Второй вариант
// System.Console.Write("Введите номер четверти ");
// int number = Convert.ToInt32(Console.ReadLine());
// string[] strArray = { "x > 0 && y > 0", "x < 0 && y > 0", "x < 0 && y < 0", "x > 0 && y < 0", "Такой четверти нет" };
// if (number > 0 && number < 5)
// {
//   System.Console.WriteLine(strArray[number - 1]);
// }
// else
// {
//   System.Console.WriteLine("Такой четверти не существует");
// }
