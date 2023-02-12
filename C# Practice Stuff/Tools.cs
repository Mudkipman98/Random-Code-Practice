using System;
using System.Collections.Generic;

namespace Program
{

    public class Tools
    {
        public static void ReadKeyClear()
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }

        public static string StrGetResponse()
        {
            string strSubmission = Console.ReadLine();

            while (strSubmission == "")
            {
                Console.Write("Please input a valid string: ");
                strSubmission = Console.ReadLine();
            }

            return strSubmission;
        }

        public static int IntGetResponse()
        {
            int intSubmission;

            string strSubmission = Console.ReadLine();

            bool success = int.TryParse(strSubmission, out int result);

            while (!success)
            {
                Console.Write("Please input a whole number: ");
                strSubmission = Console.ReadLine();
                success = int.TryParse(strSubmission, out result);
                
            }
            
            intSubmission = Convert.ToInt32(strSubmission);
            return intSubmission;
        }

    }

}