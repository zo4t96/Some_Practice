using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewTest
{
    public class EqualTest
    {
        string a;
        int b;

        public EqualTest()
        {
            a = "string";
            b = 100;
        }

        public EqualTest(string c, int d)
        {
            a = c;
            b = d;
        }

        public override bool Equals(object obj)
        {
            return ((EqualTest)obj).a == this.a && ((EqualTest)obj).b == this.b;
        }

        // Should override GetHashCode() when you override Equals()
        public override int GetHashCode()
        {
            //return base.GetHashCode(); 
            return new { a, b }.GetHashCode(); // Cool!
            //return a.GetHashCode() + b.GetHashCode(); // Work
        }

        public static void RunEqualTest()
        {
            EqualTest test = new EqualTest();
            EqualTest test2 = new EqualTest();
            EqualTest test3 = new EqualTest("string", 100);
            EqualTest test4 = test3;

            Console.WriteLine($"test == test2: + { test == test2 }");
            Console.WriteLine($"test.Equals(test2): + { test.Equals(test2) }");
            Console.WriteLine($"Object.Equals(test, test2): + { Object.Equals(test, test2) }");

            Console.WriteLine();

            Console.WriteLine($"test == test3: + { test == test3 }");
            Console.WriteLine($"test.Equals(test3): + { test.Equals(test3) }");
            Console.WriteLine($"Object.Equals(test, test2): + { Object.Equals(test, test3) }");

            Console.WriteLine();

            Console.WriteLine($"test3 == test4: + { test3 == test4 }");
            Console.WriteLine($"test3.Equals(test4): + { test3.Equals(test4) }");
            Console.WriteLine($"Object.Equals(test3, test4): + { Object.Equals(test3, test4) }");

            Console.WriteLine();

            List<EqualTest> list = new List<EqualTest>();
            list.Add(test);
            list.Add(test2);
            list.Add(test3);
            list.Add(test4);
            HashSet<EqualTest> set = new HashSet<EqualTest>();
            set.Add(test);
            set.Add(test2);
            set.Add(test3);
            set.Add(test4);

            foreach (EqualTest a in list)
            {
                Console.WriteLine($"List GetHashCode():  { a.GetHashCode() }");
            }

            foreach (EqualTest a in set)
            {
                Console.WriteLine($"List GetHashCode():  { a.GetHashCode() }");
            }
            Console.WriteLine($"set.Count:  { set.Count }");
        }
    }
}
