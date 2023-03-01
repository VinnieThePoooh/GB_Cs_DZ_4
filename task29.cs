// Задача 29: Напишите программу, которая задаёт массив из 8 элементов
// и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

System.Console.WriteLine("Введите значения восьми элементов массива");
string userNumber = Convert.ToString(Console.ReadLine());
int lenght = userNumber.Length;
while (lenght!=8)
{
    System.Console.WriteLine("Введите значения ВОСЬМИ элементов массива");
    userNumber = Convert.ToString(Console.ReadLine());
    lenght = userNumber.Length;
}
char[] array = new char[8];
int i = 0;
for (i=0; i<lenght; i++)
{
    array[i] = userNumber[i];
    if(i==0)
    {
        System.Console.Write($"[{array[i]}, ");
    }
    if(i==lenght-1)
    {
        System.Console.Write($"{array[i]}]");
    }
    if (i>0 && i<lenght-1)
    {
    System.Console.Write($"{array[i]} ,");}
}
