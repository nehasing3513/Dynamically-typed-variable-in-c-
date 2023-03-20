
using System;
//when we want to return more than one value
namespace Demo
{
    class DemoTuple
    {
        public (int, int) Method1(int a, int b)
        {
            int c = a + b;
            int d = a * b;
            return (c, d);

        }
    }
    class restuple
    {
        public void Method2()
        {
            DemoTuple obj = new DemoTuple(); 
            // var td = obj.Method1(100, 25);
            // System.Console.WriteLine("sum:{0}", td.Item1);
            // System.Console.WriteLine("product: {0}", td.Item2);

            //one more way to display value
            var(sum,product) = obj.Method1(100,25);
            System.Console.WriteLine("sum:{0}", sum);
            System.Console.WriteLine("product: {0}", product);

        }
    }
}

