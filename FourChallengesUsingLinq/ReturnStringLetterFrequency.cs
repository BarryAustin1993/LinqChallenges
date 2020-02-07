using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourChallengesUsingLinq
{
    public class ReturnStringLetterFrequency
    {

        //Member Variables (HAS A)
        string input = "Terrill";
        //Constructor
        public ReturnStringLetterFrequency()
        {

        }

        //Member Methods (CAN DO)
        public void RunChallenge()
        {
            var result = input.ToUpper().Select(letter => letter)
                                  .GroupBy(letter => letter)
                                  .OrderBy(letter => letter.Key);
            var output = result.Select(letter => letter.Key.ToString() + letter.Count());

            Console.WriteLine($"{String.Join("", output)}");
            Console.ReadLine();
        }

    }
}
