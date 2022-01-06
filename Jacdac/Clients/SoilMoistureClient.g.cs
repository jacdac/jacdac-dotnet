/** Autogenerated file. Do not edit. */
using Jacdac;
using System;

namespace Jacdac.Clients {

    /// <summary>
    /// A soil moisture sensor.
    /// Implements a client for the Soil moisture service.
    /// </summary>
    /// <seealso cref="https://microsoft.github.io/jacdac-docs/services/soilmoisture/" />
    public partial class SoilMoistureClient : SensorClient
    {
        public SoilMoistureClient(JDBus bus, string name)
            : base(bus, name, ServiceClasses.SoilMoisture)
        {
        }

        /// <summary>
        /// Indicates the wetness of the soil, from `dry` to `wet`., _: /
        /// </summary>
        public float Moisture
        {
            get
            {
                return (float)this.GetRegisterValue((ushort)SoilMoistureReg.Moisture, SoilMoistureRegPack.Moisture);
            }
        }

        /// <summary>
        /// (Optional) The error on the moisture reading., _: /
        /// </summary>
        public float MoistureError
        {
            get
            {
                return (float)this.GetRegisterValue((ushort)SoilMoistureReg.MoistureError, SoilMoistureRegPack.MoistureError);
            }
        }

        /// <summary>
        /// (Optional) Describe the type of physical sensor., 
        /// </summary>
        public SoilMoistureVariant Variant
        {
            get
            {
                return (SoilMoistureVariant)this.GetRegisterValue((ushort)SoilMoistureReg.Variant, SoilMoistureRegPack.Variant);
            }
        }


    }
}