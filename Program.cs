using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_4;

namespace Task_5
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("\n\t\t\t  Part1. Point 6.\n\t\t\t__________________");

            Set<int> set1 = new Set<int>();
            Set<int> set2 = new Set<int>();
            set1.setList = new List<int>() { 3, 4, 7, 2, -3 };
            set2.setList = new List<int>() { 6, 3, 1, -3, 8, 13, 2 };
            set1.Count = 5;
            set1.Name = "Set1";
            set2.Count = 7;
            set2.Name = "Set2";

            set1.GetInfo();
            set2.GetInfo();

            Set<int> set3 = set1.Union(set2);
            set3.Name = "Union";
            set3.GetInfo();

            //set1.ShowClassType();
            //set1.ShowParamType();

            Set<int> set4 = set1.Intersect(set2);
            set4.Name = "Intersect";
            set4.GetInfo();

            Set<int> set5_1 = set1.Difference(set2);
            set5_1.Name = "Difference(Set1)";
            set5_1.GetInfo();

            Set<int> set5_2 = set2.Difference(set1);
            set5_2.Name = "Difference(Set2)";
            set5_2.GetInfo();

            Set<int> set6 = set1.SymmetricDifference(set2);
            set6.Name = "Symmetric Difference";
            set6.GetInfo();

            Console.ReadKey();
            Console.Clear();


            Console.WriteLine("\n\t\t\t  Part1. Point 7.\n\t\t\t___________________");

            Set<int> set7 = new Set<int>();
            Set<int> set8 = new Set<int>();
            Set<int> set9 = new Set<int>();
            set7.setList = new List<int>() { 2, 1, 6 };
            set8.setList = new List<int>() { 3, 5, 8, 4 };
            set9.setList = new List<int>() { 3, 4, 5, 6, 7, 8 };
            
            set7.Count = 3;
            set8.Count = 4;
            set9.Count = 6;
            set7.Name = "Set7";
            set8.Name = "Set8";
            set9.Name = "Set9";

            set7.GetInfo();
            set8.GetInfo();
            set9.GetInfo();

            Console.WriteLine(set7.IsSubsetOf(set9));
            Console.ResetColor();
            Console.WriteLine(set8.IsSubsetOf(set9));
            Console.ResetColor();

            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("\n\t\t\t  Part2. Point 1.\n\t\t\t___________________");
            Set<int> set30 = set1 + set2;
            set30.Name = "Union2";
            set30.GetInfo();

            if (set3.Equals(set30))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"\t\t Correct Union.");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\t\t Not correct Union.");
                Console.ResetColor();
            }

            Set<int> set40 = set1 * set2;
            set40.Name = "Intersect2";
            set40.GetInfo();

            if (set4.Equals(set40))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\t\t Correct Intersect.");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\t\t Not correct Intersect.");
                Console.ResetColor();
            }

            Set<int> set50_1 = set1 - set2;
            set50_1.Name = "Difference2";
            set50_1.GetInfo();

            if (set5_1.Equals(set50_1))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\t\t Correct Difference (for set1).");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\t\t Not correct Difference (for set1).");
                Console.ResetColor();
            }

            Set<int> set50_2 = set2 - set1;
            set50_2.Name = "Difference3";
            set50_2.GetInfo();

            if (set5_2.Equals(set50_2))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\t\t Correct Difference (for set2).");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\t\t Not correct Difference (for set2).");
                Console.ResetColor();
            }

            Set<int> set60 = set1 % set2;
            set60.Name = "Symmetric Difference2";
            set60.GetInfo();

            if (set6.Equals(set60))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\t\t Correct Symmetric Difference.");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\t\t Not correct Symmetric Difference.");
                Console.ResetColor();
            }

            Console.WriteLine(set7 > set9);
            Console.ResetColor();
            Console.WriteLine(set8 > set9);
            Console.ResetColor();

            Console.ReadKey();
            Console.Clear();


            Console.WriteLine("\n\t\t  Part2. Point 2. (FOR STRING Type.) \n\t\t_____________________________________");

            Set<string> set_string1 = new Set<string>();
            Set<string> set_string2 = new Set<string>();
            set_string1.setList = new List<string>() { "a", "b", "c", "e"};
            set_string2.setList = new List<string>() { "a", "b", "d", "f", "a", "w" };
            set_string1.Count = set_string1.setList.Count();
            set_string1.Name = "String1";
            set_string2.Count = set_string2.setList.Count(); ;
            set_string2.Name = "String2";

            Set<string> set_string0 = new Set<string>();
            set_string0.Name = "String3";
            set_string0.setList = new List<string>() { "a", "b", "c", "e", "g", "a", "y" };
            set_string0.Count = set_string0.setList.Count();

            set_string1.GetInfo();
            set_string2.GetInfo();
            set_string0.GetInfo();

            Set<string> set_string3 = set_string1.Union(set_string2);
            set_string3.Name = "Union";
            set_string3.GetInfo();

            Set<string> set_string4 = set_string1*set_string2;
            set_string4.Name = "Intersect";
            set_string4.GetInfo();

            Set<string> set_string5_1 = set_string1 - set_string2;
            set_string5_1.Name = "Difference (set1)";
            set_string5_1.GetInfo();

            Set<string> set_string5_2 = set_string2.Difference(set_string1);
            set_string5_2.Name = "Difference (set2)";
            set_string5_2.GetInfo();

            Set<string> set_string6 = set_string1 % set_string2;
            set_string6.Name = "Symmetric Difference";
            set_string6.GetInfo();                              
            
            Console.WriteLine(set_string1 > set_string0);
            Console.ResetColor();
            Console.WriteLine(set_string2 > set_string0);
            Console.ResetColor();

            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("\n\t      Part2. Point 2. (FOR HELICOPTERS Type.)\n\t     _________________________________________");

            Set<Helicopter> set_h1 = new Set<Helicopter>();
            Set<Helicopter> set_h2 = new Set<Helicopter>();
            Set<Helicopter> set_h0 = new Set<Helicopter>();

            Helicopter helicopter1 = new Helicopter("~~ Jonny ~~", "Boeing Sikorsky RAH - 66 Comanche", 4218, 15);
            Helicopter helicopter2 = new Helicopter("~~ April ~~", "McDonnell Douglas AH-64 Apache", 5500, 20);
            Helicopter helicopter3 = new Helicopter("~~ Martin ~~", "Boeing Sikorsky RAH - 66 Comanche", 4218, 15 );
            Helicopter helicopter4 = new Helicopter("~~ Reggy ~~", "Boeing Sikorsky RAH - 66 Comanche", 5500, 20);
            Helicopter helicopter5 = new Helicopter("~~ Reggy ~~", "Boeing Sikorsky RAH - 66 Comanche", 5500, 20);

            set_h1.setList = new List<Helicopter>() { helicopter1, helicopter2, helicopter3, helicopter5 };
            set_h1.Name = "Helicopters set#1";
            set_h1.Count = set_h1.setList.Count();
            set_h2.setList = new List<Helicopter>() { helicopter4, helicopter1};
            set_h2.Name = "Helicopters set#2";
            set_h2.Count = set_h2.setList.Count();
            set_h0.setList = new List<Helicopter>() { helicopter1, helicopter2, helicopter3, helicopter4};
            set_h0.Name = "Helicopters set#3";
            set_h0.Count = set_h0.setList.Count();

            Set<Helicopter> set_h3 = set_h1.Union(set_h2);
            set_h3.Name = "Union";
            set_h3.GetInfo();

            Console.ReadKey();

            Set<Helicopter> set_h4 = set_h1 * set_h2;
            set_h4.Name = "Intersect";
            set_h4.GetInfo();

            Console.ReadKey();

            Set<Helicopter> set_h5_1 = set_h1 - set_h2;
            set_h5_1.Name = "Difference (set1)";
            set_h5_1.GetInfo();

            Console.ReadKey();

            Set<Helicopter> set_h5_2 = set_h2.Difference(set_h1);
            set_h5_2.Name = "Difference (set2)";
            set_h5_2.GetInfo();

            Console.ReadKey();

            Set<Helicopter> set_h6 = set_h1 % set_h2;
            set_h6.Name = "Symmetric Difference";
            set_h6.GetInfo();

            Console.ReadKey();

            Console.WriteLine(set_h1> set_h2);
            Console.ResetColor();
            Console.WriteLine(set_h1 > set_h3);
            Console.ResetColor();

            //set_h1.ShowClassType();
            //set_h1.ShowParamType();

            Console.ReadKey();
            Console.Clear();

        }
    }
}
