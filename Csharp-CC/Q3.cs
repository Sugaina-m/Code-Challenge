using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenge
{
    internal class MaximumEnrollement 
    {
        public static void CheckMaximunEmrollement(int enrollmentCS, int enrollmentMECH, int enrollmentMET)
        {
            if (enrollmentCS > enrollmentMECH)
            {
                if (enrollmentCS > enrollmentMET)
                {
                    Console.WriteLine("Highest placement in CS");
                }
                else if (enrollmentCS == enrollmentMET)
                {
                    Console.WriteLine("Highest placement in CS \nHighest placement in MET ");
                }
                else
                {
                    Console.WriteLine("Highest placement in MET");
                }
            }
            else if (enrollmentMECH > enrollmentMET)
            {
                if (enrollmentMECH > enrollmentCS)
                {
                    Console.WriteLine("Highest placement in MECH");
                }
                else if (enrollmentMECH == enrollmentCS)
                {
                    Console.WriteLine("Highest placement in MECH \nHighest placement in CS ");
                }
                else
                {
                    Console.WriteLine("Highest placement in CS");
                }
            }
            else if (enrollmentMET > enrollmentCS)
            {
                if (enrollmentMET > enrollmentMECH)
                {
                    Console.WriteLine("Highest placement in MET");
                }
                else if (enrollmentMET == enrollmentMECH)
                {
                    Console.WriteLine("Highest placement in MET \nHighest placement in MECH ");
                }
                else
                {
                    Console.WriteLine("Highest placement in MECH");
                }
            }
            else if (enrollmentCS == enrollmentMECH && enrollmentMECH == enrollmentMET)
            {
                Console.WriteLine("Highest placement in CS \nHighest placement in MECH \nHighest placement in MET");
            }
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Total students placed in CS : ");
            int enrollmentCS = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Total students placed in MECH : ");
            int enrollmentMECH = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Total students placed in MET : ");
            int enrollmentMET = Convert.ToInt32(Console.ReadLine());

            CheckMaximunEmrollement(enrollmentCS, enrollmentMECH, enrollmentMET);
        }
    }
}