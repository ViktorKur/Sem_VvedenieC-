// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса нечётные, и замените эти элементы на их квадраты.
// Например, изначально массив
//  выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Новый массив будет выглядеть 
// вот так:
// 1 4 7 2
// 5 81 2 9
// 8 4 2 4
int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GenerateMatrix(int m, int n)
{
    int[,] matrix = new int [m, n];
    Random rand = new Random();
    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            matrix[i,j] = rand.Next(-10, 10);
        }
    }
    return matrix;
}

// int[,] UslNechetn (int [,]matriks)

// {
//   int [,] matnec = new int [matriks.GetLength(0),matriks.GetLength(1)] ;
//    for(int i = 0; i < matriks.GetLength(0); i++)
//     {
//         for(int j = 0; j < matriks.GetLength(1); j++)
//         {
//             if (i%2!=0 && j%2!=0)
//             {
// matnec[i,j] = matriks[i,j]*matriks[i,j];
//             }
//         }
//         System.Console.WriteLine();
//     }
//     return matnec;
// }

int[,] UslNechetn (int [,]matriks)

{
  int [,] matnec = new int [matriks.GetLength(0),matriks.GetLength(1)] ;
   for(int i = 0; i < matriks.GetLength(0); i+=2)
    {
        for(int j = 0; j < matriks.GetLength(1); j+=2)
        {
            
matnec[i,j] = matriks[i,j]*matriks[i,j];
           
        }
        System.Console.WriteLine();
    }
    return matnec;
}

void PrintMatrix(int[,] matr)
{
    for(int i = 0; i < matr.GetLength(0); i++)
    {
        for(int j = 0; j < matr.GetLength(1); j++)
        {
            System.Console.Write(matr[i,j] + " ");
        }
        System.Console.WriteLine();
    }
}
int m = ReadInt("Введите количетсво строк матрицы: ");
int n = ReadInt("Введите количество столбцов матрицы: ");
var myMatrix = GenerateMatrix(m, n);
PrintMatrix(myMatrix);
PrintMatrix(UslNechetn(myMatrix));