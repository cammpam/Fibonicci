using System;

namespace Fibonicci
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Fib find Nth");
            Fib myFib = new Fib();

            //find the 8th number in the fibonicci sequence
            myFib.FindNth(8);
            Console.Read();
        }
    }
    public class Fib
    {
        //set a counter, and f which defines the number of the sequence we are looking for.
        int count;
        int f;
        public void FindNth(int n)
        {
            f = n;
            //print the values for the recursive find() method
            Console.WriteLine(Find(0, 1));
        }

        //recursive method to find value for each fib senquence
        public int Find(int a, int b)
        {
            //When count is equal to the number in the sequence your trying to find return that value return the number.
            if (count == f)
            {
                return b;
            }

            //if not then assign a+b to b and increment count.
            b = a + b;
            count++;

            //After the count increments if f is equal to count return b which is equal to a+b
            if (count == f)
            {
                return b;
            }

            //if count is stil not equal to f, increment count and rerun the Find method starting where a and b left off.
            a = b - a;
            count++;
            return Find(a, b);
        }
    }
}
