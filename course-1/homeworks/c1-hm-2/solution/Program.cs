//// Задание 1

double C = double.Parse(Console.ReadLine());
double F = C * 9 / 5 + 32;
Console.WriteLine(F);

// Задание 2

int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
int num3 = int.Parse(Console.ReadLine());
double average = (num1 + num2 + num3) / 3;
Console.WriteLine("Среднее арифметическое: " + average);

//Задание 3

int number1 = int.Parse(Console.ReadLine());
int number2 = int.Parse(Console.ReadLine());
Console.WriteLine("Сумма: " + (number1 + number2));
Console.WriteLine("Разность: " + (number1 - number2));
Console.WriteLine("Произведение: " + (number1 * number2));
Console.WriteLine("Частное: " + (number1 / number2));