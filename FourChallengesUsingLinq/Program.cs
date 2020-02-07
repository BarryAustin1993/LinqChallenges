using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourChallengesUsingLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            ReturnSubstringTH rS = new ReturnSubstringTH();
            List<string> string2 = rS.RunChallenge();
            foreach (var item in string2)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();


            ReturnCopyWithoutDuplicates rC = new ReturnCopyWithoutDuplicates();
            List<string> string3 = rC.RunChallenge();
            foreach (var item in string3)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();

            AverageForClassGrads ac = new AverageForClassGrads();
            double result = ac.RunChallenge();
            Console.WriteLine(result);
            Console.ReadLine();

            ReturnStringLetterFrequency rSTLF = new ReturnStringLetterFrequency();

            rSTLF.RunChallenge();
        }

    }
}
