using System;
using System.Drawing;
using System.Globalization;
using System.IO.Ports;
using System.Linq;
using System.Management;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Microsoft.Win32;

namespace CPU_Monitor {
    public partial class CpuMonitor : Form {
        /// <summary>
        ///     The length of the x axis of the chart
        /// </summary>
        private const int XMaxValue = 30;

        /// <summary>
        ///     The char which indicates the end of a transmitted value
        /// </summary>
        private const string ReadToChar = "!";

        /// <summary>
        ///     The char which tells the uart device to reset
        /// </summary>
        private const string UartExitChar = "#";

        private int _pointsIndex;

        public CpuMonitor() {
            InitializeComponent();
        }

        private void CPU_Monitor_Load(object sender, EventArgs e) {
            // Set ComboBox defaults
            baudPicker.SelectedItem = "9600";
            speedPicker.SelectedItem = "Mittel";

            // Set chart colors to window border color
            Color borderColor = Color.FromArgb((int) Registry.GetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\DWM", "ColorizationColor", null));
            chart.Series["CPU"].BorderColor = borderColor;
            chart.Series["CPU"].Color = borderColor;

            // Set up the maximum x axis value of the chart
            chart.ChartAreas[0].AxisX.Maximum = XMaxValue;
        }

        private void CPU_Monitor_FormClosing(object sender, FormClosingEventArgs e) {
            // Close UART
            try {
                if (serialPort.IsOpen) {
                    uart_SendData(UartExitChar);
                    serialPort.Close();
                }
            }
            catch (Exception) {
                Application.Exit();
            }
        }

        private void portPicker_DropDown(object sender, EventArgs e) {
            // Clear old COM devices
            portPicker.Items.Clear();

            // Add all connected COM devices to portPicker
            foreach (ManagementBaseObject serialDevice in new ManagementObjectSearcher("SELECT * FROM WIN32_SerialPort").Get())
                portPicker.Items.Add(serialDevice["Caption"]);
        }

        private void portPicker_SelectionChangeCommitted(object sender, EventArgs e) {
            // Set the selected COM port number
            serialPort.PortName = "COM" + new string(portPicker.SelectedItem.ToString().Where(Char.IsDigit).ToArray());

            // Now we can connect to the selected UART device
            connectButton.Enabled = true;
        }

        private void baudPicker_SelectionChangeCommitted(object sender, EventArgs e) {
            // Set selected baud rate
            serialPort.BaudRate = (int) baudPicker.SelectedItem;
        }

        private void speedPicker_SelectionChangeCommitted(object sender, EventArgs e) {
            // Set selected timer speed
            switch (speedPicker.SelectedItem.ToString()) {
                case "Hoch":
                    timer.Interval = 250;
                    timer.Enabled = true;
                    break;
                case "Mittel":
                    timer.Interval = 500;
                    timer.Enabled = true;
                    break;
                case "Niedrig":
                    timer.Interval = 1500;
                    timer.Enabled = true;
                    break;
                case "Angehalten":
                    timer.Enabled = false;
                    break;
            }
        }

        private void connectButton_Click(object sender, EventArgs e) {
            timer.Enabled = true;
            uart_connect();
        }

        private void disconnectButton_Click(object sender, EventArgs e) {
            uart_close();
        }

        private void timer_Tick(object sender, EventArgs e) {
            // Round CPU usage
            String cpuUsage = Math.Round(performanceCounter.NextValue(), 0).ToString(CultureInfo.InvariantCulture);

            // Add CPU usage to chart
            DataPointCollection points = chart.Series["CPU"].Points;
            points.AddXY(_pointsIndex, cpuUsage);

            while (points.Count > XMaxValue)
                points.RemoveAt(0);

            if (_pointsIndex < XMaxValue)
                _pointsIndex++;

            // Send cpu usage to UART
            if (checkBox.Checked)
                uart_SendData(cpuUsage);
        }

        private void serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e) {
            // Log received value to receivedBox
            LogData(serialPort.ReadTo(ReadToChar), receivedBox);
        }

        private void inputBox_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e) {
            // When the user presses ENTER send the text over uart if the text valid
            if (e.KeyCode == Keys.Enter) {
                string text = inputBox.Text;
                if (text.All(Char.IsDigit) && text != String.Empty) {
                    int zahl = Convert.ToInt32(text);
                    if (zahl >= 0 && zahl <= 100)
                        uart_SendData(inputBox.Text);
                }

                // Clear inputBox
                inputBox.Clear();
            }
        }

        /// <summary>
        ///     Add text to selected textBox
        /// </summary>
        /// <param name="text">The text that should be shown</param>
        /// <param name="box">The desired textbox</param>
        private void LogData(string text, TextBoxBase box) {
            Invoke(new MethodInvoker(() => box.AppendText(text + Environment.NewLine)));
        }

        /// <summary>
        ///     Send string over UART
        /// </summary>
        /// <param name="text">The string that should be sent</param>
        private void uart_SendData(string text) {
            try {
                if (serialPort.IsOpen) {
                    serialPort.Write(text + ReadToChar);
                    LogData(text, sendBox);
                }
            }
            catch (Exception exception) {
                timer.Enabled = false;
                //uart_close();
                ShowError(exception);
            }
        }

        /// <summary>
        ///     Connect to UART
        /// </summary>
        private void uart_connect() {
            try {
                serialPort.Open();
                if (serialPort.IsOpen) {
                    disconnectButton.Enabled = true;
                    connectButton.Enabled = false;
                    portPicker.Enabled = false;
                    baudPicker.Enabled = false;
                    inputBox.Enabled = true;
                }
            }
            catch (Exception exception) {
                ShowError(exception);
            }
        }

        /// <summary>
        ///     Close UART
        /// </summary>
        private void uart_close() {
            try {
                uart_SendData(UartExitChar);
                serialPort.Close();
                if (!serialPort.IsOpen) {
                    disconnectButton.Enabled = false;
                    connectButton.Enabled = true;
                    portPicker.Enabled = true;
                    baudPicker.Enabled = true;
                    inputBox.Enabled = false;
                }
            }
            catch (Exception exception) {
                ShowError(exception);
            }
        }

        /// <summary>
        ///     Show exception
        /// </summary>
        /// <param name="exception">The exception that should be displayed</param>
        private static void ShowError(Exception exception) {
            MessageBox.Show(exception.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}