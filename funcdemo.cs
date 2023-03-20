using System;
//all the three are generic delegate. Without the use of the delgate explicitly,we can make use of the three predefined delegates.
namespace Demo
{
    class funcdemo
    {
        public double method1(int x, double y, float z)
        {
            return x + y + z;
        }
        public void method2(int x, double y, float z)
        {
            System.Console.WriteLine("REsult from 2nd Method2: {0}", x + y + z);
        }
        public bool method3(String str)
        {
            if (str.Length > 5)
                return true;
            return false;
        }
        public void Method()
        {
            Func<int, double, float, double> obj1 = method1; //use func when there are parameters and a return type,i.e when our method is value raturning 
            double res = obj1.Invoke(100, 193.56, 3.25f);
            System.Console.WriteLine("Result from 1st method1 : {0}", res);
            
            Action<int, double, float> obj2 = method2; //use action parameter or inputs but no output or no return type, i.e used when the method is non-value returning 
            obj2.Invoke(100, 193.56, 3.25f);
            
            Predicate<String> obj3 = method3; //used when method return type will be boolean, and can only single parameter            
            bool status = obj3.Invoke("Hello");
            // bool status = obj3.Invoke("Hello world"); 
            System.Console.WriteLine(status);
        }
    }
}