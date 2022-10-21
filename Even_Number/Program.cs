Console.Write("Type the number: ");
int number = int.Parse(Console.ReadLine()!);
if (number % 2 == 0 ) 
{
    Console.WriteLine("Yes, it's even number");
}
else
{
    Console.WriteLine("No, it's not even number");
}