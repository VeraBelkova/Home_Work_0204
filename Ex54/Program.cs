// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4


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


void SelectionSort(int[,] array)
{
for (int z = 0; z < array.GetLength(0); z++)
  {
    for (int i = 0; i < array.GetLength(1)-1; i++)
    {
      int maxPosition = i;

      for (int j = i + 1; j < array.GetLength(1); j++)
      {
        if (array[z,j] > array[z,maxPosition])
        {
          maxPosition = j;
        }
      }
        int temporary = array[z,i];
        array[z,i] = array[z,maxPosition];
        array[z,maxPosition] = temporary;
    }
   }
}

int rows = Input ("Введите количество строк: ");
int columns = Input ("Введите количество столбцов: ");
int [,] array = new int [rows,columns];
FillArray(array);
PrintArray(array);
Console.WriteLine();
SelectionSort(array);
PrintArray(array);
