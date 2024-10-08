// See https://aka.ms/new-console-template for more information
using System;
using System.Drawing;
using System.Net.Sockets;


//Console.WriteLine("The result of the task #1 is: " + Task1());
//Console.WriteLine("The result of the task #2 is: " + Task2());
//Console.WriteLine("The result of the task #3 is: " + Task3());
Console.WriteLine($"The result of the task #3 is: " );
Task5();




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

static int Task2()
{
    Console.WriteLine("Provide socks :");
    string socks = Console.ReadLine();
    string socksToUpper = socks.ToUpper();
    char[] sockArray = socksToUpper.ToCharArray();
    Array.Sort(sockArray);
    int pairs = 0;
    int i = 0;
    while (i < sockArray.Length - 1)
    {
        if (sockArray[i] == sockArray[i + 1])
        {
            pairs++;
            i += 2;   // უკვე იდენტიფიცირებულ წყვილს რომ გადავახტეთ
        }
        else
        {
            i++;  
        }
    }

    return pairs;
}

static string Task3()
{
    Console.WriteLine("please provide the fisrt stirng:");
    string firstString = Console.ReadLine();
    Console.WriteLine("please provide the second stirng:");
    string secondString = Console.ReadLine();
    int i = firstString.Length - 1;
    int j = secondString.Length - 1;
    string suffix = "";

    while(i >= 0 && j >= 0)
    {
        if (firstString[i] == secondString[j])
        {
            suffix = firstString[i] + suffix;
            i--;
            j--;
        }
        else
        {
            break;
        }  
    }

    return suffix;
}


static void Task5()
{
    Console.WriteLine("Enter a number:");
    string input = Console.ReadLine();
    if (int.TryParse(input, out int value))
    {
        PrintDigitsWithDashes(input, 0);
        Console.WriteLine();
    }
    else
    {
        Console.WriteLine("Invalid input. Please enter a valid number.");
    }
}

static void PrintDigitsWithDashes(string number, int index)
{
    // თუ ბოლო სიმბოლოა, უბრალოდ დაიბეჭდოს
    if (index == number.Length - 1)
    {
        Console.Write(number[index]);
        return;
    }

    Console.Write(number[index] + " - ");

    PrintDigitsWithDashes(number, index + 1);
}



