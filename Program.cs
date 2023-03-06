using System;

class Program
{
    static void Main(string[] args)
    {
        int input;
        ConsoleKeyInfo key;
        do
        {
            input = 0;
            firstReadKey();
            bool isPrime = true;
            for (int i = 2; i <= Math.Sqrt(input); i++)
            {
                if (input % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            if (isPrime && input > 1)
            {
                Console.WriteLine(input + " is a prime number.");
            }
            else
            {
                Console.WriteLine(input + " is not a prime number.");
            }

            Console.Write("Do you want to continue? (y/n): ");
            key = Console.ReadKey(true);
            Console.WriteLine();
        } while (key.KeyChar != 'n' && key.KeyChar != 'N');
    




    // method for add number to terminal
    
    void firstReadKey(){
        while (true)
            {
                key = Console.ReadKey(true);
                if (char.IsDigit(key.KeyChar))
                {
                    input = input * 10 + (int)char.GetNumericValue(key.KeyChar);
                    Console.Write(key.KeyChar);
                }
                else
                {
                    Console.Beep();
                }

                if (key.Key == ConsoleKey.Enter)
                {
                    Console.WriteLine();
                    break;
                }
            }

    }
    
    }
}