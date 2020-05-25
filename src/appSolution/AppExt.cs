using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace appSolution
{
    class AppExt
    {
        App[] Applications;
        
        AppExt(int size)
        {
            App[] Applications = new App[size];
        }

        void setData(string name, string developer, int mBytesSize, int num)
        {
            Applications[num].setData(name, developer, mBytesSize);
        }
    }
}
