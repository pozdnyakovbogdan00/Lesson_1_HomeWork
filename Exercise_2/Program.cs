// Exercise 2. 

Console.WriteLine("Enter NumberA:");
int NumberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter NumberB:");
int NumberB = Convert.ToInt32(Console.ReadLine());
string OutPutText;

if (NumberA>NumberB)
{
  OutPutText = "Maximum number is NumberA ("+NumberA+"); Minimum number is NumberB ("+NumberB+").";  
}
else
{
    OutPutText = "Maximum number is NumberB ("+NumberB+"); Minimum number is NumberA ("+NumberA+").";   
}

Console.WriteLine(OutPutText);