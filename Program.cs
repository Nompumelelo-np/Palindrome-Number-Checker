using System;
public class PalindromeNumberExample
{

    public static void Main(string[] args)
    {
        int num, rev, sum = 0, temp;
        Console.Write("Enter number: ");
        num = int.Parse(Console.ReadLine());
        temp = num;
        while (num > 0)
        {
            rev = num % 10;
            sum = (sum * 10) + rev;
            num = num / 10;
        }
        if (temp == sum)
            Console.Write(" The given number is Palindrome.");
        else
            Console.Write(" The given number is not Palindrome.");
    }
}