using System;
using System.Threading.Tasks;

namespace SingletonDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating a parallel call

            Parallel.Invoke(() => PrintInfo1(),
                () => PrintInfo2());
            // Calling a Class by creating an object

            //Calling Client one
            //Client1 c1 = new Client1();
            //c1.printClient1("This is Client one Message to Print");

            ////Calling Client two
            //Client2 c2 = new Client2();
            //c1.printClient1("This is Client two Message to Print");



            Console.ReadLine();
        }

        private static void PrintInfo2()
        {
            PrintInfo pinfo1 = PrintInfo.GetInstance;
            pinfo1.PrintDetails("This is Second Print Info");
        }

        private static void PrintInfo1()
        {
            PrintInfo pinfo = PrintInfo.GetInstance;
            pinfo.PrintDetails("This is First Print Info");
        }
    }
}
