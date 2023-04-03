// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int Input(string text) 
{
Console.Write(text + " ");
return Convert.ToInt32(Console.ReadLine());
}

void FillArraySpiral(int[,] matr) 
{
  for (int j = 0; j < matr.GetLength(1); j++)
  {
    int i = 0;
    matr[i,j] = new Random().Next(0,10);
  }
 
  for (int i = 0; i < matr.GetLength(0); i++)
  {
    int j = 3;
    matr[i,j] = new Random().Next(0,10);
  }
  for (int j = 0; j < matr.GetLength(1)-1; j++)
  {
    int i = 3;
    matr[i,j] = new Random().Next(0,10);
  }
  for (int i = 1; i < matr.GetLength(0)-1; i++)
  {
    int j = 0;
    matr[i,j] = new Random().Next(0,10);
  }
   for (int j = 1; j < matr.GetLength(1)-1; j++)
  {
    int i = 1;
    matr[i,j] = new Random().Next(0,10);
  }
   for (int i = 2; i < matr.GetLength(0)-1; i++)
  {
    int j = 1;
    matr[i,j] = new Random().Next(0,10);
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

int rows = Input ("Введите количество строк: ");
int columns = Input ("Введите количество столбцов: ");
int [,] array = new int [rows,columns];
FillArraySpiral(array);
PrintArray(array);
