/** Autogenerated file. Do not edit. */
using Jacdac;
using System;

namespace Jacdac.Clients 
{
    /// <summary>
    /// A service that reports a voltage measurement.
    /// Implements a client for the DC Voltage Measurement service.
    /// </summary>
    /// <seealso cref="https://microsoft.github.io/jacdac-docs/services/dcvoltagemeasurement/" />
    public partial class DCVoltageMeasurementClient : SensorClient
    {
        public DCVoltageMeasurementClient(JDBus bus, string name)
            : base(bus, name, ServiceClasses.DCVoltageMeasurement)
        {
        }

        /// <summary>
        /// Reads the <c>measurement_type</c> register value.
        /// The type of measurement that is taking place. Absolute results are measured with respect to ground, whereas differential results are measured against another signal that is not ground., 
        /// </summary>
        public DCVoltageMeasurementVoltageMeasurementType MeasurementType
        {
            get
            {
                return (DCVoltageMeasurementVoltageMeasurementType)this.GetRegisterValue((ushort)DCVoltageMeasurementReg.MeasurementType, DCVoltageMeasurementRegPack.MeasurementType);
            }
        }

        /// <summary>
        /// Reads the <c>measurement_name</c> register value.
        /// A string containing the net name that is being measured e.g. `POWER_DUT` or a reference e.g. `DIFF_DEV1_DEV2`. These constants can be used to identify a measurement from client code., 
        /// </summary>
        public string MeasurementName
        {
            get
            {
                return (string)this.GetRegisterValue((ushort)DCVoltageMeasurementReg.MeasurementName, DCVoltageMeasurementRegPack.MeasurementName);
            }
        }

        /// <summary>
        /// Reads the <c>measurement</c> register value.
        /// The voltage measurement., _: V
        /// </summary>
        public float Measurement
        {
            get
            {
                return (float)this.GetRegisterValue((ushort)DCVoltageMeasurementReg.Measurement, DCVoltageMeasurementRegPack.Measurement);
            }
        }


    }
}