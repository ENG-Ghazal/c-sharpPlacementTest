using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumOccurrence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your sentence : ");
            string text = Console.ReadLine();
            text = string.Join("",text.Split(' '));
     

            List <(char ch , int num )>  charOcuurence = new  List <(char, int)> ();

            for (int i=0; i< text.Length; i++)
            {
                int index = charOcuurence.FindIndex(x => x.ch == text[i]);

                if (index != -1){
                    var charElement = charOcuurence[index];
                    charOcuurence[index] = (charElement.ch , charElement.num+1); 
                }
                else
                {
                    charOcuurence.Add((text[i], 1));
                }
                
               

            }
          /*  foreach (var item in charOcuurence)
            {
                Console.WriteLine($" character is {item.ch} and ocuurence is {item.num}");
            }*/
            string results = "";

            int maxOccure = charOcuurence.Max(x => x.num);
            if( maxOccure == 1)
            {
                results = "No repitition";
            }
            else
            {
                var maxOcuurenceChars = charOcuurence.Where(x => x.num == maxOccure)
                                                     .Select(x => x.ch);
               
              
                      results +=  string.Join(",", maxOcuurenceChars);
                         
                  
            }

            Console.WriteLine(results);
            Console.ReadLine();
        }
    }
}
