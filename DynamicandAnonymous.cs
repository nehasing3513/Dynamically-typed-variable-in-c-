using System;
using System.Dynamic;
namespace Demo
{
    class DynamicandAnonymous
    {
        public void method1()
        {
           int sum =0;
           dynamic obj1 = new ExpandoObject();
           System.Console.WriteLine("Enter your name: ");
           obj1.name = Console.ReadLine();

           System.Console.WriteLine("Enter your rollno.: ");
           obj1.roll = Convert.ToInt32(Console.ReadLine());

           System.Console.WriteLine("Enter the marks of three subjects:");
           for(int i=0;i<3;i++)
           {
              obj1.subjectmarks = Convert.ToInt32(Console.ReadLine());
               sum = sum+obj1.subjectmarks;
              
              
           }

           System.Console.WriteLine("Name of student: {0}",obj1.name);
           System.Console.WriteLine("Roll no.: {0}",obj1.roll);
           System.Console.WriteLine("total subjectmarks: {0}", sum);

           
        }

    }
}