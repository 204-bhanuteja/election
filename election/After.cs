using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace election
{
    internal class after189
    {
        public static void Main()
        {

        }

        private static int[] GetVotingEligibilityYear(int[] personYearOfBirthArray)
        {
            int presentYear = 2022;
            int[] output = new int[personYearOfBirthArray.Length];
            for (int i = 0; i < personYearOfBirthArray.Length; i++)
            {
                int age = presentYear - personYearOfBirthArray[i];
                if (age >= 18 && age < 150)
                {
                    output[i] = presentYear;
                }
                else if (age < 18 && age >= 0)
                {
                    output[i] = presentYear + (18 - age);
                }
                else
                {
                    output[i] = 0;
                }

            }
            return output;

        }
    }
}


