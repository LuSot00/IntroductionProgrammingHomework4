// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int sum = 0;
int temp = number;

while (temp >= 10)
{
   int digit = temp % 10;
    temp /= 10;
    sum = sum + digit;
}
sum = sum + temp;
Console.WriteLine($"Сумма цифр числа {number} равна {sum}");