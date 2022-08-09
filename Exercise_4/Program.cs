// Exercise 4
int ? MaxNumber = null;
for (int i = 1; i <= 3; i++)
{
    Console.WriteLine("Enter number № "+i+":");
    int NumberI = Convert.ToInt32(Console.ReadLine());
    if (MaxNumber == null ? true : NumberI > MaxNumber)
    {
        MaxNumber = NumberI;      
    }  

}
Console.WriteLine("Max number is " + MaxNumber);