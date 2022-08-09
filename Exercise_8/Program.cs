// Exercise 8 
Console.WriteLine("Enter N: ");
int N = Convert.ToInt32(Console.ReadLine());

for (int i = -N; i <= N; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
    }
}