using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

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

        public bool exportCsv(string fileName)
        {
            try
            {
                FileStream aFile = new FileStream(fileName, FileMode.OpenOrCreate);
                StreamWriter csvWrite = new StreamWriter(aFile, Encoding.UTF8);
                //aFile.Seek(0, SeekOrigin.End);
                csvWrite.WriteLine("Наименование;Производитель;размер в мБайт;");
                for (int i = 0; i < size; i++)
                    csvWrite.Write(Applications[i].name + ";" + Applications[i].developer + ";" + Applications[i].mBytesSize + "\n");
                csvWrite.Close();

                return true;
            }
            catch (Exception exp)
            {
                Console.Write("Ошибка записи файла. Подробности:" + exp.Message.ToString());
                return false;
            }
        }

        public void Sort()
        {
            Applications.Sort();
        }


    }
}
