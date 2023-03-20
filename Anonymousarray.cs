using System;

namespace Demo
{
    class Anonymousarray
    {
        public void Method1()
        {
           var  arr = new[] {86,12,5,42};
           Array.Sort(arr);
           foreach (var item in arr)
           {
              System.Console.WriteLine(item);
           }
            
        }
       
    }
}