//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

// int[,] myArray = GetArray(3, 4);
// Console.WriteLine($"Первоначальный массив: ");
// PrintArray(myArray);

// Console.WriteLine($"\nОтсортированный массив: ");
// DescendElemSort(myArray);
// PrintArray(myArray);

// int[,] GetArray(int n, int m)
// {
//     int[,] array = new int[n, m];
//     for(int i = 0; i < n; i++)
//     {
//         for(int j = 0; j < m; j++)
//         {
//         array[i, j] = new Random().Next(1, 10);
//         }
//     }
//     return array;
// }

// void PrintArray(int[,] array){
//      for(int i = 0; i < array.GetLength(0); i++)
//      {
//         for(int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine();
//      }
// }

// void DescendElemSort(int[,] myArray)
// {
//   for (int i = 0; i < myArray.GetLength(0); i++)
//   {
//     for (int j = 0; j < myArray.GetLength(1); j++)
//     {
//       for (int k = 0; k < myArray.GetLength(1) - 1; k++)
//       {
//         if (myArray[i, k] < myArray[i, k + 1])             
//         {
//           int temp = myArray[i, k + 1];
//           myArray[i, k + 1] = myArray[i, k];
//           myArray[i, k] = temp;
//         }
//       }
//     }
//   }
// }

//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// int[,] myArray = GetArray(4, 4);
// Console.WriteLine($"\nВ массиве: ");
// PrintArray(myArray);

// int[,] GetArray(int n, int m)
// {
//     int[,] array = new int[n, m];
//     for(int i = 0; i < n; i++)
//     {
//         for(int j = 0; j < m; j++)
//         {
//         array[i, j] = new Random().Next(1, 10);
//         }
//     }
//     return array;
// }

// void PrintArray(int[,] array){
//      for(int i = 0; i < array.GetLength(0); i++)
//      {
//         for(int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine();
//      }
// }

// int sumLineElements(int[,] myArray, int i)
// {
//   int SumLine = myArray[i,0];                            
//   for (int j = 1; j < myArray.GetLength(1); j++)
//   {
//     SumLine += myArray[i,j];
//   }
//   return SumLine;
// }

// int minSumLine = 0;
// int sumLine = sumLineElements(myArray, 0);                
//     for (int i = 0; i < myArray.GetLength(0); i++)
//     {
//         int temp = sumLineElements(myArray, i);           
//         if (temp < sumLine)
//         {
//             sumLine = temp;
//             minSumLine = i; //?
//         }
//     }
// Console.WriteLine($"\n{minSumLine}-ая строка - это строкa с наименьшей суммой элементов. Сумма ее элементов = {sumLine} ");


// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int m = InputNumber("Введите число строк 1-й матрицы: ");
int n = InputNumber("Введите число столбцов 1-й матрицы (и строк 2-й): "); 
int p = InputNumber("Введите число столбцов 2-й матрицы: ");
int range = InputNumber("Введите диапазон случайных чисел: от 1 до ");

int InputNumber(string input)    
{
  Console.Write(input);
  int output = int.Parse(Console.ReadLine()!);
  return output;
}

int[,] Martrix1 = new int[m, n];
GetArray(Martrix1);
Console.WriteLine($"\nПервая матрица:");
PrintArray(Martrix1);

int[,] Martrix2 = new int[n, p];
GetArray(Martrix2);
Console.WriteLine($"\nВторая матрица:");
PrintArray(Martrix2);

int[,] resultMatrix = new int[m,p];

MultiplyMatrix(Martrix1, Martrix2, resultMatrix);
Console.WriteLine($"\nПроизведение первой и второй матриц:");
PrintArray(resultMatrix);

void MultiplyMatrix(int[,] Martrix1, int[,] Martrix2, int[,] resultMatrix)
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < Martrix1.GetLength(0); k++) //?
      {
        sum += Martrix1[i,k] * Martrix2[k,j];
      }
      resultMatrix[i,j] = sum;
    }
  }
}

void GetArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(range);
    }
  }
}

void PrintArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
  }
}


    
