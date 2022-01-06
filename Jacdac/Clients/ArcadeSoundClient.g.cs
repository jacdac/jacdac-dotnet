/** Autogenerated file. Do not edit. */
using Jacdac;
using System;

namespace Jacdac.Clients {

    /// <summary>
    /// A sound playing device.
     /// 
     /// This is typically run over an SPI connection, not regular single-wire Jacdac.
    /// Implements a client for the Arcade Sound service.
    /// </summary>
    /// <seealso cref="https://microsoft.github.io/jacdac-docs/services/arcadesound/" />
    public partial class ArcadeSoundClient : Client
    {
        public ArcadeSoundClient(JDBus bus, string name)
            : base(bus, name, ServiceClasses.ArcadeSound)
        {
        }

        /// <summary>
        /// Get or set playback sample rate (in samples per second).
        /// If you set it, read it back, as the value may be rounded up or down., _: Hz
        /// </summary>
        public float SampleRate
        {
            get
            {
                return (float)this.GetRegisterValue((ushort)ArcadeSoundReg.SampleRate, ArcadeSoundRegPack.SampleRate);
            }
            set
            {
                
                this.SetRegisterValue((ushort)ArcadeSoundReg.SampleRate, ArcadeSoundRegPack.SampleRate, value);
            }

        }

        /// <summary>
        /// The size of the internal audio buffer., _: B
        /// </summary>
        public uint BufferSize
        {
            get
            {
                return (uint)this.GetRegisterValue((ushort)ArcadeSoundReg.BufferSize, ArcadeSoundRegPack.BufferSize);
            }
        }

        /// <summary>
        /// How much data is still left in the buffer to play.
        /// Clients should not send more data than `buffer_size - buffer_pending`,
        /// but can keep the `buffer_pending` as low as they want to ensure low latency
        /// of audio playback., _: B
        /// </summary>
        public uint BufferPending
        {
            get
            {
                return (uint)this.GetRegisterValue((ushort)ArcadeSoundReg.BufferPending, ArcadeSoundRegPack.BufferPending);
            }
        }


        /// <summary>
        /// Play samples, which are single channel, signed 16-bit little endian values.
        /// </summary>
        public void Play(byte[] samples)
        {
            this.SendCmdPacked((ushort)ArcadeSoundCmd.Play, ArcadeSoundCmdPack.Play, new object[] { samples });
        }

    }
}