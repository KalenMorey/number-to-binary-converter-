using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            // ask user to enter a number
            Console.Write("Please Enter A Number");
            // grab the number 
            string enteredNumber = Console.ReadLine();

            // Converts string into a number returns error if user enters something else 
            int wholeNumber = 0;
            if (!int.TryParse(enteredNumber, out wholeNumber))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("There was na error converting what you typed to a number.");
                Console.ResetColor();
                Console.ReadKey();
                return;
            }

            string binaryNumber = ConvertIntToBinary(wholeNumber);

            Console.Write("Your converted number is");
            Console.Write(binaryNumber);

            Console.WriteLine("\n Hit <Enter> to exit. ");
            Console.Read();
        }


        public static string ConvertIntToBinary(int number)
        {
            int bits = (sizeof(int) * 8); // loops until it reaches a 32 bit number 
            char[] result = new char[bits]; // Array that holds binary numbers

            while (bits > 0)
            {
                bits = bits - 1;
                int remainder = number % 2;
                    Console.WriteLine(remainder);

                if (remainder == 1)
                    result[bits] = '1';
                
                else
                    result[bits] = '0';

                number = number / 2;
            }
            return new string(result).TrimStart('0');
        }
        }    }

        
    

