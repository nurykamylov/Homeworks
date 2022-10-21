Console.Write("Type the Natural number: ");
int number = int.Parse(Console.ReadLine()!);

int n = 2; 
while(n <= number )
{
    Console.Write(n);
    Console.Write(",");
    n+=2;
}