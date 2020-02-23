using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonDemo
{
    public class Client2
    {
        public void printClient2(string message)
        {
            PrintInfo print1 = PrintInfo.GetInstance;
            print1.PrintDetails(message);
        }
    }
}
