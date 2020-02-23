using System;

namespace SingletonDemo
{
    public class Client1
    {
        public void printClient1(string message)
        {
            PrintInfo print1 = PrintInfo.GetInstance;
            print1.PrintDetails(message);
        }        
    }
}
