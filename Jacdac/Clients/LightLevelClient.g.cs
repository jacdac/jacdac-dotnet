/** Autogenerated file. Do not edit. */
using Jacdac;
using System;

namespace Jacdac {

    /// <summary>
    /// A sensor that measures luminosity level.
    /// Implements a client for the Light level service.
    /// </summary>
    /// <seealso cref="https://microsoft.github.io/jacdac-docs/services/lightlevel/" />
    public partial class LightLevelClient : SensorClient
    {
        public LightLevelClient(JDBus bus, string name)
            : base(bus, (ushort)LightLevelConstants.ServiceClass, name)
        {
        }

        /// <summary>
        /// Detect light level, _: /
        /// </summary>
        public float LightLevel
        {
            get
            {
                return (float)this.GetRegisterValue((ushort)LightLevelReg.LightLevel, LightLevelRegPack.LightLevel, 100);
            }
        }

        /// <summary>
        /// (Optional) Absolute estimated error of the reading value, _: /
        /// </summary>
        public float LightLevelError
        {
            get
            {
                return (float)this.GetRegisterValue((ushort)LightLevelReg.LightLevelError, LightLevelRegPack.LightLevelError, 100);
            }
        }

        /// <summary>
        /// (Optional) The type of physical sensor., 
        /// </summary>
        public LightLevelVariant Variant
        {
            get
            {
                return (LightLevelVariant)this.GetRegisterValue((ushort)LightLevelReg.Variant, LightLevelRegPack.Variant, 1);
            }
        }


    }
}