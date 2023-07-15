// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

double Prompt(string message)
{
    Console.Write(message);
    double num = double.Parse(Console.ReadLine()!);
    return num;
}

void Kub (double a)
{   
    if(a > 0)
    {
        for(double i = 1; i <= a; i++)
        {
            double res = Math.Pow(i , 3); 
            Console.Write($"{res} ");
        }
    }
    else
    {
        Console.Write("Введите положительное число!");
    }
}

double N = Prompt("Введите число: ");
Kub(N);