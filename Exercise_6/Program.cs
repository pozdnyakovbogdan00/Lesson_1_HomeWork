// Exercise 6
Console.WriteLine("Enter number: ");
int InPutNumber = Convert.ToInt32(Console.ReadLine());
string Result = "Number is uneven";

if (InPutNumber %2 == 0)
{
    Result = "Number is even";   
}

Console.WriteLine(Result);