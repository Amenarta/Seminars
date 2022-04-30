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