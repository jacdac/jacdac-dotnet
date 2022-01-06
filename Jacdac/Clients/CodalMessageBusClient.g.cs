/** Autogenerated file. Do not edit. */
using Jacdac;
using System;

namespace Jacdac {

    /// <summary>
    /// A service that uses the [CODAL message bus](https://lancaster-university.github.io/microbit-docs/ubit/messageBus/) to send and receive small messages.
     /// 
     /// You can find known values for `source` in [CODAL repository](https://github.com/lancaster-university/codal-core/blob/master/inc/core/CodalComponent.h)
     /// In MakeCode, you can listen for custom `source`, `value` values using [control.onEvent](https://makecode.microbit.org/reference/control/on-event].
    /// Implements a client for the CODAL Message Bus service.
    /// </summary>
    /// <seealso cref="https://microsoft.github.io/jacdac-docs/services/codalmessagebus/" />
    public partial class CodalMessageBusClient : Client
    {
        public CodalMessageBusClient(JDBus bus, string name)
            : base(bus, (ushort)CodalMessageBusConstants.ServiceClass, name)
        {
        }

        /// <summary>
        /// Raised by the server is triggered by the server. The filtering logic of which event to send over Jacdac is up to the server implementation.
        /// </summary>
        public event NodeEventHandler Message;


        /// <summary>
        /// Send a message on the CODAL bus. If `source` is `0`, it is treated as wildcard.
        /// </summary>
        public void Send(uint source, uint value)
        {
            this.SendCmdPacked((ushort)CodalMessageBusCmd.Send, CodalMessageBusCmdPack.Send, new object[] { source, value });
        }

    }
}