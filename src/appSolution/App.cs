using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace appSolution
{
    class App : IComparable<App>
    {
        public string name;
        public string developer;
        public double mBytesSize;

        public void setData(string name, string developer, double mBytesSize)
        {
            this.name = name;
            this.developer = developer;
            this.mBytesSize = mBytesSize;
        }

        public int CompareTo(App other)
        {
            var res = mBytesSize.CompareTo(other.mBytesSize);
            
            if (res == 0)
                res = developer.CompareTo(other.developer);
                

            return res;
        }
    }
}
