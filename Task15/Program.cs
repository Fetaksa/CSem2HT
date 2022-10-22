// Напишите программу, которая принимает на
// вход цифру, обозначающую день недели, и проверяет,
// является ли этот день выходным

Console.Write("Введите число от 1 до 7: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 7)
{
    Console.WriteLine("Недопустимое значение ввода");
}

if (number > 0 && number < 8)
{
    if (number == 1)
    {
        Console.WriteLine("Понедельник");
    }

    else if (number == 2)
    {
        Console.WriteLine("Вторник");
    }

    else if (number == 3)
    {
        Console.WriteLine("Среда");
    }

    else if (number == 4)
    {
        Console.WriteLine("Четверг");
    }

    else if (number == 5)
    {
        Console.WriteLine("Пятница");
    }

    else if (number == 6)
    {
        Console.WriteLine("Суббота");
    }

    else if (number == 7)
    {
        Console.WriteLine("Воскресенье");
    }

    if (number == 6 || number == 7)
    {
        Console.WriteLine("Это выходной");

    }

    else Console.WriteLine("Это НЕ выходной");

}

//Я знаю, что получилось примитивно и громоздко. Но методы я не усвоила, и не смогла здесь применить =(