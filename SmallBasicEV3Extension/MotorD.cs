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
    /// A set of quick methods for a motor connected to port A.
    /// </summary>
    [SmallBasicType]
    public static class MotorD
    {
        /// <summary>
        /// Query the current rotation count of a single motor for port D. 
        /// As long as the counter is not reset it will accurately measure all movements of a motor, even if the motor is driven by some external force while not actively running.
        /// Note that this command does not work for motors connected via daisy-chaining.
        /// </summary>
        /// <returns>The current rotation count in degrees for motor port B</returns>
        public static Primitive GetTacho()
        {
            ByteCodeBuffer c = new ByteCodeBuffer();

            c.OP(0xB3);
            c.CONST(0);
            c.CONST(3);
            c.GLOBVAR(0);
            byte[] reply = EV3RemoteControler.DirectCommand(c, 4, 0);

            int tacho = 0;
            if (reply != null)
            {
                tacho = ((int)reply[0]) | (((int)reply[1]) << 8) | (((int)reply[2]) << 16) | (((int)reply[3]) << 24);
            }

            return new Primitive(tacho);
        }

        /// <summary>
        /// Query the current speed of a single motor for port D.
        /// Note that this command does not work for motors connected via daisy-chaining.
        /// </summary>
        /// <returns>Current speed in range -100 to 100</returns>
        public static Primitive GetSpeed()
        {
            ByteCodeBuffer c = new ByteCodeBuffer();
            c.OP(0xA8);
            c.CONST(0);
            c.CONST(3);
            c.GLOBVAR(4);
            c.GLOBVAR(0);
            byte[] reply = EV3RemoteControler.DirectCommand(c, 5, 0);
            int spd = reply == null ? 0 : (sbyte)reply[4];
            return new Primitive(spd);
        }

        /// <summary>
        /// Set the rotation count of motor port D to 0.
        /// </summary>
        public static void ResetCount()
        {
            ByteCodeBuffer c = new ByteCodeBuffer();
            c.OP(0xB2);
            c.CONST(0);
            c.CONST(8); // nos
            EV3RemoteControler.DirectCommand(c, 0, 0);
        }

        /// <summary>
        /// Sets the direct polarity for motor to port D
        /// </summary>
        public static void SetDirectPolarity()
        {
            ByteCodeBuffer c = new ByteCodeBuffer();
            c.OP(0xA7);
            c.CONST(0);
            c.CONST(8); // nos
            c.CONST(1);
            EV3RemoteControler.DirectCommand(c, 0, 0);
        }

        /// <summary>
        /// Sets the direct polarity for motor to port D
        /// </summary>
        public static void SetReversPolarity()
        {
            ByteCodeBuffer c = new ByteCodeBuffer();
            c.OP(0xA7);
            c.CONST(0);
            c.CONST(8); // nos
            c.CONST(-1);
            EV3RemoteControler.DirectCommand(c, 0, 0);
        }

        /// <summary>
        /// Stop motor port D. This will also cancel any scheduled movement for this motor.
        /// Motor will continue to rotate by inertia
        /// </summary>
        public static void Off()
        {
            ByteCodeBuffer c = new ByteCodeBuffer();
            c.OP(0xA3);
            c.CONST(0);
            c.CONST(8);
            c.CONST(0);
            EV3RemoteControler.DirectCommand(c, 0, 0);
        }

        /// <summary>
        /// Stop motor port D. This will also cancel any scheduled movement for this motor.
        /// Motor will stop completely
        /// </summary>
        public static void OffAndBrake()
        {
            ByteCodeBuffer c = new ByteCodeBuffer();
            c.OP(0xA3);
            c.CONST(0);
            c.CONST(8);
            c.CONST(1);
            EV3RemoteControler.DirectCommand(c, 0, 0);
        }

        /// <summary>
        /// Set the motor type for port D - Large motor
        /// </summary>
        public static void IsLarge()
        {
        }

        /// <summary>
        /// Set the motor type for port D - Medium motor
        /// </summary>
        public static void IsMedium()
        {
        }

        /// <summary>
        /// Set motor speed to port D.
        /// </summary>
        /// <param name="speed">Speed value from -100 (full reverse) to 100 (full forward)</param>
        public static void SetSpeed(Primitive speed)
        {
        }

        /// <summary>
        /// Set motor power to port D.
        /// </summary>
        /// <param name="power">Speed value from -100 (full reverse) to 100 (full forward)</param>
        public static void SetPower(Primitive power)
        {
        }

        /// <summary>
        /// Start motor to pirt D
        /// </summary>
        public static void Start()
        {
        }

        /// <summary>
        /// Set motor speed to port D, then start motor.
        /// </summary>
        /// <param name="speed">Speed value from -100 (full reverse) to 100 (full forward)</param>
        public static void StartSpeed(Primitive speed)
        {
        }

        /// <summary>
        /// Set motor power to port D, then start motor.
        /// </summary>
        /// <param name="power">Speed value from -100 (full reverse) to 100 (full forward)</param>
        public static void StartPower(Primitive power)
        {
        }
    }
}
