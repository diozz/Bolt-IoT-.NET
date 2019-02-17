using System;
using System.Net;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Web.Script.Serialization;

namespace BoltIoT
{
    public class Bolt
    {
        public string ApiKey;
        public string DeviceId;

        private readonly string EndpointUrl = "https://cloud.boltiot.com/remote/";

        public Bolt(string apiKey, string deviceId)
        {
            this.ApiKey = apiKey;
            this.DeviceId = deviceId;
        }

        #region GPIO Operations

        /// <summary>
        /// Writes digital output.
        /// </summary>
        /// <param name="pin">It is the Bolt GPIO pin you want to write to. It can take any of the following values 0, 1, 2, 3, 4.</param>
        /// <param name="state">It is the output voltage to be provided on the GPIO. It can take value DigitalStates.HIGH(3.3V) or DigitalStates.LOW(0V)</param>
        /// <returns>Response object</returns>
        public async Task<Response> DigitalWrite(string pin, string state)
        {
            string Querry = BuildQuerry("/digitalWrite?pin=" + pin + "&state=" + state);

            string responseString = "";
            await Task.Run(delegate
            {
                responseString = (new WebClient()).DownloadString(Querry);
            });

            return new Response(responseString);
        }

        /// <summary>
        /// Writes digital outputs to multiple pins at a time.
        /// </summary>
        /// <param name="muliConfig">Object of MultiPinConfig class which contains a list of pins and corresponding values to be set.</param>
        /// <returns></returns>
        public async Task<Response> DigitalMultiWrite(MultiPinConfig muliConfig)
        {
            string Querry = BuildQuerry("/digitalMultiWrite?pins=" + muliConfig.PinCsv + "&state=" + muliConfig.StateCsv);

            string responseString = "";
            await Task.Run(delegate
            {
                responseString = (new WebClient()).DownloadString(Querry);
            });

            return new Response(responseString);
        }

        /// <summary>
        /// Reads digital input.
        /// </summary>
        /// <param name="pin">It is the Bolt GPIO pin you want to read from. It can take any of the following values 0, 1, 2, 3, 4.</param>
        /// <returns>Response object</returns>
        public async Task<Response> DigitalRead(string pin)
        {
            string Querry = BuildQuerry("/digitalRead?pin=" + pin);

            string responseString = "";
            await Task.Run(delegate
            {
                responseString = (new WebClient()).DownloadString(Querry);
            });

            return new Response(responseString);
        }

        /// <summary>
        /// Reads multiple digital inputs at a time.
        /// </summary>
        /// <param name="pins">List of pins to read from.</param>
        /// <returns>Response object</returns>
        public async Task<Response> DigitalMultiRead(List<string> pins)
        {
            string Querry = BuildQuerry("/digitalMultiRead?pins=" + string.Join(",", pins));

            string responseString = "";
            await Task.Run(delegate
            {
                responseString = (new WebClient()).DownloadString(Querry);
            });

            return new Response(responseString);
        }

        /// <summary>
        /// Write analog output.
        /// </summary>
        /// <param name="pin">It is the Bolt GPIO pin you want to write to. It can take value 0, 1, 2, 3, 4.</param>
        /// <param name="value">It is the analog output voltage to be provided on the GPIO. It can take value between 0-255.</param>
        /// <returns>Response object</returns>
        public async Task<Response> AnalogWrite(string pin, int value)
        {
            string Querry = BuildQuerry("/analogWrite?pin=" + pin + "&value=" + value.ToString());

            string responseString = "";
            await Task.Run(delegate
            {
                responseString = (new WebClient()).DownloadString(Querry);
            });

            return new Response(responseString);
        }

        /// <summary>
        /// Writes analog outputs to multiple pins at a time.
        /// </summary>
        /// <param name="muliConfig">Object of MultiPinConfig class which contains a list of pins and corresponding values to be set.</param>
        /// <returns>Response object</returns>
        public async Task<Response> AnalogMultiWrite(MultiPinConfig muliConfig)
        {
            string Querry = BuildQuerry("/analogMultiWrite?pins=" + muliConfig.PinCsv + "&state=" + muliConfig.StateCsv);

            string responseString = "";
            await Task.Run(delegate
            {
                responseString = (new WebClient()).DownloadString(Querry);
            });

            return new Response(responseString);
        }

        /// <summary>
        /// Reads analog input.
        /// </summary>
        /// <param name="pin">It is the Bolt GPIO pin you want to read from. It can take value A0.</param>
        /// <returns>Response object</returns>
        public async Task<Response> AnalogRead(string pin /* =A0 */)
        {
            string Querry = BuildQuerry("/analogRead?pin=" + pin);

            string responseString = "";
            await Task.Run(delegate
            {
                responseString = (new WebClient()).DownloadString(Querry);
            });

            return new Response(responseString);
        }

        #endregion

        #region UART Operatioins

        /// <summary>
        /// Initializes serial communication.
        /// </summary>
        /// <param name="baudRate">It is the baud rate to be set for Bolt. It can take value 2400, 4800, 9600, 19200.</param>
        /// <returns>Response object</returns>
        public async Task<Response> SerialBegin(BaudRates baudRate)
        {
            string Querry = BuildQuerry("/serialBegin?baud=" + ((int)baudRate).ToString());

            string responseString = "";
            await Task.Run(delegate
            {
                responseString = (new WebClient()).DownloadString(Querry);
            });

            return new Response(responseString);
        }

        /// <summary>
        /// Sends serial data output through TX pin.
        /// </summary>
        /// <param name="data">Data string that will be transmitted as ASCII characters.</param>
        /// <returns>Response object</returns>
        public async Task<Response> SerialWrite(string data)
        {
            string Querry = BuildQuerry("/serialWrite?data=" + Uri.EscapeUriString(data));

            string responseString = "";
            await Task.Run(delegate
            {
                responseString = (new WebClient()).DownloadString(Querry);
            });

            return new Response(responseString);
        }

