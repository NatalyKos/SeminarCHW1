Console.Write("Введите число 1: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 2: ");
int numberB = Convert.ToInt32(Console.ReadLine());
if (numberA > numberB)
{
    Console.WriteLine(numberA + " больше " + numberB);
}
else if (numberA == numberB)
{
    Console.WriteLine(numberA + " = " + numberB);
}
else
{
    Console.WriteLine(numberB + " больше " + numberA);
}