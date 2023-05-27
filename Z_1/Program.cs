//Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
bool IsPalindrom(int arg1)
{
    int arg2 = 0;
    int n  = arg1;
    while (arg1 > 0)
    {
        arg2 = arg2 * 10;
        arg2 = arg2 + arg1 % 10;
        arg1 = arg1 / 10;
    }
    if (n == arg2)
    {
        return true;
    }
    else
    {
        return false;
    }
}
if (IsPalindrom(num)==true) Console.Write("Да");
if (IsPalindrom(num)==false) Console.Write("Нет");