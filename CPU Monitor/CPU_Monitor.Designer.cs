namespace CPU_Monitor
{
    partial class CpuMonitor
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CpuMonitor));
            this.connectButton = new System.Windows.Forms.Button();
            this.portPicker = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.baudPicker = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.uartBox = new System.Windows.Forms.GroupBox();
            this.disconnectButton = new System.Windows.Forms.Button();
            this.cpuBox = new System.Windows.Forms.GroupBox();
            this.checkBox = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.speedPicker = new System.Windows.Forms.ComboBox();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.receivedBox = new System.Windows.Forms.TextBox();
            this.performanceCounter = new System.Diagnostics.PerformanceCounter();
            this.sendBox = new System.Windows.Forms.TextBox();
            this.inputBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.uartBox.SuspendLayout();
            this.cpuBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter)).BeginInit();
            this.SuspendLayout();
            // 
            // connectButton
            // 
            this.connectButton.Enabled = false;
            this.connectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectButton.Location = new System.Drawing.Point(10, 81);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(244, 58);
            this.connectButton.TabIndex = 0;
            this.connectButton.Text = "Verbinde";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // portPicker
            // 
            this.portPicker.FormattingEnabled = true;
            this.portPicker.ItemHeight = 13;
            this.portPicker.Location = new System.Drawing.Point(100, 15);
            this.portPicker.Name = "portPicker";
            this.portPicker.Size = new System.Drawing.Size(150, 21);
            this.portPicker.TabIndex = 1;
            this.portPicker.DropDown += new System.EventHandler(this.portPicker_DropDown);
            this.portPicker.SelectionChangeCommitted += new System.EventHandler(this.portPicker_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Port Name:";
            // 
            // baudPicker
            // 
            this.baudPicker.FormattingEnabled = true;
            this.baudPicker.Items.AddRange(new object[] {
            "75",
            "300",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "28800",
            "38400",
            "57600",
            "115200"});
            this.baudPicker.Location = new System.Drawing.Point(100, 54);
            this.baudPicker.Name = "baudPicker";
            this.baudPicker.Size = new System.Drawing.Size(150, 21);
            this.baudPicker.TabIndex = 3;
            this.baudPicker.SelectionChangeCommitted += new System.EventHandler(this.baudPicker_SelectionChangeCommitted);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Baud Rate:";
            // 
            // serialPort
            // 
            this.serialPort.PortName = "COM5";
            this.serialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort_DataReceived);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1500;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // uartBox
            // 
            this.uartBox.Controls.Add(this.disconnectButton);
            this.uartBox.Controls.Add(this.label1);
            this.uartBox.Controls.Add(this.connectButton);
            this.uartBox.Controls.Add(this.baudPicker);
            this.uartBox.Controls.Add(this.label2);
            this.uartBox.Controls.Add(this.portPicker);
            this.uartBox.Location = new System.Drawing.Point(12, 12);
            this.uartBox.Name = "uartBox";
            this.uartBox.Size = new System.Drawing.Size(260, 214);
            this.uartBox.TabIndex = 5;
            this.uartBox.TabStop = false;
            this.uartBox.Text = "UART";
            // 
            // disconnectButton
            // 
            this.disconnectButton.Enabled = false;
            this.disconnectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disconnectButton.Location = new System.Drawing.Point(10, 145);
            this.disconnectButton.Name = "disconnectButton";
            this.disconnectButton.Size = new System.Drawing.Size(244, 60);
            this.disconnectButton.TabIndex = 6;
            this.disconnectButton.Text = "Trennen";
            this.disconnectButton.UseVisualStyleBackColor = true;
            this.disconnectButton.Click += new System.EventHandler(this.disconnectButton_Click);
            // 
            // cpuBox
            // 
            this.cpuBox.Controls.Add(this.checkBox);
            this.cpuBox.Controls.Add(this.label3);
            this.cpuBox.Controls.Add(this.speedPicker);
            this.cpuBox.Controls.Add(this.chart);
            this.cpuBox.Location = new System.Drawing.Point(279, 12);
            this.cpuBox.Name = "cpuBox";
            this.cpuBox.Size = new System.Drawing.Size(341, 214);
            this.cpuBox.TabIndex = 6;
            this.cpuBox.TabStop = false;
            this.cpuBox.Text = "CPU";
            // 
            // checkBox
            // 
            this.checkBox.AutoSize = true;
            this.checkBox.Checked = true;
            this.checkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox.Location = new System.Drawing.Point(34, 179);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(280, 24);
            this.checkBox.TabIndex = 9;
            this.checkBox.Text = "Sende CPU Auslastung über UART";
            this.checkBox.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(233, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Aktualisierungsgeschwindigkeit:";
            // 
            // speedPicker
            // 
            this.speedPicker.FormattingEnabled = true;
            this.speedPicker.ItemHeight = 13;
            this.speedPicker.Items.AddRange(new object[] {
            "Hoch",
            "Mittel",
            "Niedrig",
            "Angehalten"});
            this.speedPicker.Location = new System.Drawing.Point(241, 147);
            this.speedPicker.Name = "speedPicker";
            this.speedPicker.Size = new System.Drawing.Size(94, 21);
            this.speedPicker.TabIndex = 7;
            this.speedPicker.SelectionChangeCommitted += new System.EventHandler(this.speedPicker_SelectionChangeCommitted);
            // 
            // chart
            // 
            this.chart.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Area3DStyle.Enable3D = true;
            chartArea1.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea1.AxisX.IsMarginVisible = false;
            chartArea1.AxisX.LabelStyle.Enabled = false;
            chartArea1.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea1.AxisY.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea1.AxisY.IsMarginVisible = false;
            chartArea1.AxisY.Maximum = 100D;
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            this.chart.Location = new System.Drawing.Point(6, 15);
            this.chart.Name = "chart";
            series1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalLeft;
            series1.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center;
            series1.BackImageWrapMode = System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode.Scaled;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.IsXValueIndexed = true;
            series1.Name = "CPU";
            this.chart.Series.Add(series1);
            this.chart.Size = new System.Drawing.Size(329, 124);
            this.chart.TabIndex = 0;
            this.chart.Text = "CPU Auslastung";
            // 
            // receivedBox
            // 
            this.receivedBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.receivedBox.Location = new System.Drawing.Point(12, 254);
            this.receivedBox.Multiline = true;
            this.receivedBox.Name = "receivedBox";
            this.receivedBox.ReadOnly = true;
            this.receivedBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.receivedBox.Size = new System.Drawing.Size(260, 155);
            this.receivedBox.TabIndex = 7;
            // 
            // performanceCounter
            // 
            this.performanceCounter.CategoryName = "Prozessor";
            this.performanceCounter.CounterName = "Prozessorzeit (%)";
            this.performanceCounter.InstanceName = "_Total";
            // 
            // sendBox
            // 
            this.sendBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.sendBox.Location = new System.Drawing.Point(279, 254);
            this.sendBox.Multiline = true;
            this.sendBox.Name = "sendBox";
            this.sendBox.ReadOnly = true;
            this.sendBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.sendBox.Size = new System.Drawing.Size(341, 155);
            this.sendBox.TabIndex = 8;
            // 
            // inputBox
            // 
            this.inputBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.inputBox.Enabled = false;
            this.inputBox.Location = new System.Drawing.Point(279, 415);
            this.inputBox.Name = "inputBox";
            this.inputBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.inputBox.Size = new System.Drawing.Size(341, 20);
            this.inputBox.TabIndex = 9;
            this.inputBox.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.inputBox_PreviewKeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Empfangen:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(275, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Gesendet:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(135, 415);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Sende Auslastung:";
            // 
            // CpuMonitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 447);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.inputBox);
            this.Controls.Add(this.sendBox);
            this.Controls.Add(this.receivedBox);
            this.Controls.Add(this.cpuBox);
            this.Controls.Add(this.uartBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CpuMonitor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CPU Monitor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CPU_Monitor_FormClosing);
            this.Load += new System.EventHandler(this.CPU_Monitor_Load);
            this.uartBox.ResumeLayout(false);
            this.uartBox.PerformLayout();
            this.cpuBox.ResumeLayout(false);
            this.cpuBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.ComboBox portPicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox baudPicker;
        private System.Windows.Forms.Label label2;
        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.GroupBox uartBox;
        private System.Windows.Forms.Button disconnectButton;
        private System.Windows.Forms.GroupBox cpuBox;
        private System.Windows.Forms.TextBox receivedBox;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox speedPicker;
        private System.Diagnostics.PerformanceCounter performanceCounter;
        private System.Windows.Forms.CheckBox checkBox;
        private System.Windows.Forms.TextBox sendBox;
        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;

    }
}

