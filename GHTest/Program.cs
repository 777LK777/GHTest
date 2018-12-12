using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows;

namespace GHTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, GitHub!!!");
            Thread.Sleep(1000);
            Console.Write("\a");
            Thread.Sleep(3000);
        }
    }
}
