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
    /// A set of quick methods for a motors connected to ports A and B.
    /// </summary>
    [SmallBasicType]
    public static class MotorAC
    {
        /// <summary>
        /// Stop motor ports AC. This will also cancel any scheduled movement for this motors.
        /// Motors will continue to rotate by inertia
        /// </summary>
        public static void Off()
        {
            ByteCodeBuffer c = new ByteCodeBuffer();
            c.OP(0xA3);
            c.CONST(0);
            c.CONST(5);
            c.CONST(0);
            EV3RemoteControler.DirectCommand(c, 0, 0);
        }

        /// <summary>
        /// Stop motors port AC. This will also cancel any scheduled movement for this motors.
        /// Motors will stop completely
        /// </summary>
        public static void OffAndBrake()
        {
            ByteCodeBuffer c = new ByteCodeBuffer();
            c.OP(0xA3);
            c.CONST(0);
            c.CONST(5);
            c.CONST(1);
            EV3RemoteControler.DirectCommand(c, 0, 0);
        }

        /// <summary>
        /// Set motors speed to port AC.
        /// </summary>
        /// <param name="speed">Speed value from -100 (full reverse) to 100 (full forward)</param>
        public static void SetSpeed(Primitive speed)
        {
        }

        /// <summary>
        /// Set motors power to ports AC.
        /// </summary>
        /// <param name="power">Speed value from -100 (full reverse) to 100 (full forward)</param>
        public static void SetPower(Primitive power)
        {
        }

        /// <summary>
        /// Start motors to pirts AC.
        /// </summary>
        public static void Start()
        {
        }

        /// <summary>
        /// Set motors speed to ports AC, then start motors.
        /// </summary>
        /// <param name="speed">Speed value from -100 (full reverse) to 100 (full forward)</param>
        public static void StartSpeed(Primitive speed)
        {
        }

        /// <summary>
        /// Set motors power to ports AC, then start motors.
        /// </summary>
        /// <param name="power">Speed value from -100 (full reverse) to 100 (full forward)</param>
        public static void StartPower(Primitive power)
        {
        }
    }
}
