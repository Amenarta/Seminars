/*
// Задача №1: Задайте двумерный массив. Напишите программу, 
// которая поменяет местами первую и последнюю строку массива.

int[,] CreatArray(int m, int n) // задаем любой массив, не только квадратный
{
    int[,] array = new int[m,n];
    for (int i = 0; i < m; i++)
    {
        for (int j  = 0; j < n; j++)
        {
            array[i,j] = new Random().Next(0,10);
            Console.Write(array[i,j] + "\t");
        }
        Console.WriteLine();
    }
    return array;
}

int[,] ChangeRowColumne(int[,] matrix)
{
    int temp = 0;
    for (int i=0; i< matrix.GetLength(1); i++);
    {
        temp = matrix[0, i];
        matrix[0, i] = matrix[matrix.GetLength(0)-1, i]; //проходим по строке и присваиваем послед.индекс 1-му
        matrix[matrix.GetLength(0)-1, i] = temp;
    }
    return matrix;
}

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i,j] + "\t");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите кол-во строк матрицы: ");
int strin = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов матрицы: ");
int colum = Convert.ToInt32(Console.ReadLine());

PrintArray(ChangeRowColumne(CreatArray(strin, colum))); на занятии код запускался
*/

// Задача №2: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, 
// программа должна вывести сообщение для пользователя.

int[,] CreatArray(int m, int n) // задаем любой массив, не только квадратный
{
    int[,] array = new int[m,n];
    for (int i = 0; i < m; i++)
    {
        for (int j  = 0; j < n; j++)
        {
            array[i,j] = new Random().Next(0,10);
            Console.Write(array[i,j] + "\t");
        }
        Console.WriteLine();
    }
    return array;
}

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i,j] + "\t");
        }
        Console.WriteLine();
    }
}

int[,] ChangedColumne(int[,] matrix)
{
    int[,] result = new int[matrix.GetLength(0), matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            result[i,j] = matrix[j,i];
        }
        Console.WriteLine();
    }
    return result;
}

Console.Write("Введите кол-во строк матрицы: ");
int strin = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов матрицы: ");
int colum = Convert.ToInt32(Console.ReadLine());

if (strin == colum)
{
   PrintArray(ChangedColumne(CreatArray(strin,colum))); 
}
else
{
    Console.Write("невозможно поменять столбцы на строки.");
}
