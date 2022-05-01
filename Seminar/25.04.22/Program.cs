/*
// Задача №1: написать программу, которая принимает на вход число N и возвращает сумму чисел от 1 до N.

int Natursum (int a)
{
    int sum = 0;
    if (a < 1) return 0;
    else 
    {
        for (int i = 1; i <=a; i++)
        {
            sum = sum +i; //sum += i
        }
        return sum;
    }
}

Console.Write("Введите число от 1: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.Write("Cумма чисел равна: " + Natursum(num));


// Задача №2: Написать программу, которая принимает число и выдает кол-во цифр в числе

int SumFigure (int b)
{
    int count = 0;
    while (b>0)
    {
        b = b /10;
        count ++;
    }
    return count;
}

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.Write("Количество чисел: " + SumFigure(num));


// Задача№3: написать программу, которая принимает на вход число N и возвращает произведение чисел от 1 до N.

int Factorial (int a)
{
    if (a == 1) return 1;
    else 
        return a * Factorial(a-1);    
}

Console.Write("Введите число от 1: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.Write("Произведение чисел равно: " + Factorial(num));


int Factorial (int a)
{
    int b = 1;
    if (a < 1) return 1;
    else 
        for (int i = 1; i <= a; i++)
        b *= i;
    return b;
}

Console.Write("Введите число от 1: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.Write("Произведение чисел равно: " + Factorial(num));


// Задача №4: Программа, которая сгенерируетмассив заполненный случайными образом 0 и 1 и выведет его на экран.

int [] PrintArray(int[] f)
{
    for (int i = 0; i < f.Length; i++)
    {
        f[i] = new Random().Next(0,2);
        Console.Write(PrintArray(f));
    }
    return f;
}

int[] f = new int[5]; // доработать. Задача (код) не работает.


// Задача №5: Необходимо задать массив, состоящий из 12 элементов, заполненный случайными числами из промежутка от -9 до 9 и найти сумму отриц. и полож.элементов массива

int [] RandomArray (int size, int min, int max) // мы хотим заполнить метод случайными значениями
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max+1);
    }
    return array;
}

int [] FilledArray (int size) // мы хотим заполнить конкретными значениями массив
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write("Введите" + i + "elements: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void FindSumArray (int [] array)
{
    int PlusSum = 0; //  создали переменную
    int MinusSum = 0; // создали переменную

    for (int i = 0; i < array.Length; i++)
    {
        if (array [i] >0 ) // если полож., то
            PlusSum += array[i]; // увелич.PlusSum
        else
            MinusSum += array [i];
    }
    Console.WriteLine("Сумма положительных элементов: " + PlusSum); //т.к. метод void вывод внутри метода
    Console.WriteLine("Сумма отрицательных элементов: " + MinusSum);
}

void ScreenArray (int [] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

int[] myArray = RandomArray(12, -9, 9);
ScreenArray(myArray);
FindSumArray(myArray);

*/