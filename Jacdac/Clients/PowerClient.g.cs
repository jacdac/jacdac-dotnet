/** Autogenerated file. Do not edit. */
using Jacdac;
using System;

namespace Jacdac.Clients {

    /// <summary>
    /// A power-provider service.
    /// Implements a client for the Power service.
    /// </summary>
    /// <seealso cref="https://microsoft.github.io/jacdac-docs/services/power/" />
    public partial class PowerClient : SensorClient
    {
        public PowerClient(JDBus bus, string name)
            : base(bus, name, ServiceClasses.Power)
        {
        }

        /// <summary>
        /// Can be used to completely disable the service.
        /// When allowed, the service may still not be providing power, see 
        /// `power_status` for the actual current state., 
        /// </summary>
        public bool Allowed
        {
            get
            {
                return (bool)this.GetRegisterValue((ushort)PowerReg.Allowed, PowerRegPack.Allowed);
            }
            set
            {
                
                this.SetRegisterValue((ushort)PowerReg.Allowed, PowerRegPack.Allowed, value);
            }

        }

        /// <summary>
        /// (Optional) Limit the power provided by the service. The actual maximum limit will depend on hardware.
        /// This field may be read-only in some implementations - you should read it back after setting., _: mA
        /// </summary>
        public uint MaxPower
        {
            get
            {
                return (uint)this.GetRegisterValue((ushort)PowerReg.MaxPower, PowerRegPack.MaxPower);
            }
            set
            {
                
                this.SetRegisterValue((ushort)PowerReg.MaxPower, PowerRegPack.MaxPower, value);
            }

        }

        /// <summary>
        /// Indicates whether the power provider is currently providing power (`Powering` state), and if not, why not.
        /// `Overprovision` means there was another power provider, and we stopped not to overprovision the bus., 
        /// </summary>
        public PowerPowerStatus PowerStatus
        {
            get
            {
                return (PowerPowerStatus)this.GetRegisterValue((ushort)PowerReg.PowerStatus, PowerRegPack.PowerStatus);
            }
        }

        /// <summary>
        /// (Optional) Present current draw from the bus., _: mA
        /// </summary>
        public uint CurrentDraw
        {
            get
            {
                return (uint)this.GetRegisterValue((ushort)PowerReg.CurrentDraw, PowerRegPack.CurrentDraw);
            }
        }

        /// <summary>
        /// (Optional) Voltage on input., _: mV
        /// </summary>
        public uint BatteryVoltage
        {
            get
            {
                return (uint)this.GetRegisterValue((ushort)PowerReg.BatteryVoltage, PowerRegPack.BatteryVoltage);
            }
        }

        /// <summary>
        /// (Optional) Fraction of charge in the battery., _: /
        /// </summary>
        public float BatteryCharge
        {
            get
            {
                return (float)this.GetRegisterValue((ushort)PowerReg.BatteryCharge, PowerRegPack.BatteryCharge);
            }
        }

        /// <summary>
        /// (Optional) Energy that can be delivered to the bus when battery is fully charged.
        /// This excludes conversion overheads if any., _: mWh
        /// </summary>
        public uint BatteryCapacity
        {
            get
            {
                return (uint)this.GetRegisterValue((ushort)PowerReg.BatteryCapacity, PowerRegPack.BatteryCapacity);
            }
        }

        /// <summary>
        /// (Optional) Many USB power packs need current to be drawn from time to time to prevent shutdown.
        /// This regulates how often and for how long such current is drawn.
        /// Typically a 1/8W 22 ohm resistor is used as load. This limits the duty cycle to 10%., _: ms
        /// </summary>
        public uint KeepOnPulseDuration
        {
            get
            {
                return (uint)this.GetRegisterValue((ushort)PowerReg.KeepOnPulseDuration, PowerRegPack.KeepOnPulseDuration);
            }
            set
            {
                
                this.SetRegisterValue((ushort)PowerReg.KeepOnPulseDuration, PowerRegPack.KeepOnPulseDuration, value);
            }

        }

        /// <summary>
        /// (Optional) Many USB power packs need current to be drawn from time to time to prevent shutdown.
        /// This regulates how often and for how long such current is drawn.
        /// Typically a 1/8W 22 ohm resistor is used as load. This limits the duty cycle to 10%., _: ms
        /// </summary>
        public uint KeepOnPulsePeriod
        {
            get
            {
                return (uint)this.GetRegisterValue((ushort)PowerReg.KeepOnPulsePeriod, PowerRegPack.KeepOnPulsePeriod);
            }
            set
            {
                
                this.SetRegisterValue((ushort)PowerReg.KeepOnPulsePeriod, PowerRegPack.KeepOnPulsePeriod, value);
            }

        }

        /// <summary>
        /// Emitted whenever `power_status` changes.
        /// </summary>
        public event ClientEventHandler PowerStatusChanged
        {
            add
            {
                this.AddEvent((ushort)PowerEvent.PowerStatusChanged, value);
            }
            remove
            {
                this.RemoveEvent((ushort)PowerEvent.PowerStatusChanged, value);
            }
        }


        
        /// <summary>
        /// Sent by the power service periodically, as broadcast.
        /// </summary>
        public void Shutdown()
        {
            this.SendCmd((ushort)PowerCmd.Shutdown);
        }

    }
}