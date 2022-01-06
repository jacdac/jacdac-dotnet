/** Autogenerated file. Do not edit. */
using Jacdac;
using System;

namespace Jacdac.Clients {

    /// <summary>
    /// A mixin service that exposes verified telemetry information for a sensor (see https://github.com/Azure/Verified-Telemetry/tree/main/PnPModel).
    /// Implements a client for the Verified Telemetry service.
    /// </summary>
    /// <seealso cref="https://microsoft.github.io/jacdac-docs/services/verifiedtelemetrysensor/" />
    public partial class VerifiedTelemetryClient : Client
    {
        public VerifiedTelemetryClient(JDBus bus, string name)
            : base(bus, name, ServiceClasses.VerifiedTelemetry)
        {
        }

        /// <summary>
        /// Reads the telemetry working status, where ``true`` is working and ``false`` is faulty., 
        /// </summary>
        public VerifiedTelemetryStatus TelemetryStatus
        {
            get
            {
                return (VerifiedTelemetryStatus)this.GetRegisterValue((ushort)VerifiedTelemetryReg.TelemetryStatus, VerifiedTelemetryRegPack.TelemetryStatus);
            }
        }

        /// <summary>
        /// (Optional) Specifies the interval between computing the fingerprint information., _: ms
        /// </summary>
        public uint TelemetryStatusInterval
        {
            get
            {
                return (uint)this.GetRegisterValue((ushort)VerifiedTelemetryReg.TelemetryStatusInterval, VerifiedTelemetryRegPack.TelemetryStatusInterval);
            }
            set
            {
                
                this.SetRegisterValue((ushort)VerifiedTelemetryReg.TelemetryStatusInterval, VerifiedTelemetryRegPack.TelemetryStatusInterval, value);
            }

        }

        /// <summary>
        /// Type of the fingerprint., 
        /// </summary>
        public VerifiedTelemetryFingerprintType FingerprintType
        {
            get
            {
                return (VerifiedTelemetryFingerprintType)this.GetRegisterValue((ushort)VerifiedTelemetryReg.FingerprintType, VerifiedTelemetryRegPack.FingerprintType);
            }
        }

        /// <summary>
        /// Template Fingerprint information of a working sensor., confidence: %
        /// </summary>
        public object[] /*(uint, byte[])*/ FingerprintTemplate
        {
            get
            {
                return (object[] /*(uint, byte[])*/)this.GetRegisterValue((ushort)VerifiedTelemetryReg.FingerprintTemplate, VerifiedTelemetryRegPack.FingerprintTemplate);
            }
        }

        /// <summary>
        /// The telemetry status of the device was updated.
        /// </summary>
        public event NodeEventHandler TelemetryStatusChange;

        /// <summary>
        /// The fingerprint template was updated
        /// </summary>
        public event NodeEventHandler FingerprintTemplateChange;


        /// <summary>
        /// This command will clear the template fingerprint of a sensor and collect a new template fingerprint of the attached sensor.
        /// </summary>
        public void ResetFingerprintTemplate()
        {
            this.SendCmd((ushort)VerifiedTelemetryCmd.ResetFingerprintTemplate);
        }

        /// <summary>
        /// This command will append a new template fingerprint to the `fingerprintTemplate`. Appending more fingerprints will increase the accuracy in detecting the telemetry status.
        /// </summary>
        public void RetrainFingerprintTemplate()
        {
            this.SendCmd((ushort)VerifiedTelemetryCmd.RetrainFingerprintTemplate);
        }

    }
}