using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace appSolution
{
    class App
    {
        string name;
        string developer;
        int mBytesSize;

        public void setData(string name, string developer, int mBytesSize)
        {
            this.name = name;
            this.developer = developer;
            this.mBytesSize = mBytesSize;
        }
    }
}
