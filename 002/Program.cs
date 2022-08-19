Console.WriteLine("Введите число от 1 до 7: ");
int number = int.Parse(Console.ReadLine());

if(number <1 ||number>7)
{
    Console.WriteLine("Введите число от 1 до 7");
}

if(number == 1)
{
    Console.WriteLine("Это понедельник!");
}
if(number == 2)
{
    Console.WriteLine("Это вторник!");
}
if(number == 3)
{
    Console.WriteLine("Это среда!");
}
if(number == 4)
{
    Console.WriteLine("Это четверг!");
}
if(number == 5)
{
    Console.WriteLine("Это пятница!");
}
if(number == 6)
{
    Console.WriteLine("Это суббота!");
}
if(number == 7)
{
    Console.WriteLine("Это воскресенье!");
}


