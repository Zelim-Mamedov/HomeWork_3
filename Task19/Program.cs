// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Clear();
Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

void MirroringCheck()
{
    int digit1 = number / 10000; // полученное число делим на 10000
    int digit5 = number % 10; // выводим % (остаток от деления)
    int digit2 = number / 1000 % 10; // полученное число делим на 1000, а потом выводим % (остаток от деления)
    int digit4 = number / 10 % 10; // полученное число делим на 10, выводим % (остаток от деления)
    int check = number / 10000;

    if (check < 1 || check > 9)
        Console.WriteLine(number + " -> " + "Ввели не верное число! ");
    else if (digit1 == digit5 && digit2 == digit4)
        Console.WriteLine(number + " -> да");
    else
        Console.WriteLine(number + " -> нет");
}
MirroringCheck();


