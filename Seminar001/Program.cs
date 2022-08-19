Console.WriteLine("Введите два числа: ");
int numberA = int.Parse(Console.ReadLine());
int numberB = int.Parse(Console.ReadLine());

int pow = Convert.ToInt32(Math.Pow(numberB, 2));

if(numberA == pow)
{
    Console.WriteLine("Первое число является квадратом второго");
}
else
{
Console.WriteLine("Первое число НЕ является квадратом второго");
}
