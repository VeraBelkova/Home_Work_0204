// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


void FillArray(int[,] matr)
{
  for (int i = 0; i < matr.GetLength(0); i++)
  {
    for (int j = 0; j < matr.GetLength(1); j++)
      {
        matr[i,j] = new Random().Next(0,10);
      }
  }
}
void PrintArray(int [,] tabl) 
{
  for (int i = 0; i < tabl.GetLength(0); i++)
{
  for (int j = 0; j < tabl.GetLength(1); j++)
  {
    Console.Write(tabl[i,j] + " ");
  }
Console.WriteLine();
}
}


int SumOfRow(int[,] array, int i)
{
  int sum = 0;
  for (int j = 0; j < array.GetLength(1); j++)
  {
    sum+= array[i,j];
  }
  return sum;
}

int Min (int arg1, int arg2, int arg3, int arg4)
{
int index = 1;
if (arg2 < arg1) index = 2;
if (arg3 < arg2) index = 3;
if (arg4 < arg3) index = 4;
return index;
}

int [,] array = new int [4,4];
FillArray(array);
PrintArray(array);
int sum1 = SumOfRow(array,0);
int sum2 = SumOfRow(array,1);
int sum3 = SumOfRow(array,2);
int sum4 = SumOfRow(array,3);
Console.WriteLine($"{sum1}, {sum2}, {sum3}, {sum4}");
int minrow = Min(sum1,sum2,sum3,sum4);
Console.WriteLine($"номер строки с наименьшей суммой элементов: {minrow} строка");

