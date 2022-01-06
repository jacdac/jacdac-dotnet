/** Autogenerated file. Do not edit. */
using Jacdac;
using System;

namespace Jacdac.Clients {

    /// <summary>
    /// A bending or deflection sensor.
    /// Implements a client for the Flex service.
    /// </summary>
    /// <seealso cref="https://microsoft.github.io/jacdac-docs/services/flex/" />
    public partial class FlexClient : SensorClient
    {
        public FlexClient(JDBus bus, string name)
            : base(bus, name, ServiceClasses.Flex)
        {
        }

        /// <summary>
        /// A measure of the bending., _: /
        /// </summary>
        public float Bending
        {
            get
            {
                return (float)this.GetRegisterValue((ushort)FlexReg.Bending, FlexRegPack.Bending);
            }
        }

        /// <summary>
        /// (Optional) Length of the flex sensor, _: mm
        /// </summary>
        public uint Length
        {
            get
            {
                return (uint)this.GetRegisterValue((ushort)FlexReg.Length, FlexRegPack.Length);
            }
        }


    }
}