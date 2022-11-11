// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
int number = Read("Введите пятизначное число: ");
int lengthnumber = number.ToString().Length;
int Read(string number) 
{
    Console.Write(number);
    return int.Parse(Console.ReadLine()!);
}
int numberA(int value, int size)
{
    int[] digits = new int[size];
    for (int index = size - 1; index >= 0; index--)
    {
        digits[index] = value % 10;
        value = value / 10;
    }
    int res=0;
    if (digits[0] == digits[4] && digits[1] == digits[3])
    {
        Console.Write("Да");
        res =1;
    }
    else
    {
        Console.Write("Нет ");
        res=0;
    }
    return res;
}
Console.WriteLine(numberA(number, lengthnumber));

