// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int GetNumb(string message)
{
    Console.WriteLine(message);
    int num = int.Parse(Console.ReadLine());
    return num;
}

int Exp(int x, int exponent)
{
    int count = 1;
    for (int i = 0; i < exponent; i++)
    {
        count = count * x;
    }
    return count;
}

int x = GetNumb("Введите число: ");
int exponent = GetNumb("Введите показатель степени: ");
Console.WriteLine($"Число {x} в степени {exponent} = {Exp(x, exponent)}");