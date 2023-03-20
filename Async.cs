namespace Demo
{
    class Async
    {
        public async void Method1()
        {
            for(int i=0; i<=6;i++)
            {
                System.Console.WriteLine("calling from method1");
                await Task.Delay(5000);
            }
        }

        public  void Method2()
        {
            for(int i=0; i<=6;i++)
            {
                System.Console.WriteLine("calling from method2");
               
            }
    }
}
}