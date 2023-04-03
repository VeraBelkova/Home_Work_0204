
// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int Input(string text) // ввод текста и получение значения от пользователя
{
Console.Write(text + " ");
return Convert.ToInt32(Console.ReadLine());
}


void FillArray(int[,] matr) // заполнение массива случайными числами
{
for (int i = 0; i < matr.GetLength(0); i++)
{
for (int j = 0; j < matr.GetLength(1); j++)
{
matr[i,j] = new Random().Next(0,10);
}
}
}

void PrintArray(int [,] tabl) // вывод массива на печать
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
int [,] array1 = new int [rows,columns];
int [,] array2 = new int [rows,columns];
int [,] array3 = new int [rows,columns];
FillArray(array1);
FillArray(array2);
PrintArray(array1);
Console.WriteLine();
PrintArray(array2);
Console.WriteLine();

int mult = 0;
for (int i = 0; i < array1.GetLength(0); i++)
{
  for (int j = 0; j < array1.GetLength(1); j++)
  {
    mult = array1[i,j] * array2[i,j];
    array3[i,j] = mult;
    Console.Write(array3[i,j] + " ");
  }
Console.WriteLine();
}