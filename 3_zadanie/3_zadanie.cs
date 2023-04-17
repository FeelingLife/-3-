// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Write("Введите число N: ");
string number_N = Console.ReadLine();
double N = Convert.ToDouble(number_N);
double N2 = 0;

for (double N1 = 1; N1 <= N; N2 = Math.Pow(N1, 3), Console.Write($" {N2} "), N1++);