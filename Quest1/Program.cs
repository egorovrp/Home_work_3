// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double Prompt (string message)
{
    Console.Write(message + " ");
    double num = double.Parse(Console.ReadLine()!);
    return num;
}

double Distance (double x, double y, double z, double x1, double y1, double z1)
{
    double Prime = Math.Round((Math.Sqrt(Math.Pow((x-x1),2) + Math.Pow((y-y1),2) + Math.Pow((z-z1),2))),2);
    return Prime;
}

double x_0 = Prompt("Введите значение X первого вектора:");
double y_0 = Prompt("Введите значение Y первого вектора:");
double z_0 = Prompt("Введите значение Z первого вектора:");
double x_1 = Prompt("Введите значение X второго вектора:");
double y_1 = Prompt("Введите значение Y второго вектора:");
double z_1 = Prompt("Введите значение Z второго вектора:");

double Res = Distance(x_0, y_0, z_0, x_1, y_1, z_1);
Console.Write(Res);