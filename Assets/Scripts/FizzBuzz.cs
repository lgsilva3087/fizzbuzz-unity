using System.Text;
using UnityEngine;

/// <summary>
/// This class is used to generate the FizzBuzz solution for a given range.
/// </summary>
public class FizzBuzz : MonoBehaviour
{
    /// <summary>
    /// Gets the FizzBuzz output as a string for a given range:
    /// Concatenation of the numbers from a range defined by "init" and "end" parameters.
    /// But for multiples of three print “Fizz” instead of the number and
    /// for the multiples of five print “Buzz”.
    /// For numbers which are multiples of both three and five print “FizzBuzz”."
    /// </summary>
    /// <param name="init">Start number for the range.</param>
    /// <param name="end">End number for the range.</param>
    /// <returns>Concatenated string with the result</returns>
    public string GetFizzBuzz(int init, int end)
    {
        if (init > end)
            return "The initial value cannot be greater than the end value.";

        StringBuilder fizzBuzzResult = new StringBuilder();

        for (int i = init; i <= end; i++)
        {
            //Divisible by 3 and 5 at the same time
            if (IsDivisible(i, 15))
            {
                
                fizzBuzzResult.Append("FizzBuzz");
            }
            else
            {
                if (IsDivisible(i, 3))
                    fizzBuzzResult.Append("Fizz");
                else if (IsDivisible(i, 5))
                    fizzBuzzResult.Append("Buzz");
                else
                    fizzBuzzResult.Append(i.ToString());;
            }
            
            //Adding a line break if it has not reach the end
            if(i != end)
                fizzBuzzResult.Append("\n");
        }
        
        //Printing to standard console output
        Debug.Log(fizzBuzzResult);
        
        return fizzBuzzResult.ToString();
    }

    /// <summary>
    /// Checks the integer division between dividend and divisor.
    /// </summary>
    /// <param name="dividend">Dividend for the operation</param>
    /// <param name="divisor">Divisor for the operation</param>
    /// <returns></returns>
    public static bool IsDivisible(int dividend, int divisor)
    {
        return dividend % divisor == 0;
    }
}
