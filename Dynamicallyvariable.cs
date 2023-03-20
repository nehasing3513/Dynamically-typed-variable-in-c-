using System;
namespace Demo
{
    class BankDemo
    {
       public int AccountNumber;
        public double AccountBalance;
    }
    class Dynamicallyvariable
    {
        public void displayDynamicVariables()
        {
            dynamic x = 100;
            System.Console.WriteLine(x);

             x = "HELLO";
             System.Console.WriteLine(x);

             x = new BankDemo(){AccountNumber = 12339,AccountBalance=10000};
             System.Console.WriteLine(x.AccountNumber);
             System.Console.WriteLine(x.AccountBalance);



        }
    }
}