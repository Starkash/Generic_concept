using System;

namespace Generic_concept
{
    class Pqr
    {
        public void xy<T>(T[] A)
        {
            foreach (T U in A)

                Console.WriteLine("The value is " + U);



        }
        static void Main(string[] args)
        {
            Pqr B = new Pqr();
            int[] A = { 1, 2, 5 };
            string[] name = { "RAM", "SHYAM" };
            B.xy(A);
            B.xy(name);

        }
    }
}
