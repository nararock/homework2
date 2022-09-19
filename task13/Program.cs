// Задача 13: Напишите программу, которая выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет.
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 100) Console.WriteLine("Третьей цифры нет");
else{
    int divider = 10;
    int counter = 1;
    while (number / divider != 0){
        counter++;
        divider*=10;
    }
    int divider2 = (int)Math.Pow(10, counter - 3);
    int result = (number / divider2) % 10;
    Console.WriteLine(result);
}
