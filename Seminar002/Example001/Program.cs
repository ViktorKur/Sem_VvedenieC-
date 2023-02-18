// // Напишите программу, которая выводит случайное число из отрезка [10, 99]
//  и показывает наибольшую цифру числа.  
//  // Например: // 78 -> 8 // 12-> 2 // 85 -> 8
Random rand = new Random();
 int randNumber = rand.Next(10, 100); 
System.Console.WriteLine(randNumber); 
 int leftNumber = randNumber / 10; 
 int rightNumber = randNumber % 10;  
 if (leftNumber > rightNumber) 
 {    
   System.Console.WriteLine($"{leftNumber} > {rightNumber}"); 
 } else if (rightNumber > leftNumber) 
 {    
   System.Console.WriteLine($"{rightNumber} > {leftNumber}");
 } else 
 {  
     System.Console.WriteLine("Числа равны"); 
 }