        /// <summary>
        /// Reads incomming serial data.
        /// </summary>
        /// <returns>Response object</returns>
        public async Task<Response> SerialRead()
        {
            string Querry = BuildQuerry("/serialRead?till=10");

            string responseString = "";
            await Task.Run(delegate
            {
                responseString = (new WebClient()).DownloadString(Querry);
            });

            return new Response(responseString);
        }

        /// <summary>
        /// Reads incomming serial data.
        /// </summary>
        /// <param name="till">Read the data upto the specified 'till' value from the incoming UART data to Bolt. It takes ASCII value of the character from 0-127.  If you want to read till a newline char '\n' the ASCII value corresponding to '\n' is 10, the above command is given. Note: till is an optional parameter.</param>
        /// <returns>Response object</returns>
        public async Task<Response> SerialRead(string till)
        {
            string Querry = BuildQuerry("/serialRead?till=" + till);

            string responseString = "";
            await Task.Run(delegate
            {
                responseString = (new WebClient()).DownloadString(Querry);
            });

            return new Response(responseString);
        }

        /// <summary>
        /// Write and then read serial data
        /// </summary>
        /// <param name="data">The data that has to be written to the UART.</param>
        /// <param name="till">ead the data upto the specified 'till' value from the incoming UART data to Bolt. It takes ASCII value of the character from 0-127. If you want to read till a newline char '\n' the ASCII value corresponding to '\n' is 10, the above command is given. Note: till is an optional parameter.</param>
        /// <returns>Response object</returns>
        public async Task<Response> SerialWriteRead(string data, string till = "10")
        {
            string Querry = BuildQuerry("/serialWR?data=" + Uri.EscapeUriString(data) + "&till=" + till);

            string responseString = "";
            await Task.Run(delegate
            {
                responseString = (new WebClient()).DownloadString(Querry);
            });

            return new Response(responseString);
        }

        #endregion

        #region Utility Functions

        /// <summary>
        /// Returns the version details of your Bolt.
        /// </summary>
        /// <returns>Response object</returns>
        public async Task<Response> GetDeviceVersion()
        {
            string Querry = BuildQuerry("/version?");

            string responseString = "";
            await Task.Run(delegate
            {
                responseString = (new WebClient()).DownloadString(Querry);
            });

            return new Response(responseString);
        }


        /// <summary>
        /// Restarts your Bolt device.
        /// </summary>
        /// <returns>Response object</returns>
        public async Task<Response> Restart()
        {
            string Querry = BuildQuerry("/restart?");

            string responseString = "";
            await Task.Run(delegate
            {
                responseString = (new WebClient()).DownloadString(Querry);
            });

            return new Response(responseString);
        }


        /// <summary>
        /// Gets device status. Will return the device status along with the time when the device was online/offline respectively. It returns time in UTC standard.
        /// </summary>
        /// <returns>Response object</returns>
        public async Task<Response> IsOnline()
        {
            string Querry = BuildQuerry("/isOnline?");

            string responseString = "";
            await Task.Run(delegate
            {
                responseString = (new WebClient()).DownloadString(Querry);
            });

            return new Response(responseString);
        }

        #endregion

        /// <summary>
        /// Private function that appends Device ID, API Key and EndpointUrl to a build a URL querry.
        /// </summary>
        /// <param name="parameters">URL parameters</param>
        /// <returns></returns>
        private string BuildQuerry(string parameters)
        {
            return EndpointUrl + ApiKey + parameters + "&deviceName=" + DeviceId;
        }
    }

    /// <summary>
    /// Helper class for using multiRead and multiWrite functions
    /// </summary>
    public class MultiPinConfig
    {
        private List<string> Pins;
        private List<string> States;

        public string PinCsv;
        public string StateCsv;

        public MultiPinConfig()
        {
            Pins = new List<string>();
            States = new List<string>();
        }

        public void AddPinState(string pin, string state)
        {
            Pins.Add(pin);
            States.Add(state);

            PinCsv = string.Join(",", Pins);
            StateCsv = string.Join(",", States);
        }

        public void ClearAll()
        {
            Pins.Clear();
            States.Clear();

            PinCsv = "";
            StateCsv = "";
        }
    }

    /// <summary>
    /// Allowed Baud Rates
    /// </summary>
    public enum BaudRates
    {
        Baud2400 = 2400,
        Baud4800 = 4800,
        Baud9600 = 9600,
        Baud19200 = 19200
    }

    /// <summary>
    /// Digital States
    /// </summary>
    public static class DigitalStates
    {
        public static readonly string High = "HIGH";
        public static readonly string Low = "LOW";
    }

    /// <summary>
    /// Available digital pins
    /// </summary>
    public static class DigitalPins
    {
        public static readonly string D0 = "0";
        public static readonly string D1 = "1";
        public static readonly string D2 = "2";
        public static readonly string D3 = "3";
        public static readonly string D4 = "4";
    }

    /// <summary>
    /// Available analog pins
    /// </summary>
    public static class AnalogPins
    {
        public static readonly string A0 = "A0";
    }

    /// <summary>
    /// Class representing the recieved json response
    /// </summary>
    public class Response
    {
        public bool Success;
        public string Value;
        public string ResponseString;

        public Response(string responseString)
        {
            this.ResponseString = responseString;

            dynamic item = new JavaScriptSerializer().Deserialize<object>(responseString);

            Success = item["success"].ToString() == "1";
            Value = item["value"];
        }
    }
}
