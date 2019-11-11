using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SmallBasic.Library;
using EV3Communication;

namespace SmallBasicEV3Extension
{
    /// <summary>
    /// Methods for working with 1 dimension arrays
    /// </summary>
    [SmallBasicType]
    public static class Matrix
    {
        /// <summary>
        /// Creates a 1 dimensional array of the specified size and fills it with the specified values.
        /// </summary>
        /// <param name="size">Size array</param>
        /// <param name="value">Value to fill</param>
        /// <returns>Created array</returns>
        public static Primitive Init(Primitive size, Primitive value)
        {
            int arr = 0;
            int a = size;
            int b = value;
            return new Primitive(arr);
        }
    }
}
