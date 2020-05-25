using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace appSolution
{
    class AppExt
    {
        List<App> Applications;
        int size = 0;

        public AppExt(int size)
        {
            //List App[] Applications = new App[size];
            Applications = new List<App>();
            this.size = size;
            for (int i = 0; i < size; i++)
                Applications.Add(new App());
        }

        public void inputData()
        {
            for (int i = 0; i < size; i++)
            {
                Console.Write("Введите наименование: ");
                string name = Console.ReadLine();
                Console.Write("Введите производителя: ");
                string developer = Console.ReadLine();
                Console.Write("Введите размер в мБайт: ");
                double sizeApp = Convert.ToDouble(Console.ReadLine());
                Applications[i].setData(name, developer, sizeApp);
            }
        }

        public void print()
        {
            for (int i = 0; i < size; i++)
                Console.Write("Наименование: " + Applications[i].name + "; Производитель: " + Applications[i].developer + "; размер в мБайт: " + Applications[i].mBytesSize+"\n");
            Console.Write("\n");
        }

        public void Sort()
        {
            Applications.Sort();
        }


    }
}
