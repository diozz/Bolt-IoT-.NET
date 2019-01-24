using BoltIoT;
using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace BoltIoT_Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DigitalWritePinSel.SelectedIndex = 0;
            DigitalWriteStateSel.SelectedIndex = 0;
            DigitalReadPinSel.SelectedIndex = 0;
            AnalogReadPinSel.SelectedIndex = 0;
            AnalogWritePinSel.SelectedIndex = 0;
            BaudRateSel.SelectedIndex = 2;
        }

        public async void ExecuteDigitalWrite_Click(object sender, EventArgs e)
        {
            OperationsPanel.Enabled = false;
            CredentialsPanel.Enabled = false;

            Response.Text = "Waiting for response..";
            Status.Text = "Executing..";

            Bolt myBolt = new Bolt(ApiKey.Text.Trim(), DeviceId.Text.Trim());

            string state = DigitalWriteStateSel.SelectedIndex == 0 ? DigitalStates.Low : DigitalStates.High;
            string pin = "";

            switch (DigitalWritePinSel.SelectedIndex)
            {
                case 0: pin = DigitalPins.D0; break;
                case 1: pin = DigitalPins.D1; break;
                case 2: pin = DigitalPins.D2; break;
                case 3: pin = DigitalPins.D3; break;
                case 4: pin = DigitalPins.D4; break;
            }

            RequestURL.Text = BuildRequestUrl("digitalWrite", new List<string> { "pin", "state" }, new List<string> { pin, state });

            Response response = await myBolt.DigitalWrite(pin, state);

            Response.Text = response.ResponseString;
            Status.Text = "Ready";
            OperationsPanel.Enabled = true;
            CredentialsPanel.Enabled = true;
        }

        public async void ExecuteDigitalRead_Click(object sender, EventArgs e)
        {
            OperationsPanel.Enabled = false;
            CredentialsPanel.Enabled = false;
            Response.Text = "Waiting for response..";
            Status.Text = "Executing..";

            Bolt myBolt = new Bolt(ApiKey.Text.Trim(), DeviceId.Text.Trim());

            string pin = "";

            switch (DigitalReadPinSel.SelectedIndex)
            {
                case 0: pin = DigitalPins.D0; break;
                case 1: pin = DigitalPins.D1; break;
                case 2: pin = DigitalPins.D2; break;
                case 3: pin = DigitalPins.D3; break;
                case 4: pin = DigitalPins.D4; break;
            }

            RequestURL.Text = BuildRequestUrl("digitalRead", new List<string> { "pin" }, new List<string> { pin });

            Response response = await myBolt.DigitalRead(pin);

            Response.Text = response.ResponseString;
            Status.Text = "Ready";
            OperationsPanel.Enabled = true;
            CredentialsPanel.Enabled = true;
        }

        public async void ExecuteAnalogWrite_Click(object sender, EventArgs e)
        {
            OperationsPanel.Enabled = false;
            CredentialsPanel.Enabled = false;
            Response.Text = "Waiting for response..";
            Status.Text = "Executing..";

            Bolt myBolt = new Bolt(ApiKey.Text.Trim(), DeviceId.Text.Trim());

            string pin = "";

            switch (AnalogWritePinSel.SelectedIndex)
            {
                case 0: pin = DigitalPins.D0; break;
                case 1: pin = DigitalPins.D1; break;
                case 2: pin = DigitalPins.D2; break;
                case 3: pin = DigitalPins.D3; break;
                case 4: pin = DigitalPins.D4; break;
            }

            RequestURL.Text = BuildRequestUrl("analogWrite", new List<string> { "pin", "value" }, new List<string> { pin, AnalogWriteValue.Value.ToString() });

            Response response = await myBolt.AnalogWrite(pin, (int)AnalogWriteValue.Value);

            Response.Text = response.ResponseString;
            Status.Text = "Ready";
            OperationsPanel.Enabled = true;
            CredentialsPanel.Enabled = true;
        }

        public async void ExecuteAnalogRead_Click(object sender, EventArgs e)
        {
            OperationsPanel.Enabled = false;
            CredentialsPanel.Enabled = false;
            Response.Text = "Waiting for response..";
            Status.Text = "Executing..";

            Bolt myBolt = new Bolt(ApiKey.Text.Trim(), DeviceId.Text.Trim());

            RequestURL.Text = BuildRequestUrl("analogRead", new List<string> { "pin" }, new List<string> { AnalogPins.A0 });

            Response response = await myBolt.AnalogRead(AnalogPins.A0);

            Response.Text = response.ResponseString;
            Status.Text = "Ready";
            OperationsPanel.Enabled = true;
            CredentialsPanel.Enabled = true;
        }

        public async void ExecuteSerialBegin_Click(object sender, EventArgs e)
        {
            OperationsPanel.Enabled = false;
            CredentialsPanel.Enabled = false;
            Response.Text = "Waiting for response..";
            Status.Text = "Executing..";

            Bolt myBolt = new Bolt(ApiKey.Text.Trim(), DeviceId.Text.Trim());

            BaudRates baudRate = 0;

            switch (BaudRateSel.SelectedIndex)
            {
                case 0: baudRate = BaudRates.Baud2400; break;
                case 1: baudRate = BaudRates.Baud4800; break;
                case 2: baudRate = BaudRates.Baud9600; break;
                case 3: baudRate = BaudRates.Baud19200; break;
            }

            RequestURL.Text = BuildRequestUrl("serialBegin", new List<string> { "baud" }, new List<string> { ((int)baudRate).ToString() });

            Response response = await myBolt.SerialBegin(baudRate);

            Response.Text = response.ResponseString;
            Status.Text = "Ready";
            OperationsPanel.Enabled = true;
            CredentialsPanel.Enabled = true;

        }

        public async void ExecuteSerialWrite_Click(object sender, EventArgs e)
        {
            OperationsPanel.Enabled = false;
            CredentialsPanel.Enabled = false;
            Response.Text = "Waiting for response..";
            Status.Text = "Executing..";

            Bolt myBolt = new Bolt(ApiKey.Text.Trim(), DeviceId.Text.Trim());

            string data = SerialWriteData.Text.Trim();

            RequestURL.Text = BuildRequestUrl("serialWrite", new List<string> { "data" }, new List<string> { data });

            Response response = await myBolt.SerialWrite(data);

            Response.Text = response.ResponseString;
            Status.Text = "Ready";
            OperationsPanel.Enabled = true;
            CredentialsPanel.Enabled = true;
        }

        public async void ExecuteSerialRead_Click(object sender, EventArgs e)
        {
            OperationsPanel.Enabled = false;
            CredentialsPanel.Enabled = false;
            Response.Text = "Waiting for response..";
            Status.Text = "Executing..";

            Bolt myBolt = new Bolt(ApiKey.Text.Trim(), DeviceId.Text.Trim());

            string till = SerialReadTill.Value.ToString();

            RequestURL.Text = BuildRequestUrl("serialRead", new List<string> { "till" }, new List<string> { till });

            Response response = await myBolt.SerialRead(till);

            Response.Text = response.ResponseString;
            Status.Text = "Ready";
            OperationsPanel.Enabled = true;
            CredentialsPanel.Enabled = true;
        }

        public async void ExecuteSerialWriteRead_Click(object sender, EventArgs e)
        {
            OperationsPanel.Enabled = false;
            CredentialsPanel.Enabled = false;
            Response.Text = "Waiting for response..";
            Status.Text = "Executing..";

            Bolt myBolt = new Bolt(ApiKey.Text.Trim(), DeviceId.Text.Trim());

            string till = SerialWriteReadTill.Value.ToString();
            string data = SerialWriteReadData.Text.Trim();

            RequestURL.Text = BuildRequestUrl("serialWR", new List<string> { "data", "till" }, new List<string> { Uri.EscapeUriString(data), till });

            Response response = await myBolt.SerialWriteRead(data, till);

            Response.Text = response.ResponseString;
            Status.Text = "Ready";
            OperationsPanel.Enabled = true;
            CredentialsPanel.Enabled = true;
        }

        public async void ExecuteGetDeviceVersion_Click(object sender, EventArgs e)
        {
            OperationsPanel.Enabled = false;
            CredentialsPanel.Enabled = false;
            Response.Text = "Waiting for response..";
            Status.Text = "Executing..";

            Bolt myBolt = new Bolt(ApiKey.Text.Trim(), DeviceId.Text.Trim());

            RequestURL.Text = BuildRequestUrl("version", new List<string> { }, new List<string> { });

            Response response = await myBolt.GetDeviceVersion();

            Response.Text = response.ResponseString;
            Status.Text = "Ready";
            OperationsPanel.Enabled = true;
            CredentialsPanel.Enabled = true;
        }

        public async void ExecuteIsOnline_Click(object sender, EventArgs e)
        {
            OperationsPanel.Enabled = false;
            CredentialsPanel.Enabled = false;
            Response.Text = "Waiting for response..";
            Status.Text = "Executing..";

            Bolt myBolt = new Bolt(ApiKey.Text.Trim(), DeviceId.Text.Trim());

            RequestURL.Text = BuildRequestUrl("isOnline", new List<string> { }, new List<string> { });

            Response response = await myBolt.IsOnline();

            Response.Text = response.ResponseString;
            Status.Text = "Ready";
            OperationsPanel.Enabled = true;
            CredentialsPanel.Enabled = true;
        }

        public async void ExecuteRestart_Click(object sender, EventArgs e)
        {
            OperationsPanel.Enabled = false;
            CredentialsPanel.Enabled = false;
            Response.Text = "Waiting for response..";
            Status.Text = "Executing..";

            Bolt myBolt = new Bolt(ApiKey.Text.Trim(), DeviceId.Text.Trim());

            RequestURL.Text = BuildRequestUrl("restart", new List<string> { }, new List<string> { });

            Response response = await myBolt.Restart();

            Response.Text = response.ResponseString;
            Status.Text = "Ready";
            OperationsPanel.Enabled = true;
            CredentialsPanel.Enabled = true;
        }

        private string BuildRequestUrl(string functionName, List<string> parameterList, List<string> valueList)
        {
            string requestUrl = "https://cloud.boltiot.com/remote/" + ApiKey.Text.Trim() + "/" + functionName + "?";

            for (int i = 0; i < parameterList.Count; i++)
                requestUrl += parameterList[i] + "=" + valueList[i] + "&";

            requestUrl += "deviceName=" + DeviceId.Text.Trim();

            return requestUrl;
        }

        private async void CopyButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(RequestURL.Text);
            Status.Text = "Request URL Copied to Clipboard";
            await System.Threading.Tasks.Task.Delay(1800);
            Status.Text = "Ready";
        }
    }
}
