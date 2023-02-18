using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{

    class Parser
    {

        public static void InputParser(List<string> input)
        {
            string verb;
            string noun;
            List<string> commands = new List<string> {"take", "drop"};
            List<string> objects = new List<string> {"flower"};


            if (input.Count != 2)
            {
                Console.WriteLine("Only 2 word commands allowed!");
            }
            else
            {
                verb = input[0];
                noun = input[1];
                if (!commands.Contains(verb))
                {
                    Console.WriteLine(verb + " is not a known verb!");
                }
                if (!objects.Contains(noun))
                {
                    Console.WriteLine(noun + " is not a known noun!");
                }
            }
        }

        public static string RunCommand(string strInput)
        {
            char[] delims = {' ', '.'};
            List<string> strList;
            string s = "Okay.";
            string strLow = strInput.Trim().ToLower();

            if (strLow != "q")
                if (strLow == "") 
                {
                    s = "You must enter a command.";
                }
                else
                {
                    strList = new List<string>(strLow.Split(delims, StringSplitOptions.RemoveEmptyEntries));
                    InputParser(strList);
                }
                return s;
        }

    }

}