Console.WriteLine("Введите число :");
int numberA = Math.Abs(Convert.ToInt32(Console.ReadLine()));
if (numberA > 99 && numberA < 1000)
{
numberA = numberA % 100;
Console.WriteLine("Последняя цифра " + numberA);
}
else
{
Console.WriteLine("Введите корректное число от 1 до 999");
}