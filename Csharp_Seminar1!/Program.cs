Console.WriteLine("Введите первое число: ");
int numberA = Convert.ToInt32(System.Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int numberB = Convert.ToInt32(System.Console.ReadLine());

int max = numberA;

int min = numberA;

if (numberA > max) max = numberA;
if (numberB > max) max = numberB;
if (numberA < max) min = numberA;


Console.Write("max = ");
Console.WriteLine(max);

Console.Write("min = ");
Console.WriteLine(min);
