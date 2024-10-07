// See https://aka.ms/new-console-template for more information
using System.Drawing;


Console.WriteLine("The result of the task #1 is: " + Task1());

static int Task1()
{
    Console.WriteLine("Provide min number :");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Provide max number :");
    int b = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Provide power :");
    int n = Convert.ToInt32(Console.ReadLine());
    int result = 0;
    if (a > b) Console.WriteLine("Provide proper min and max values!");
    else
    {
        for (int i = 0; i <= b; i++)
        {
           double pwr = Math.Pow(i, n);
            if (pwr >= a && pwr <= b) 
            {
                result++;
            }
        }
    }
    return result; 
};
