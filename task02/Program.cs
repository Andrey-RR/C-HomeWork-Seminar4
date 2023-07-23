// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


int Promt(string message)
{
    Console.WriteLine(message);
    int num = int.Parse(Console.ReadLine());
    return num;
}

int Sum(int a)
{
    int count = 0;
    for (; a > 0; a/=10)
    
    {
        count =count + a%10;
    }
    return count;

}

int num = Promt("Введите число: ");
Console.WriteLine($"Сумма цифр в числе {Sum(num)}");