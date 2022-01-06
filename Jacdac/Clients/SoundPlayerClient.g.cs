/** Autogenerated file. Do not edit. */
using Jacdac;
using System;

namespace Jacdac {

    /// <summary>
    /// A device that can play various sounds stored locally. This service is typically paired with a ``storage`` service for storing sounds.
    /// Implements a client for the Sound player service.
    /// </summary>
    /// <seealso cref="https://microsoft.github.io/jacdac-docs/services/soundplayer/" />
    public partial class SoundPlayerClient : Client
    {
        public SoundPlayerClient(JDBus bus, string name)
            : base(bus, (ushort)SoundPlayerConstants.ServiceClass, name)
        {
        }

        /// <summary>
        /// Global volume of the output. ``0`` means completely off. This volume is mixed with each play volumes., _: /
        /// </summary>
        public float Volume
        {
            get
            {
                return (float)this.GetRegisterValue((ushort)SoundPlayerReg.Volume, SoundPlayerRegPack.Volume, 100);
            }
            set
            {
                
                this.SetRegisterValue((ushort)SoundPlayerReg.Volume, SoundPlayerRegPack.Volume, 100, value);
            }

        }


        /// <summary>
        /// Starts playing a sound.
        /// </summary>
        public void Play(string name)
        {
            this.SendCmdPacked((ushort)SoundPlayerCmd.Play, SoundPlayerCmdPack.Play, new object[] { name });
        }

        /// <summary>
        /// Cancel any sound playing.
        /// </summary>
        public void Cancel()
        {
            this.SendCmdPacked((ushort)SoundPlayerCmd.Cancel, SoundPlayerCmdPack.Cancel, new object[] {  });
        }

    }
}