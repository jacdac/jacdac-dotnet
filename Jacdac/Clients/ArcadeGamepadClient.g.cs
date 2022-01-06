/** Autogenerated file. Do not edit. */
using Jacdac;
using System;

namespace Jacdac.Clients {

    /// <summary>
    /// This service is deprecated in favor or `joystick`; it is currently used by the micro:bit Arcade smart shield though.
     /// A gamepad with direction and action buttons for one player.
     /// If a device has multiple controllers, it should have multiple gamepad services, using consecutive service identifiers.
    /// Implements a client for the Arcade Gamepad service.
    /// </summary>
    /// <seealso cref="https://microsoft.github.io/jacdac-docs/services/arcadegamepad/" />
    public partial class ArcadeGamepadClient : Client
    {
        public ArcadeGamepadClient(JDBus bus, string name)
            : base(bus, name, ServiceClasses.ArcadeGamepad)
        {
        }

        /// <summary>
        /// Emitted when button goes from inactive to active.
        /// </summary>
        public event NodeEventHandler Down;

        /// <summary>
        /// Emitted when button goes from active to inactive.
        /// </summary>
        public event NodeEventHandler Up;


    }
}