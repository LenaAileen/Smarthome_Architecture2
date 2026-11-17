using System;
using System.Collections.Generic;
using System.Text;

namespace SmartHomeController
{
    internal class SmartSecurityCamera:SmartDevice
    {
        private String resolution;
        private bool status;

        public String Resolution {  get { return resolution; } set { resolution = value; } }
        public bool Status { get { return status; } set { status = value; } }

        public SmartSecurityCamera(String SmartResolution, bool SmartStatus,int smartDeviceID, string smartDeviceName, bool smartDeviceStatus):base( smartDeviceID,  smartDeviceName, smartDeviceStatus)
        {
            Resolution= SmartResolution;
            Status= SmartStatus;

        }

        public void StartRecording()
        {

        }
        public void StopRecording()
        {
        }
        public override void GetStatus() { }
    }
}
