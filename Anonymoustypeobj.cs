using System;
namespace Demo
{
    class Demotype
    {
        public String DisplayName()
        {
            return "John";
        }
        public int DisplayPersonId()
        {
            return 121;
        }
        public String DisplayLocation()
        {
            return "Kolkata";
        }
    }
    class typeAnonymous
    {
        public void method1()
        {
            Demotype obj = new Demotype();
            var p = new { personName = obj.DisplayName(), personID = obj.DisplayPersonId(), personLocation = obj.DisplayLocation() };
            System.Console.WriteLine("Displaying Persons Details: ");

            System.Console.WriteLine("Name: {0}", p.personName);
            System.Console.WriteLine("ID: {0}", p.personID);
            System.Console.WriteLine("Location: {0}", p.personLocation);
        }
    }
}