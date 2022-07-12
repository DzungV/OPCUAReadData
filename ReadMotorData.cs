using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Opc.UaFx.Client;

namespace OPCUAReadData
{
    public class ReadMotorData 
    {
        

        public void UpdateTags_M1(OpcClient client, ref string strM1Name, ref double dM1Position, ref int nM1Mode, ref bool bM1Status, ref double dM1Temp)
        {
            //Motor1             
            string strTagName = "ns=2;s=Motor1/Name";
            Opc.UaFx.OpcValue opcM1Name = client.ReadNode(strTagName);
            strM1Name = (string)opcM1Name.Value;

            strTagName = "ns=2;s=Motor1/Position";
            Opc.UaFx.OpcValue opcM1Pos = client.ReadNode(strTagName);
            dM1Position = (double)opcM1Pos.Value;

            strTagName = "ns=2;s=Motor1/Mode";
            Opc.UaFx.OpcValue opcM1Mode = client.ReadNode(strTagName);
            nM1Mode = (int)opcM1Mode.Value;

            strTagName = "ns=2;s=Motor1/Status";
            Opc.UaFx.OpcValue opcM1Stt = client.ReadNode(strTagName);
            bM1Status = (bool)opcM1Stt.Value;

            strTagName = "ns=2;s=Motor1/Temperature";
            Opc.UaFx.OpcValue opcM1Temp = client.ReadNode(strTagName);
            dM1Temp = (double)opcM1Temp.Value;
            
        }
        public void UpdateTags_M2(OpcClient client, ref string strM2Name, ref double dM2Position, ref int nM2Mode, ref bool bM2Status, ref double dM2Temp)
        {
            //Motor2
            string strTagName = "ns=2;s=Motor2/Name";
            Opc.UaFx.OpcValue opcM2Name = client.ReadNode(strTagName);
            strM2Name = (string)opcM2Name.Value;
            
            strTagName = "ns=2;s=Motor2/Position";
            Opc.UaFx.OpcValue opcM2Pos = client.ReadNode(strTagName);
            dM2Position = (double)opcM2Pos.Value;

            strTagName = "ns=2;s=Motor2/Mode";
            Opc.UaFx.OpcValue opcM2Mode = client.ReadNode(strTagName);
            nM2Mode = (int)opcM2Mode.Value;

            strTagName = "ns=2;s=Motor2/Status";
            Opc.UaFx.OpcValue opcM2Stt = client.ReadNode(strTagName);
            bM2Status = (bool)opcM2Stt.Value;

            strTagName = "ns=2;s=Motor2/Temperature";
            Opc.UaFx.OpcValue opcM2Temp = client.ReadNode(strTagName);
            dM2Temp = (double)opcM2Temp.Value;
        }
    }   
}
