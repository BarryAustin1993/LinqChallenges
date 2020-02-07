using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourChallengesUsingLinq
{
    public class ReturnSubstringTH
    {

        //Member Variables (HAS A)
        List<string> words = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics" };
        //Constructor
        public ReturnSubstringTH()
        {
            
        }

        //Member Methods (CAN DO)
        public List<string> RunChallenge()
        {
            var substring = words.Where(w => w.Contains("th"));
            List<string> string2 = substring.ToList();
            return string2;
        }

    }
}
