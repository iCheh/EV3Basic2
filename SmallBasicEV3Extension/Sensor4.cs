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
    /// Access sensors that are attached to the brick.
    /// To specify the sensor use the port number which is printed below the socket on the brick (for example 1).
    /// To access sensors of further bricks that are connected via daisy-chaining, use the next higher numbers instead (5 - 8 will access the sensors on the first daisy-chained brick, 9-12 the sensors on the next one and so on).
    /// </summary>
    [SmallBasicType]
    public static class Sensor4
    {
        /// <summary>
        /// Similar to ReadRawValue, but returns only a first raw value for port 4. Has a high data return rate.
        /// </summary>
        /// <returns>First element of a raw sensor reading</returns>
        public static Primitive Raw1()
        {
            int _values = 1;

            ByteCodeBuffer c = new ByteCodeBuffer();
            c.OP(0x9E);                // Input_ReadExt
            c.CONST(0);
            c.CONST(0);
            c.CONST(0);                // 0 = don't change type
            c.CONST(-1);               // -1 = don't change mode
            c.CONST(18);               // FORMAT = raw (32bit)
            c.CONST(_values);           // return desired number of 32bit-values
            for (int i = 0; i < _values; i++)
            {
                c.GLOBVAR(4 * i);      // values should be stored in global variables 
            }

            byte[] result = EV3RemoteControler.DirectCommand(c, 4 * _values, 0);
            if (result == null || result.Length < 4 * _values)
            {
                return new Primitive(0);
            }

            double v = DecodeRaw(result, 0 * 4);
            return new Primitive(v < -1000000000 ? 0 : v);
        }

        /// <summary>
        /// Gets three raw values for port 4
        /// </summary>
        /// <param name="var1">The variable in which the first value will be written.</param>
        /// <param name="var2">The variable in which the second value will be written.</param>
        /// <param name="var3">The variable in which the third value will be written.</param>
        public static void Raw3(Primitive var1, Primitive var2, Primitive var3)
        {
        }

        private static int DecodeRaw(byte[] result, int start)
        {
            int b0 = ((int)result[start]) & 0xff;
            int b1 = ((int)result[start + 1]) & 0xff;
            int b2 = ((int)result[start + 2]) & 0xff;
            int b3 = ((int)result[start + 3]) & 0xff;
            return b0 | (b1 << 8) | (b2 << 16) | (b3 << 24);
        }
    }
}
