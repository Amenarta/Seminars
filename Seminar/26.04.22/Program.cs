/*
// Задача №1: Написать метод, который реализует замену элементов массива полож.на отриц.и наоборот.

int [] RandomArray (int size, int min, int max) // мы хотим заполнить метод случайными значениями
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max+1);
    }
    return array;
}

int [] ChangeNum (int [] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] *= (-1);
    return array;
}

void ScreenArray (int [] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

int[] myArray = RandomArray(7, -9, 9);
ScreenArray(myArray);
ChangeNum(myArray);
*/

// Задача №2: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.

int[] mas = {55, 4, 36, 27};
void NewArray (int[] array, int num)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == num)
            Console.Write("Данное число " + num + " есть в массиве");
    
        else
            Console.Write("Данного числа нет в массиве");
            
    }
}

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
NewArray(mas, a); // задача решена не до конца

