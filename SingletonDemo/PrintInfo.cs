using System;

namespace SingletonDemo
{
    /// <summary>
    ///    This is a Singleton Class which prints info. A Sample Demo class
    ///    Should be sealed though the construcor is private because nested classes can ruin singleton principle
    /// </summary>
    public sealed class PrintInfo
    {
        private static int counter = 0;

        //Lazy Initializatiion -- Takes thread safety internally 
        //private static readonly Lazy<PrintInfo> instance = new Lazy<PrintInfo>(()=>new PrintInfo());
        //public static PrintInfo GetInstance => instance.Value;

        //Dynamic Initialization
        public static PrintInfo GetInstance { get; } = new PrintInfo();

        //This is previous way which is reduced to above opeartion

        //private static readonly PrintInfo instance = new PrintInfo();
        //public static PrintInfo GetInstance => instance;
        //{
        //    get
        //    {
        //        return instance.Value;
        //    }
        //}
        private PrintInfo()
        {
            counter++;
            Console.WriteLine("Counter value is " + counter.ToString());
        }
        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }
}
