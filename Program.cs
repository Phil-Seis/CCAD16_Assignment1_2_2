namespace CCAD16_Assignment1_2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write a C# program to find the sum of first 10 natural numbers (1-10):
            //Use a For loop here
            int sum = 0;
            
            for (int i = 1; i < 11; i++)
            {
                sum += i;
            }
        Console.WriteLine("The sum of the first 10 natural numbers equals " + sum);
        }
    }
}
