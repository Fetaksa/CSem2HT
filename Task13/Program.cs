// Напишите программу, которая выводит
// третью цифру заданного числа или сообщает, что третьей
// цифры нет

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int x = number;

if (x > 99)
{
    while (x > 999)
    {
       x = x / 10;
    }

    int n = x % 10;
    Console.WriteLine($"Третья цифра числа => {n}");
}

else
    Console.WriteLine("В данном числе третья цифра отсутствует");