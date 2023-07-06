using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace grades
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader reading = new StreamReader("students.txt");
            int br2 = 0, br3 = 0, br4 = 0, br5 = 0, br6 = 0;
            string lime = "";
            using (reading)
            {
                while (lime != null)
                {
                    lime = reading.ReadLine();
                    if (lime == "2")
                    {
                        br2++;
                    }
                    else if (lime == "3")
                    {
                        br3++;
                    }
                    else if (lime == "4")
                    {
                        br4++;
                    }
                    else if (lime == "5")
                    {
                        br5++;
                    }
                    else if (lime == "6")
                    {
                        br6++;
                    }
                }
                reading.Close();
                StreamWriter stream = new StreamWriter("output.txt");
                stream.WriteLine("There are: " + br2 + " 2's");
                stream.WriteLine("There are: " + br3 + " 3's");
                stream.WriteLine("There are: " + br4 + " 4's");
                stream.WriteLine("There are: " + br5 + " 5's");
                stream.WriteLine("There are: " + br6 + " 6's");
                stream.Close();
            }
        }
    }
}
