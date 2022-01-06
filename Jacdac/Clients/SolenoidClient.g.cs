/** Autogenerated file. Do not edit. */
using Jacdac;
using System;

namespace Jacdac {

    /// <summary>
    /// A push-pull solenoid is a type of relay that pulls a coil when activated.
    /// Implements a client for the Solenoid service.
    /// </summary>
    /// <seealso cref="https://microsoft.github.io/jacdac-docs/services/solenoid/" />
    public partial class SolenoidClient : Client
    {
        public SolenoidClient(JDBus bus, string name)
            : base(bus, (ushort)SolenoidConstants.ServiceClass, name)
        {
        }

        /// <summary>
        /// Indicates whether the solenoid is energized and pulled (on) or pushed (off)., 
        /// </summary>
        public bool Pulled
        {
            get
            {
                return (bool)this.GetRegisterValue((ushort)SolenoidReg.Pulled, SolenoidRegPack.Pulled, 1);
            }
            set
            {
                
                this.SetRegisterValue((ushort)SolenoidReg.Pulled, SolenoidRegPack.Pulled, 1, value);
            }

        }

        /// <summary>
        /// (Optional) Describes the type of solenoid used., 
        /// </summary>
        public SolenoidVariant Variant
        {
            get
            {
                return (SolenoidVariant)this.GetRegisterValue((ushort)SolenoidReg.Variant, SolenoidRegPack.Variant, 1);
            }
        }


    }
}