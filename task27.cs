// Задача 27: Напишите программу, которая принимает на вход число
// и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

System.Console.WriteLine("Ввведите число");
int userNumber = Convert.ToInt32(Console.ReadLine());
int number = 0;
while (userNumber>9)
{
    number = number + userNumber%10;
    userNumber = userNumber/10;
}
number = number+userNumber;
System.Console.WriteLine(number);