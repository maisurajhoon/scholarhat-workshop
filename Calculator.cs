using System;
class Calculator
{
    static void Main(string[] args)
    {
        do
        {
            Console.Clear();
            int num1, num2;
            Console.WriteLine("Enter the required operation: ");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            int operation = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the first number: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second number: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            switch (operation)
            {
                case 1:
                    int add = num1 + num2;
                    Console.WriteLine($"The Addition is: {add}");
                    break;
                case 2:
                    int dif = num1 - num2;
                    Console.WriteLine($"The Subtraction is: {dif}");
                    break;
                case 3:
                    int mul = num1 * num2;
                    Console.WriteLine($"The Multiplication is: {mul}");
                    break;
                case 4:
                    if (num2 == 0)
                    {
                        Console.WriteLine("Division by zero is not allowed.");
                    }
                    else
                    {
                        float div = (float)num1 / num2;
                        Console.WriteLine($"The Division is: {div}");
                    }
                    break;
                default:
                    Console.WriteLine($"{operation} is not a valid operation!");
                    break;
            }

            Console.Write("Do you want to continue (y/n)? ");
            char choose = Console.ReadKey().KeyChar;

            if (choose != 'y' && choose != 'Y')
            {
                break;
            }
        } while (true);
        Console.WriteLine();
        Console.WriteLine("Exit");

    }
}

/* 
       ======== Simple Calculator =======
       1. Addition
       2. Subtraction    
       3. Multiplication
       4. Division

       Choose Your Option: 1
       Please Enter First Number: 6
       Please Enter Second Number: 7

       The Sum of Number 6 and Number 7 is 13.

       Do you want to continue (y/n): y 
       // repeat
       Exit   



       Number into words: 1001 i.e, one thausand one 
    */