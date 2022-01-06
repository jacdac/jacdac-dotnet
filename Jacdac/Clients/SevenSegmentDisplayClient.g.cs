/** Autogenerated file. Do not edit. */
using Jacdac;
using System;

namespace Jacdac {

    /// <summary>
    /// A 7-segment numeric display, with one or more digits.
    /// Implements a client for the 7-segment display service.
    /// </summary>
    /// <seealso cref="https://microsoft.github.io/jacdac-docs/services/sevensegmentdisplay/" />
    public partial class SevenSegmentDisplayClient : Client
    {
        public SevenSegmentDisplayClient(JDBus bus, string name)
            : base(bus, (ushort)SevenSegmentDisplayConstants.ServiceClass, name)
        {
        }

        /// <summary>
        /// Each byte encodes the display status of a digit using,
        /// where bit 0 encodes segment `A`, bit 1 encodes segments `B`, ..., bit 6 encodes segments `G`, and bit 7 encodes the decimal point (if present).
        /// If incoming `digits` data is smaller than `digit_count`, the remaining digits will be cleared.
        /// Thus, sending an empty `digits` payload clears the screen.
        /// 
        /// ```text
        ///  - A -
        ///  G   B
        ///  |   |
        ///  - F -
        ///  |   |   -
        ///  E   C  |DP|
        ///  - D -   -
        /// ```, 
        /// </summary>
        public byte[] Digits
        {
            get
            {
                return (byte[])this.GetRegisterValue((ushort)SevenSegmentDisplayReg.Digits, SevenSegmentDisplayRegPack.Digits, 1);
            }
            set
            {
                
                this.SetRegisterValue((ushort)SevenSegmentDisplayReg.Digits, SevenSegmentDisplayRegPack.Digits, 1, value);
            }

        }

        /// <summary>
        /// Controls the brightness of the LEDs. `0` means off., _: /
        /// </summary>
        public float Brightness
        {
            get
            {
                return (float)this.GetRegisterValue((ushort)SevenSegmentDisplayReg.Brightness, SevenSegmentDisplayRegPack.Brightness, 100);
            }
            set
            {
                
                this.SetRegisterValue((ushort)SevenSegmentDisplayReg.Brightness, SevenSegmentDisplayRegPack.Brightness, 100, value);
            }

        }

        /// <summary>
        /// (Optional) Turn on or off the column LEDs (separating minutes from hours, etc.) in of the segment.
        /// If the column LEDs is not supported, the value remains false., 
        /// </summary>
        public bool DoubleDots
        {
            get
            {
                return (bool)this.GetRegisterValue((ushort)SevenSegmentDisplayReg.DoubleDots, SevenSegmentDisplayRegPack.DoubleDots, 1);
            }
            set
            {
                
                this.SetRegisterValue((ushort)SevenSegmentDisplayReg.DoubleDots, SevenSegmentDisplayRegPack.DoubleDots, 1, value);
            }

        }

        /// <summary>
        /// The number of digits available on the display., 
        /// </summary>
        public uint DigitCount
        {
            get
            {
                return (uint)this.GetRegisterValue((ushort)SevenSegmentDisplayReg.DigitCount, SevenSegmentDisplayRegPack.DigitCount, 1);
            }
        }

        /// <summary>
        /// True if decimal points are available (on all digits)., 
        /// </summary>
        public bool DecimalPoint
        {
            get
            {
                return (bool)this.GetRegisterValue((ushort)SevenSegmentDisplayReg.DecimalPoint, SevenSegmentDisplayRegPack.DecimalPoint, 1);
            }
        }


        /// <summary>
        /// Shows the number on the screen using the decimal dot if available.
        /// </summary>
        public void SetNumber(float value)
        {
            // TODO: implement client command
            throw new NotImplementException("client command not implemented");
        }

        /// <summary>
        /// Shows the text on the screen. The client may decide to scroll the text if too long.
        /// </summary>
        public void SetText(string text)
        {
            // TODO: implement client command
            throw new NotImplementException("client command not implemented");
        }

    }
}