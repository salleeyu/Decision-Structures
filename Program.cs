using System;

namespace Decision.Structures
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleIF();
        }

        static void SimpleIF()
        {
            Console.WriteLine("Enter a number:");
            int yourNum = int.Parse(Console.ReadLine());

            if (yourNum < 100)
            {
                Console.WriteLine("Your number is less than 100.");
            }
            else if (yourNum <1000)
            {
                Console.WriteLine("Your number is less than 1000.");
            }
            else
            {
                Console.WriteLine("Your number is greater than 1000.");
            }
          
        }
               
        

        static void ComplexIF()
        {
            Console.WriteLine("Enter a character:");
            char yourChar = (char)Console.Read();

            if (char.IsLetter(yourChar) || char.IsLetter(yourChar))
            {
                if (char.IsUpper(yourChar))
                {
                    Console.WriteLine("Your char is UPPERCASE.");
                }
                else if (char.IsLower (yourChar))
                {
                    Console.WriteLine("Your char is lowercase.");
                }
                else if (char.IsDigit(yourChar))
                    Console.WriteLine("Your char is a number.");
            }
            else
            {
                Console.WriteLine("Your char is not a letter or number!");
            }
        }
    }

}
