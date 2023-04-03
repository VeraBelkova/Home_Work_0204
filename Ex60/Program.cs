// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int Input(string text) // ввод текста и получение значения от пользователя
{
Console.Write(text + " ");
return Convert.ToInt32(Console.ReadLine());
}

void FillArray(int[, ,] matr) // заполнение массива случайными числами
{
  for (int i = 0; i < matr.GetLength(0); i++)
  {
    for (int j = 0; j < matr.GetLength(1); j++)
    {
      for (int z = 0; z < matr.GetLength(2); z++)
      {
         matr[i,j,z] = new Random().Next(10,100);
      }
    }
  }
}

void PrintArray(int [, ,] tabl) // вывод массива на печать
{
  for (int i = 0; i < tabl.GetLength(0); i++)
{
  for (int j = 0; j < tabl.GetLength(1); j++)
  {
    for (int z = 0; z < tabl.GetLength(2); z++)
    {
      Console.Write(tabl[i,j,z] + "["+ i + "," + j + "," + z + "]"+ " ");
    }
    Console.WriteLine();
  }
}
}

int rows = Input ("Введите количество строк: ");
int columns = Input ("Введите количество столбцов: ");
int colomns2 = Input ("Введите количество столбцов: ");
int [, ,] array = new int [rows,columns,colomns2];
FillArray(array);
PrintArray(array);
