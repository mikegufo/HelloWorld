Console.WriteLine("Введите первое число :");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число :");
int numberB = Convert.ToInt32(Console.ReadLine());

if ((numberB * numberB) == numberA)
{
Console.WriteLine("Да");
}
else
{
Console.WriteLine("Нет");
}
Console.ReadKey();
