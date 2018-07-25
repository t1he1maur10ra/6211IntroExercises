using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1
{
    public class ProgramQ1
    {
        public static void Main()
        {
            Console.WriteLine("This project will display the 3 times table up to 12....");
            for(int i=0;i<=12;i++)
            {
                Console.WriteLine("3 x " + i + " = " + (3 * i));
            }
            Console.WriteLine("Press enter to exit this part of the app.....");
            Console.ReadLine();
        }
    }
}
