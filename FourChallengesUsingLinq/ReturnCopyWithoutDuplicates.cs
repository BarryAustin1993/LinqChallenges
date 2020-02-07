using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourChallengesUsingLinq
{
    public class ReturnCopyWithoutDuplicates
    {

        //Member Variables (HAS A)
        List<string> names = new List<string>() { "Mike", "Brad", "Nevin", "Ian", "Mike" };
        //Constructor
        public ReturnCopyWithoutDuplicates()
        {

        }

        //Member Methods (CAN DO)
        public List<string> RunChallenge()
        {
            var substring = names.Distinct();
            List<string> string2 = substring.ToList();
            return string2;
        }

    }
}
