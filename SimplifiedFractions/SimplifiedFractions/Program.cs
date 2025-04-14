using System.Numerics;
public class SimplifiedFractions
{
public static void Main()
{
        Console.WriteLine("Enter your fraction to simplify it ");
        string fraction = Console.ReadLine();

        string[] fractionParts = fraction.Split("/");

        if(fractionParts.Length != 2)
        {
            Console.WriteLine("Invalid Fraction , try to enter a valid one ");
            return;
        }
        bool isValidNumerator = int.TryParse(fractionParts[0], out int numerator);
        bool isValidDenominator = int.TryParse(fractionParts[1], out int denominator);
        int simplifier = (int) BigInteger.GreatestCommonDivisor(numerator, denominator);

        if(!isValidNumerator || !isValidDenominator)
                {
                    Console.WriteLine("Invalid Fraction , try to enter a valid one ");
                    return;
                }
        if (simplifier == denominator)
            {
             Console.WriteLine(numerator / denominator);  
            }
        else
            {
            numerator /= simplifier;
            denominator /= simplifier;
            Console.WriteLine(numerator + "/" + denominator );
            }
       
            
 }

 
    
}
