// See https://aka.ms/new-console-template for more information
using System;
namespace Demo
{
    class abc
    {
        static void Main(string[] args)
        {
            // System.Console.WriteLine("Hello");

            //Dynamicallyvariable
            // Dynamicallyvariable obj = new Dynamicallyvariable();
            // obj.displayDynamicVariables();

            //Demotypes            
            // typeAnonymous obj = new typeAnonymous();
            // obj.method1();

            //Expandodemo  
            // Expandodemo obj = new Expandodemo();
            // obj.demoMethod1();
            // parameterDemo obj1 = new parameterDemo();
            // obj1.displayingdemo();


            //Async
            // Async obj = new Async();
            // obj.Method1();
            // obj.Method2();
            // System.Console.ReadLine();

            //AnonymousArray
            // Anonymousarray obj = new Anonymousarray();
            // obj.Method1();

            //DynamicandAnonymous
            // DynamicandAnonymous obj1 = new DynamicandAnonymous();
            // obj1.method1();

            //Tupledemo
            // restuple obj = new restuple();
            // obj.Method2();

            //funcdemo using Anonymousmethod
            //using func
            Func<int, int, int> Addition = delegate (int param1, int param2)
           {
                return param1 + param2;
           };
            int result = Addition(10, 20);
            Console.WriteLine($"Addition = {0}",result);

            //using action 
            Action<int,int> multiplication = delegate(int num1,int num2)
            {
                System.Console.WriteLine("The multiplication of two nos. {0}", num1*num2);
            };
            multiplication(10,20);

            //using predicate
            Predicate<string> str = delegate(String str)
            {
                bool status = false;
                if(str.Length>5)
                   status =  true;
                return status;
            };

            System.Console.WriteLine(str("hello world"));

            //Lamda expression
            Func<string,bool>checkifApple = modelname=>{
                if(modelname =="I phonex")
                    return true;

                else 
                   return false;
            };
            bool result1 = checkifApple("I phonex");  
            if (result1) 
             Console.WriteLine("It's an IPhone");  

         }
         


    }
}
