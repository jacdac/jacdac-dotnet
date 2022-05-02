/** Autogenerated file. Do not edit. */
using Jacdac;
using System;

namespace Jacdac.Clients 
{
    /// <summary>
    /// Servo is a small motor with arm that can be pointing at a specific direction.
     /// Typically a servo angle is between 0° and 180° where 90° is the middle resting position.
     /// 
     /// The `min_pulse/max_pulse` may be read-only if the servo is permanently affixed to its Jacdac controller.
    /// Implements a client for the Servo service.
    /// </summary>
    /// <seealso cref="https://microsoft.github.io/jacdac-docs/services/servo/" />
    public partial class ServoClient : SensorClient
    {
        public ServoClient(JDBus bus, string name)
            : base(bus, name, ServiceClasses.Servo)
        {
        }

        /// <summary>
        /// Reads the <c>angle</c> register value.
        /// Specifies the angle of the arm (request)., _: °
        /// </summary>
        public float Angle
        {
            get
            {
                return (float)this.GetRegisterValue((ushort)ServoReg.Angle, ServoRegPack.Angle);
            }
            set
            {
                
                this.Enabled = true;
                this.SetRegisterValue((ushort)ServoReg.Angle, ServoRegPack.Angle, value);
            }

        }

        /// <summary>
        /// Reads the <c>enabled</c> register value.
        /// Turn the power to the servo on/off., 
        /// </summary>
        public bool Enabled
        {
            get
            {
                return (bool)this.GetRegisterValueAsBool((ushort)ServoReg.Enabled, ServoRegPack.Enabled);
            }
            set
            {
                
                this.SetRegisterValue((ushort)ServoReg.Enabled, ServoRegPack.Enabled, value);
            }

        }

        /// <summary>
        /// Reads the <c>offset</c> register value.
        /// Correction applied to the angle to account for the servo arm drift., _: °
        /// </summary>
        public float Offset
        {
            get
            {
                return (float)this.GetRegisterValue((ushort)ServoReg.Offset, ServoRegPack.Offset);
            }
            set
            {
                
                this.SetRegisterValue((ushort)ServoReg.Offset, ServoRegPack.Offset, value);
            }

        }

        /// <summary>
        /// Reads the <c>min_angle</c> register value.
        /// Lowest angle that can be set, typiclly 0 °., _: °
        /// </summary>
        public float MinAngle
        {
            get
            {
                return (float)this.GetRegisterValue((ushort)ServoReg.MinAngle, ServoRegPack.MinAngle);
            }
        }

        /// <summary>
        /// Tries to read the <c>min_pulse</c> register value.
        /// The length of pulse corresponding to lowest angle., _: us
        /// </summary>
        bool TryGetMinPulse(out uint value)
        {
            object[] values;
            if (this.TryGetRegisterValues((ushort)ServoReg.MinPulse, ServoRegPack.MinPulse, out values)) 
            {
                value = (uint)values[0];
                return true;
            }
            else
            {
                value = default(uint);
                return false;
            }
        }
        
        /// <summary>
        /// Sets the min_pulse value
        /// </summary>
        public void SetMinPulse(uint value)
        {
            this.SetRegisterValue((ushort)ServoReg.MinPulse, ServoRegPack.MinPulse, value);
        }


        /// <summary>
        /// Reads the <c>max_angle</c> register value.
        /// Highest angle that can be set, typically 180°., _: °
        /// </summary>
        public float MaxAngle
        {
            get
            {
                return (float)this.GetRegisterValue((ushort)ServoReg.MaxAngle, ServoRegPack.MaxAngle);
            }
        }

        /// <summary>
        /// Tries to read the <c>max_pulse</c> register value.
        /// The length of pulse corresponding to highest angle., _: us
        /// </summary>
        bool TryGetMaxPulse(out uint value)
        {
            object[] values;
            if (this.TryGetRegisterValues((ushort)ServoReg.MaxPulse, ServoRegPack.MaxPulse, out values)) 
            {
                value = (uint)values[0];
                return true;
            }
            else
            {
                value = default(uint);
                return false;
            }
        }
        
        /// <summary>
        /// Sets the max_pulse value
        /// </summary>
        public void SetMaxPulse(uint value)
        {
            this.SetRegisterValue((ushort)ServoReg.MaxPulse, ServoRegPack.MaxPulse, value);
        }


        /// <summary>
        /// Tries to read the <c>stall_torque</c> register value.
        /// The servo motor will stop rotating when it is trying to move a ``stall_torque`` weight at a radial distance of ``1.0`` cm., _: kg/cm
        /// </summary>
        bool TryGetStallTorque(out float value)
        {
            object[] values;
            if (this.TryGetRegisterValues((ushort)ServoReg.StallTorque, ServoRegPack.StallTorque, out values)) 
            {
                value = (float)values[0];
                return true;
            }
            else
            {
                value = default(float);
                return false;
            }
        }

        /// <summary>
        /// Tries to read the <c>response_speed</c> register value.
        /// Time to move 60°., _: s/60°
        /// </summary>
        bool TryGetResponseSpeed(out float value)
        {
            object[] values;
            if (this.TryGetRegisterValues((ushort)ServoReg.ResponseSpeed, ServoRegPack.ResponseSpeed, out values)) 
            {
                value = (float)values[0];
                return true;
            }
            else
            {
                value = default(float);
                return false;
            }
        }

        /// <summary>
        /// Tries to read the <c>actual_angle</c> register value.
        /// The current physical position of the arm, if the device has a way to sense the position., _: °
        /// </summary>
        bool TryGetActualAngle(out float value)
        {
            object[] values;
            if (this.TryGetRegisterValues((ushort)ServoReg.ActualAngle, ServoRegPack.ActualAngle, out values)) 
            {
                value = (float)values[0];
                return true;
            }
            else
            {
                value = default(float);
                return false;
            }
        }


    }
}