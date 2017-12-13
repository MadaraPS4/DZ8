using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Домашнее_задание_8
{
    class MyClass
    {
        private int[] arr = new int[50];

        public int this[int i]
        {
            get { return arr[i]; }
            set { arr[i] = value*value; }
        }
    }
}
