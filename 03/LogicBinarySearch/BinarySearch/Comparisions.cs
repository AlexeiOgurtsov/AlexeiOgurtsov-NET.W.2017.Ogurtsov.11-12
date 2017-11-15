using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    class Comparisions
    {
        public static int Default<T>(T array1, T array2) => array1.GetHashCode().CompareTo(array2.GetHashCode());
    }
}
