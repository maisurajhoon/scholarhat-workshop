using System;

class NumToWords
{
    public static void Main()
    {
        Console.Clear();
        Console.Write("Enter a four digit number: ");
        int num = Convert.ToInt32(Console.ReadLine());

        int u = num % 10;
        int t = (num / 10) % 10;
        int h = (num / 100) % 10;
        int th = (num / 1000) % 10;

        string[] onesplace = new string[] { " ", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" };
        string[] teens = new string[] { "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };
        string[] tensplace = new string[] { " ", "Ten", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };

        if (num < 0 || num > 9999)
        {
            Console.Write("Please enter a valid four-digit number!");
        }
        else if (num < 10)
        {
            Console.WriteLine(onesplace[num]);
        }
        else if (num < 20)
        {
            Console.WriteLine(teens[u]);
        }
        else if (num < 100)
        {
            Console.WriteLine(tensplace[t] + onesplace[u]);
        }
        else if (num < 1000)
        {
            Console.WriteLine($"{onesplace[h]} Hundred {tensplace[t]} {onesplace[u]}");
        }
        else if (num < 10000)
        {
            if (t == 0 && u == 0)
            {
                Console.WriteLine($"{onesplace[th]} Thousand");
            }
            else
            {
                Console.WriteLine($"{onesplace[th]} Thousand {onesplace[h]} Hundred {tensplace[t]} {onesplace[u]}");
            }
        }
    }
}
