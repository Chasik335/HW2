Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
while (number >= 100)
{
    number /= 10;
}
int midel = number % 10;
Console.WriteLine(midel);