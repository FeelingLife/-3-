// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. (палиндром - число читается слева направо и справа налево одинаково)
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите число: ");
string number = Console.ReadLine();

if (number[0] == number[4] && number[1] == number[3])
{
    int number_1 = Convert.ToInt32(number);
    Console.WriteLine($"Число {number_1} является палиндромом");
}
else
{
    int number_1 = Convert.ToInt32(number);
    Console.WriteLine($"Число {number_1} не является палиндромом");
}