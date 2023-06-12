Console.WriteLine("Введите первое число: ");
int numberA = Convert.ToInt32(System.Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int numberB = Convert.ToInt32(System.Console.ReadLine());

int max = numberA;

if (numberA > max) max = numberA;
if (numberB > max) max = numberB;

Console.Write("max = ");
Console.WriteLine(max);
