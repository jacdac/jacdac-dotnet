/** Autogenerated file. Do not edit. */
using Jacdac;
using System;

namespace Jacdac.Clients {

    /// <summary>
    /// Health and diagnostics information about the Azure Iot Hub connection.
    /// Implements a client for the Azure IoT Hub Health service.
    /// </summary>
    /// <seealso cref="https://microsoft.github.io/jacdac-docs/services/azureiothubhealth/" />
    public partial class AzureIotHubHealthClient : Client
    {
        public AzureIotHubHealthClient(JDBus bus, string name)
            : base(bus, name, ServiceClasses.AzureIotHubHealth)
        {
        }

        /// <summary>
        /// (Optional) Something like `my-iot-hub.azure-devices.net` if available., 
        /// </summary>
        public string HubName
        {
            get
            {
                return (string)this.GetRegisterValue((ushort)AzureIotHubHealthReg.HubName, AzureIotHubHealthRegPack.HubName);
            }
        }

        /// <summary>
        /// (Optional) Device identifier in Azure Iot Hub if available., 
        /// </summary>
        public string HubDeviceId
        {
            get
            {
                return (string)this.GetRegisterValue((ushort)AzureIotHubHealthReg.HubDeviceId, AzureIotHubHealthRegPack.HubDeviceId);
            }
        }

        /// <summary>
        /// Indicates the status of connection. A message beyond the [0..3] range represents an HTTP error code., 
        /// </summary>
        public AzureIotHubHealthConnectionStatus ConnectionStatus
        {
            get
            {
                return (AzureIotHubHealthConnectionStatus)this.GetRegisterValue((ushort)AzureIotHubHealthReg.ConnectionStatus, AzureIotHubHealthRegPack.ConnectionStatus);
            }
        }

        /// <summary>
        /// Raised when the connection status changes
        /// </summary>
        public event NodeEventHandler ConnectionStatusChange;

        /// <summary>
        /// Raised when a message has been sent to the hub.
        /// </summary>
        public event NodeEventHandler MessageSent;


        /// <summary>
        /// Starts a connection to the IoT hub service
        /// </summary>
        public void Connect()
        {
            this.SendCmd((ushort)AzureIotHubHealthCmd.Connect);
        }

        /// <summary>
        /// Starts disconnecting from the IoT hub service
        /// </summary>
        public void Disconnect()
        {
            this.SendCmd((ushort)AzureIotHubHealthCmd.Disconnect);
        }

    }
}