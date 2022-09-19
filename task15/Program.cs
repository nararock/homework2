// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
//и проверяет, является ли этот день выходным.
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 1 || number > 7) Console.WriteLine("Вы ввели неправильное число");
else{
    if (number == 6 || number == 7) Console.WriteLine("Ура, Выходной!");
    else Console.WriteLine("будни=(");
}
