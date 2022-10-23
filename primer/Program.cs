//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
void Zadacha43()
{
    double k1 = InputMessage("Enter k1 ");
    double b1 = InputMessage("Enter b1 ");
    double k2 = InputMessage("Enter k2 ");
    double b2 = InputMessage("Enter b2 ");
    double x = (b2-b1)/(k1-k2);
    double y = k1*x + b1;
    Console.WriteLine($"cross  point is {x} , {y}");


}
int InputMessage(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
//Zadacha43();
//Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
void Zadacha41()
{
    int kolvo = InputMessage("How many numbers do you want to enter? ");
    int[] numbers = new int[kolvo];
    int count = 0;
    for (int i = 0; i < kolvo; i++)
    {
        numbers[i] = InputMessage($"Enter a {i+1} number ");
        if (numbers[i]>0) count++;
    }
     Console.WriteLine($"Count of positive numbers = {count}");
}
Zadacha41();