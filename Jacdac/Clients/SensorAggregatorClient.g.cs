/** Autogenerated file. Do not edit. */
using Jacdac;
using System;

namespace Jacdac.Clients {

    /// <summary>
    /// Aggregate data from multiple sensors into a single stream
     /// (often used as input to machine learning models on the same device, see model runner service).
    /// Implements a client for the Sensor Aggregator service.
    /// </summary>
    /// <seealso cref="https://microsoft.github.io/jacdac-docs/services/sensoraggregator/" />
    public partial class SensorAggregatorClient : SensorClient
    {
        public SensorAggregatorClient(JDBus bus, string name)
            : base(bus, name, ServiceClasses.SensorAggregator)
        {
        }

        /// <summary>
        /// Number of input samples collected so far., 
        /// </summary>
        public uint NumSamples
        {
            get
            {
                return (uint)this.GetRegisterValue((ushort)SensorAggregatorReg.NumSamples, SensorAggregatorRegPack.NumSamples);
            }
        }

        /// <summary>
        /// Size of a single sample., _: B
        /// </summary>
        public uint SampleSize
        {
            get
            {
                return (uint)this.GetRegisterValue((ushort)SensorAggregatorReg.SampleSize, SensorAggregatorRegPack.SampleSize);
            }
        }

        /// <summary>
        /// When set to `N`, will stream `N` samples as `current_sample` reading., _: #
        /// </summary>
        public uint StreamingSamples
        {
            get
            {
                return (uint)this.GetRegisterValue((ushort)SensorAggregatorReg.StreamingSamples, SensorAggregatorRegPack.StreamingSamples);
            }
            set
            {
                
                this.SetRegisterValue((ushort)SensorAggregatorReg.StreamingSamples, SensorAggregatorRegPack.StreamingSamples, value);
            }

        }

        /// <summary>
        /// Last collected sample., 
        /// </summary>
        public byte[] CurrentSample
        {
            get
            {
                return (byte[])this.GetRegisterValue((ushort)SensorAggregatorReg.CurrentSample, SensorAggregatorRegPack.CurrentSample);
            }
        }


    }
}