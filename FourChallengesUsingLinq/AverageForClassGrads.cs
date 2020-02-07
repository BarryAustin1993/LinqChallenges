using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourChallengesUsingLinq
{
    public class AverageForClassGrads
    {

        //Member Variables (HAS A)
        List<string> Grades = new List<string>()
        {
            "80,100,92,89,65",
            "93,81,78,84,69",
            "73,88,83,99,64",
            "98,100,66,74,55"
        };

        //Constructor
        public AverageForClassGrads()
        {

        }

        //Member Methods (CAN DO)
        //public double RunChallenge()
        //{
        //    List<string[]> classGradesTwo = new List<string[]>();

        //    foreach (string studentGrades in classGrades)
        //    {
        //       string[] strudentGradesTwo = studentGrades.Split(",".ToArray());
        //        classGradesTwo.Add(strudentGradesTwo);
        //    }

        //    foreach (string[] studentGradesTwo in classGradesTwo)
        //    {
        //        List<int> studentGradeInts = studentGradesTwo.Select(int.Parse).ToList();
        //        classGradesInt.Add(studentGradeInts);
        //    };
        //    foreach (List<int> studentGradeInts in classGradesInt)
        //    {
        //        studentGradeInts.Remove(studentGradeInts.Min());
        //        double studentaverage = studentGradeInts.Average();
        //        classaverages.Add(studentaverage);
        //    }

        //    double average = classaverages.Average();

        //    return average;
        //}
        public double RunChallenge()
        {

            return Grades.Select(wholeClass => wholeClass.Split(','))
                                                  .Select(student => student.Select(assignment => Double.Parse(assignment)) 
                                                  .OrderBy(assignment => assignment)
                                                  .Skip(1))
                                                  .SelectMany(x => x).Average();
        }                          

    }
}
