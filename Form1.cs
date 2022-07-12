using Opc.UaFx.Client;

namespace OPCUAReadData
{
    public partial class Form1 : Form
    {        
        OpcClient client = new OpcClient("opc.tcp://localhost:4840/"); // // ip address depends on the address of the server 

        string strName;
        double dPosition;
        int nMode;
        bool bStatus;
        double dTemperature;
        double dValue;
        public ReadMotorData readMotor = new ReadMotorData();
        public ReadRobotData readRobot = new ReadRobotData();
        public ReadSensorData readSensor = new ReadSensorData();

        public Form1 ()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                client.Connect();
                UpdateTimer.Start();
                lbStatusMsg.Text = "Connected to OPC UA Server";
                txtServerAddr.Text = "opc.tcp://localhost:4840/";
            }
            catch (Exception ex)
            {
                lbStatusMsg.Text = "Server is not open!!!";
            }
            
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            UpdateTimer.Stop();
            if (client != null)
            {
                client.Disconnect();
                lbStatusMsg.Text = "Disconected from OPC UA Server";
            }
            else
                lbStatusMsg.Text = "Client hasn't connected to Server";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (client != null)
                client.Disconnect();
        }

        private void UpdateTimer_Tick(object sender, EventArgs e)
        {
            DateTime sensorDateTime = DateTime.Now;
            txtTimeStamp.Text = sensorDateTime.ToString("yyyy-MM-dd HH:mm:ss");
            //try
            //{
            //    OPCUAReadMotor();                
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("No Motor output data ");
            //}
            //try
            //{
            //    OPCUAReadRobot();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("No Robot output data ");
            //}
            //try
            //{
            //    OPCUAReadSensor();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("No Sensor output data ");
            //}
            OPCUAReadMotor();
            OPCUAReadRobot();
            OPCUAReadSensor();
        }

        public void OPCUAReadMotor()
        {
            readMotor.UpdateTags_M1(client, ref strName, ref dPosition, ref nMode, ref bStatus, ref dTemperature);
            txtM1Name.Text = strName;
            txtM1Position.Text = dPosition.ToString();
            txtM1Mode.Text = nMode.ToString();
            lbM1Status.Text = bStatus.ToString();
            txtM1Temp.Text = dTemperature.ToString();

            readMotor.UpdateTags_M2(client, ref strName, ref dPosition, ref nMode, ref bStatus, ref dTemperature);
            txtM2Name.Text = strName;
            txtM2Position.Text = dPosition.ToString();
            txtM2Mode.Text = nMode.ToString();
            lbM2Status.Text = bStatus.ToString();
            txtM2Temp.Text = dTemperature.ToString();

        }

        public void OPCUAReadRobot()
        {
            readRobot.UpdateTags_R1(client, ref strName, ref dPosition, ref nMode, ref bStatus, ref dTemperature);
            txtRB1Name.Text = strName;
            txtRB1Position.Text = dPosition.ToString();
            txtRB1Mode.Text = nMode.ToString();
            lbRB1Status.Text = bStatus.ToString();
            txtRB1Temp.Text = dTemperature.ToString();

            readRobot.UpdateTags_R2(client, ref strName, ref dPosition, ref nMode, ref bStatus, ref dTemperature);
            txtRB2Name.Text = strName;
            txtRB2Position.Text = dPosition.ToString();
            txtRB2Mode.Text = nMode.ToString();
            lbRB2Status.Text = bStatus.ToString();
            txtRB2Temp.Text = dTemperature.ToString(); 
        }

        public void OPCUAReadSensor()
        {
            readSensor.UpdateTags_S1(client, ref strName, ref bStatus, ref dValue);
            txtS1Name.Text = strName;
            lbS1Status.Text = bStatus.ToString();
            txtS1Value.Text = dValue.ToString();

            readSensor.UpdateTags_S2(client, ref strName, ref bStatus, ref dValue);
            txtS2Name.Text = strName;
            lbS2Status.Text = bStatus.ToString();
            txtS2Value.Text = dValue.ToString();
        }

    }
   
}