using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Opc.UaFx.Client;
namespace OPCUAReadData
{
    public class ReadSensorData
    {
        

        public void UpdateTags_S1(OpcClient client, ref string strS1Name, ref bool bS1Status, ref double dS1Val)
        {
            //Motor1            
            string strTagName = "ns=3;s=Sensor1/Name";
            Opc.UaFx.OpcValue opcS1Name = client.ReadNode(strTagName);
            strS1Name = (string)opcS1Name.Value;

            strTagName = "ns=3;s=Sensor1/Status";
            Opc.UaFx.OpcValue opcS1Stt = client.ReadNode(strTagName);
            bS1Status = (bool)opcS1Stt.Value;

            strTagName = "ns=3;s=Sensor1/MeasValue";
            Opc.UaFx.OpcValue opcS1Val = client.ReadNode(strTagName);
            dS1Val = (double)opcS1Val.Value;
        }
        public void UpdateTags_S2(OpcClient client, ref string strS2Name, ref bool bS2Status, ref double dS2Val)
        {
            //Motor2            
            string strTagName = "ns=3;s=Sensor2/Name";
            Opc.UaFx.OpcValue opcS2Name = client.ReadNode(strTagName);
            strS2Name = (string)opcS2Name.Value;

            strTagName = "ns=3;s=Sensor2/Status";
            Opc.UaFx.OpcValue opcS2Stt = client.ReadNode(strTagName);
            bS2Status = (bool)opcS2Stt.Value;

            strTagName = "ns=3;s=Sensor2/MeasValue";
            Opc.UaFx.OpcValue opcS2Val = client.ReadNode(strTagName);
            dS2Val = (double)opcS2Val.Value;
        }

       
    }
}
