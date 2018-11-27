using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int randomNumber = rnd.Next(100);
            int insertedNumber = InsertNumber();

            while (insertedNumber != randomNumber)
            {
                if (insertedNumber < randomNumber)
                {
                    Console.WriteLine("The inserted number is less than the generated one");
                    insertedNumber = InsertNumber();
                }
                else
                {
                    Console.WriteLine("The inserted number is greater than the generated one");
                    insertedNumber = InsertNumber();
                }
            }
            if (insertedNumber == randomNumber)
            {
                Console.WriteLine("You won!");
            }
        }

        static int InsertNumber()
        {
            Console.Write("Insert a number: ");
            string number = Console.ReadLine();
            return int.Parse(number);
        }
    }
}
