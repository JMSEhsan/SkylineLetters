using System;

namespace SkylineLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            String name = "Ehsan Jalali";
            String skylineWord = skylineConvert(name);

            Console.WriteLine(name + " spelled in skyline format is " + skylineWord);
            Console.ReadLine();

        }

        private static string skylineConvert(string name)
        {
            String x = "";
            for (int i = 0; i < name.Length; i++)
            {
                if(i % 2 == 0)
                {
                    // even vlue for i
                    x += name[i].ToString().ToUpper();

                }
                else
                {
                    // odd value for i
                    x += name[i].ToString().ToLower();
                }
            }

            return x;
        }
    }
}
