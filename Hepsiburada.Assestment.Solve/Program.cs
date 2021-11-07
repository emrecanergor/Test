using System;
using System.Collections;

namespace Hepsiburada.Assestment.Solve
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack st = new Stack();
            st.Push(1);
            st.Push(1.1);
            st.Push('z');
            st.Push("Hello");

            foreach (var item in st)
            {
                Console.WriteLine(item);
            }
        }

        static void pythagoreanTriplets(int limit)
        { 
            // triplet: a^2 + b^2 = c^2
            int a, b, c = 0;

            // loop from 2 to max_limitit
            int m = 2;

            // Limiting c would limit
            // all a, b and c
            while (c < limit)
            {

                // now loop on j from 1 to i-1
                for (int n = 1; n < m; ++n)
                { 
                    // Evaluate and print triplets using the relation between a, b and c 
                    a = m * m - n * n;
                    b = 2 * m * n;
                    c = m * m + n * n;

                    if (c > limit)
                        break;

                    Console.WriteLine(a + " "
                                + b + " " + c);
                }
                m++;
            }
        }
    }


    public interface IOne { void DoSomething(string x); }
    public interface ITwo { void DoSomething(string x); }

    public class Sample : IOne, ITwo
    {
        public void DoSomething(string x)
        {
            throw new NotImplementedException();
        }
    }
}
