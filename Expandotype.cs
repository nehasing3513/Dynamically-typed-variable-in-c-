using System.Dynamic;
namespace Demo
{
    class Expandodemo
    {
        public void demoMethod1()
        {
            dynamic obj1 = new ExpandoObject();
            obj1.sample = "This is a Dynamic Property";
            System.Console.WriteLine(obj1.sample);
            System.Console.WriteLine(obj1.sample.GetType());
            // obj1.Age = 20;           
            // System.Console.WriteLine("The age of the person is : {0}",obj1.Age); 

            //using Lamda expressions
            obj1.msg = "Hello";
            System.Console.WriteLine("Before calling the msgfunc , the msg was: {0}", obj1.msg);
            obj1.msgfunc = (Action)(() => { obj1.msg = "HELLO JOHN GOOD MORNING"; });
            obj1.msgfunc();
            System.Console.WriteLine("After the msgfunc bing called the msg will be: {0}", obj1.msg);
        }
    }
    class parameterDemo
    {
        public void displayingdemo()
        {
            //using parameter 
            dynamic manager = new ExpandoObject();
            manager.Name = "Suresh";
            manager.Age = 35;
            manager.Teamsize = 10;
            dynamic customer = new ExpandoObject();
            customer.Name = "Mahesh";
            customer.Age = 45;
            System.Console.WriteLine("Displaying the details of manager:- ");
            writeperson(manager);
            System.Console.WriteLine("Displaying the details of customer:- ");
            writeperson(customer);
        }
        public void writeperson(dynamic person)
        {
            System.Console.WriteLine(person.Name);
            System.Console.WriteLine(person.Age); // 
            System.Console.WriteLine(person.Teamsize);
        }
    }
}