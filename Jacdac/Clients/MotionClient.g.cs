/** Autogenerated file. Do not edit. */
using Jacdac;
using System;

namespace Jacdac {

    /// <summary>
    /// A sensor, typically PIR, that detects object motion within a certain range
    /// Implements a client for the Motion service.
    /// </summary>
    /// <seealso cref="https://microsoft.github.io/jacdac-docs/services/motion/" />
    public partial class MotionClient : SensorClient
    {
        public MotionClient(JDBus bus, string name)
            : base(bus, (ushort)MotionConstants.ServiceClass, name)
        {
        }

        /// <summary>
        /// Reports is movement is currently detected by the sensor., 
        /// </summary>
        public bool Moving
        {
            get
            {
                return (bool)this.GetRegisterValue((ushort)MotionReg.Moving, MotionRegPack.Moving, 1);
            }
        }

        /// <summary>
        /// (Optional) Maximum distance where objects can be detected., _: m
        /// </summary>
        public float MaxDistance
        {
            get
            {
                return (float)this.GetRegisterValue((ushort)MotionReg.MaxDistance, MotionRegPack.MaxDistance, 1);
            }
        }

        /// <summary>
        /// (Optional) Opening of the field of view, _: °
        /// </summary>
        public uint Angle
        {
            get
            {
                return (uint)this.GetRegisterValue((ushort)MotionReg.Angle, MotionRegPack.Angle, 1);
            }
        }

        /// <summary>
        /// (Optional) Type of physical sensor, 
        /// </summary>
        public MotionVariant Variant
        {
            get
            {
                return (MotionVariant)this.GetRegisterValue((ushort)MotionReg.Variant, MotionRegPack.Variant, 1);
            }
        }

        /// <summary>
        /// A movement was detected.
        /// </summary>
        public event NodeEventHandler Movement;


    }
}