// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


Console.WriteLine("Введите пятизначное число");
int number = Convert.ToInt32(Console.ReadLine());
int[] Count = new int[number.ToString().Length];
if (Count.Length == 5)
{
    int k = 0;
    while (number > 0)
    {
            Count[k] = number % 10;
            number = number / 10;
            k++;
    }
    if (Count[0] == Count[4] && Count[1] == Count[3])
        Console.WriteLine("Число является палиндромом");
    else
        Console.WriteLine("Число не является палиндромом");
}
else
{
    return;
}



