Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (1 <= number && number <= 7)
{
    if (number > 5)
    {
        Console.Write("Выходной день");
    }
    else
    {
        Console.Write("Рабочий день");
    }
}
else
{
    Console.Write("К сожалению в календаре нет заданного дня");
}
