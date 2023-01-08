Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
while (number >= 1000)
{
    number /= 10;
}
if (number < 100)
{
    Console.Write("Третьего числа нет  -1");
}
else
{
    number = number % 10;
    Console.WriteLine(number);
}




