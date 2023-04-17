// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Write("Введите число х1: ");
string number1_x1 = Console.ReadLine();
double number_x1 = Convert.ToDouble(number1_x1);

Console.Write("Введите число у1: ");
string number1_y1 = Console.ReadLine();
double number_y1 = Convert.ToDouble(number1_y1);

Console.Write("Введите число z1: ");
string number1_z1 = Console.ReadLine();
double number_z1 = Convert.ToDouble(number1_z1);

Console.Write("Введите число x2: ");
string number1_x2 = Console.ReadLine();
double number_x2 = Convert.ToDouble(number1_x2);

Console.Write("Введите число y2: ");
string number1_y2 = Console.ReadLine();
double number_y2 = Convert.ToDouble(number1_y2);

Console.Write("Введите число z2: ");
string number1_z2 = Console.ReadLine();
double number_z2 = Convert.ToDouble(number1_z2);

double x1_x2 = (number_x2 - number_x1);
double x = Math.Pow(x1_x2, 2);

double y1_y2 = (number_y2 - number_y1);
double y = Math.Pow(y1_y2, 2);

double z1_z2 = (number_z2 - number_z1);
double z = Math.Pow(z1_z2, 2);

double AB = Math.Sqrt(x + y + z);

Console.WriteLine("Расстояние между точками = " + Math.Round(AB, 2));