// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

int Prompt (string message)
{
    Console.Write(message);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

void Palindrom(int a)
{
    if(a > 9999 && a < 100000)
    {
        int a1 = a / 10000;
        int a2 = a / 1000 % 10;
        int a4 = a / 10 % 10;
        int a5 = a % 10;
        if(a1 == a5)
        {
            if(a2 == a4)
            {
                Console.Write("Является полиндромом");
            }
            else
            {
                Console.Write("Не является полиндромом");    
            }
        }
        else
        {
            Console.Write("Не является полиндромом");
        }
   }
   else
   {
    Console.Write("Error: Число не пятизначное!!!");
   }

}

int number = Prompt ("Введите пятизначное число: ");
Palindrom(number);