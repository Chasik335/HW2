Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number >= 100)
{
    int endCh = number % 10;
    Console.WriteLine(endCh);
}
else
{
   Console.Write("Третьего числа нет  -1"); 
}

