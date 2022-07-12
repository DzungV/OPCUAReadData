using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Opc.UaFx.Client;

namespace OPCUAReadData
{
    public class ReadRobotData 
    {
        public void UpdateTags_R1(OpcClient client, ref string strR1Name, ref double dR1Position, ref int nR1Mode, ref bool bR1Status, ref double dR1Temp)
        {
            //Robot1
            string strTagName = "ns=4;s=Robot1/Name";
            Opc.UaFx.OpcValue opcR1Name = client.ReadNode(strTagName);
            strR1Name = (string)opcR1Name.Value;

            strTagName = "ns=4;s=Robot1/Position";
            Opc.UaFx.OpcValue opcR1Pos = client.ReadNode(strTagName);
            dR1Position = (double)opcR1Pos.Value;

            strTagName = "ns=4;s=Robot1/Mode";
            Opc.UaFx.OpcValue opcR1Mode = client.ReadNode(strTagName);
            nR1Mode = (int)opcR1Mode.Value;

            strTagName = "ns=4;s=Robot1/Status";
            Opc.UaFx.OpcValue opcR1Stt = client.ReadNode(strTagName);
            bR1Status = (bool)opcR1Stt.Value;

            strTagName = "ns=4;s=Robot1/Temperature";
            Opc.UaFx.OpcValue opcR1Temp = client.ReadNode(strTagName);
            dR1Temp = (double)opcR1Temp.Value;
        }
        public void UpdateTags_R2(OpcClient client, ref string strR2Name, ref double dR2Position, ref int nR2Mode, ref bool bR2Status, ref double dR2Temp)
        {
            //Robot2
            string strTagName = "ns=4;s=Robot2/Name";
            Opc.UaFx.OpcValue opcR2Name = client.ReadNode(strTagName);
            strR2Name = (string)opcR2Name.Value;

            strTagName = "ns=4;s=Robot2/Position";
            Opc.UaFx.OpcValue opcR2Pos = client.ReadNode(strTagName);
            dR2Position = (double)opcR2Pos.Value;

            strTagName = "ns=4;s=Robot2/Mode";
            Opc.UaFx.OpcValue opcR2Mode = client.ReadNode(strTagName);
            nR2Mode = (int)opcR2Mode.Value;

            strTagName = "ns=4;s=Robot2/Status";
            Opc.UaFx.OpcValue opcR2Stt = client.ReadNode(strTagName);
            bR2Status = (bool)opcR2Stt.Value;

            strTagName = "ns=4;s=Robot2/Temperature";
            Opc.UaFx.OpcValue opcR2Temp = client.ReadNode(strTagName);
            dR2Temp = (double)opcR2Temp.Value;
        }
    }
}
