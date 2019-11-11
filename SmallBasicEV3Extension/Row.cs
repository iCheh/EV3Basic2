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
    public static class Row
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

        /// <summary>
        /// Delete a 1 dimensional array.
        /// </summary>
        /// <param name="array">Array</param>
        public static void Delete(Primitive array)
        {
        }

        /// <summary>
        /// Read index value from 1 dimensional array.
        /// </summary>
        /// <param name="array">Array</param>
        /// <param name="index">Index</param>
        /// <returns>Value</returns>
        public static Primitive Read(Primitive array, Primitive index)
        {
            int value = 0;
            int a = array;
            int b = index;
            return new Primitive(value);
        }

        /// <summary>
        /// Write index value to 1 dimensional array.
        /// </summary>
        /// <param name="array">Array</param>
        /// <param name="index">Index</param>
        /// <param name="value">Value</param>
        public static void Write(Primitive array, Primitive index, Primitive value)
        {
        }

        /// <summary>
        /// Get size 1 dimensional array.
        /// </summary>
        /// <param name="array">Array</param>
        /// <returns>Size</returns>
        public static Primitive Size(Primitive array)
        {
            int value = 0;
            int a = array;
            return new Primitive(value);
        }

        /// <summary>
        /// Resize 1 dimensional array.
        /// </summary>
        /// <param name="array">Array</param>
        /// <param name="size">New size array</param>
        public static void Resize(Primitive array, Primitive size)
        {
        }
    }
}
