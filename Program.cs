using System;

namespace Liskov_Substitution_Principle
{
    // L : Liskov Substitution Principle (LSP)
    // Derived class must be completely replaced of their base class.

    // This is Base Class
    public class ReadLog 
    {
        public virtual void ReadLogMsg()
        {
            Console.WriteLine("Read log from .txt");
        }
    }
    // This is Derived Class
    public class ReadXML : ReadLog
    {
        public override void ReadLogMsg() // Method replace the base class method. This is LSP
        {
            Console.WriteLine("Read log from .xml");
        }
    }
    // This is Derived Class
    public class ReadSQL : ReadLog
    {
        public void ReadLogMsgSQL() // Method not replace the base class method. This is not LSP.
        {
            Console.WriteLine("Read log from .SQL");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
