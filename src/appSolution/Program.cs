using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace appSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество приложений: ");
            int n = Convert.ToInt32(Console.ReadLine());
            AppExt appExt = new AppExt(n);
            appExt.inputData();
            //appExt.print();
            appExt.Sort();
            //appExt.print();
            appExt.exportCsv("oot.csv");
            //Console.ReadKey();
        }
    }
}
