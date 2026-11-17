using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;

namespace SmartHomeController
{
    internal class SmartThermostat : SmartDevice
    {
        private double currentTemperature;
        private double targetTemperature;
        
        public double CurrentTemperature{
            get { return currentTemperature; } set { currentTemperature = value; }
        } 
        public double TargetTemperature{ get { return targetTemperature; } set { targetTemperature = value; } }

        public SmartThermostat(int smartDeviceID, string smartDeviceName, bool smartDeviceStatus, double SmartCurrentTemperature, double SmartTargetTemperature) : base(smartDeviceID, smartDeviceName, smartDeviceStatus)
        {
            CurrentTemperature=SmartCurrentTemperature;
            TargetTemperature = SmartTargetTemperature;


        }
    public void SetTemperature()
        {

        }

        public void SetCurrentTemperature() {
        }
       
        public override void GetStatus()
        {
        }


    }
}
