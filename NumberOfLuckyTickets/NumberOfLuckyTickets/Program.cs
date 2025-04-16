using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberOfLuckyTickets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of digits on the card ");
            int digits = int.Parse( Console.ReadLine());
            int numberOfLuckTickets = 0;

            if(digits % 2 == 0 ) {
                int halfDigits = digits / 2;
                int max = (int)Math.Pow(10, halfDigits) - 1;

                /* try to generate the first half and keep the sum of digits and compare it 
                 * with every other possibility using another for loop  if  its sum is eqaul then increase the counter */
               
                for (int i = 0; i <= max; i++)
                {
                    string numberWithLeadingZeros1 = i.ToString("D" + halfDigits); 
                    int sumOfFirstPart = numberWithLeadingZeros1.Sum( x => x - '0');
                    for (int j = 0; j <= max; j++)
                    {
                        string numberWithLeadingZeros2 = j.ToString("D" + halfDigits);
                        int sumOfSecondPart = numberWithLeadingZeros2.Sum(x => x - '0');
                        if (sumOfSecondPart == sumOfFirstPart)
                        {
                            numberOfLuckTickets++;
                        }

                    }
                }



                Console.WriteLine(numberOfLuckTickets);

            }
            Console.ReadKey();


        }
    }
}
