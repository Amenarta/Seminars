/*
// Задача №1: Написать программу, которая примет на вход координаты какой-то точки, написать метод, который определит в какой четверти эта точка находится

int FindQvart (int x, int y)
{
    if (x>0 && y>0)
        return 1;
    else if (x <0 && y>0)
        return 2;
    else if (x <0 && y <0)
        return 3;
    else if (x >0 && y <0)
        return 4;
    else
        return 0;
}

Console.Write("Введите координату x: ");
int xdot = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату y: ");
int ydot = Convert.ToInt32(Console.ReadLine());

int qvartNum = FindQvart(xdot, ydot);

if (qvartNum == 0)
    Console.WriteLine("точка координат расположена на осях координат");
else
    Console.WriteLine("Номер четверти точки: " + qvartNum);


// Задача №2: Написать метод, который на вход отправляет номер четверти, а выводит диапоон точек

void FindQvart(int f)
{
    if (f == 1)
        Console.Write("1 четверть. Диапозон координат: x >0; y > 0");
    else if (f == 2)
        Console.Write("2 четверть. Диапозон координат: x < 0; y > 0");
    else if (f == 3)
        Console.Write("3 четверть. Диапозон координат: x < 0; y < 0");
    else if (f == 4)
        Console.Write("4 четверть. Диапозон координат: x > 0; y < 0");
    else  
        Console.Write("Точка координат расположена на оси координат");
}

Console.Write("Введите номер четверти координат от 1 до 4: ");
int qvart = Convert.ToInt32(Console.ReadLine());

if (qvart <0 || qvart >4)
Console.Write("Число не входит в диапозон чисел четвертей.");
else
    FindQvart(qvart);


// Задача №3: Написать программу, которая примет на вход координаты 2-х точек и найдет расстояние между этими точками

double sqwert1 (int x1, int y1, int x2, int y2)
{
    return Math.Sqrt((x2-x1)*(x2-x1) + (y2-y1)*(y2-y1));
}

Console.Write("Введите координату х1 для первой точки: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату y1 для первой точки: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату х2 для второй точки: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату y2 для второй точки: ");
int y2 = Convert.ToInt32(Console.ReadLine());

Console.Write(sqwert1(x1,y1, x2,y2));

// Задача №4: написать программу, которая принимает 1 целое число и выдает табл.квадратов чисел от 1 до этого числа.

void sqwert1 (int N)
{
    int count = 1;
    Console.Write(N + " ->");
    while (count <=N)
    {
        Console.Write(count*count + " ");
        count++;
    }
}

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num >0)
    sqwert1 (num);
else
    Console.Write("Число должно быть от 0. Введите число: ");
*/