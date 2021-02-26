
namespace SoftSensConf
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageSerialPortConfig = new System.Windows.Forms.TabPage();
            this.labelConnectSerial = new System.Windows.Forms.Label();
            this.radioButtonConnectedSerial = new System.Windows.Forms.RadioButton();
            this.labelBaudRate = new System.Windows.Forms.Label();
            this.labelComPort = new System.Windows.Forms.Label();
            this.buttonDisconnect = new System.Windows.Forms.Button();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.comboBoxBaudRate = new System.Windows.Forms.ComboBox();
            this.comboBoxCOMPort = new System.Windows.Forms.ComboBox();
            this.tabPageInstrumentConfig = new System.Windows.Forms.TabPage();
            this.labelConnectInstrument = new System.Windows.Forms.Label();
            this.radioButtonConnectedInstrument = new System.Windows.Forms.RadioButton();
            this.buttonOpenFile = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonWrite = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.labelAH = new System.Windows.Forms.Label();
            this.labelAL = new System.Windows.Forms.Label();
            this.labelURV = new System.Windows.Forms.Label();
            this.labelLRV = new System.Windows.Forms.Label();
            this.labelTagName = new System.Windows.Forms.Label();
            this.textBoxAlarmHigh = new System.Windows.Forms.TextBox();
            this.textBoxAlarmLow = new System.Windows.Forms.TextBox();
            this.textBoxURV = new System.Windows.Forms.TextBox();
            this.textBoxLRV = new System.Windows.Forms.TextBox();
            this.textBoxTagName = new System.Windows.Forms.TextBox();
            this.tabPageValues = new System.Windows.Forms.TabPage();
            this.labelConnectValues = new System.Windows.Forms.Label();
            this.radioButtonConnectedValues = new System.Windows.Forms.RadioButton();
            this.labelStatus = new System.Windows.Forms.Label();
            this.textBoxStatus = new System.Windows.Forms.TextBox();
            this.listBoxSensorData = new System.Windows.Forms.ListBox();
            this.labelSensorSignal = new System.Windows.Forms.Label();
            this.comboBoxSensorSignal = new System.Windows.Forms.ComboBox();
            this.buttonStopAuto = new System.Windows.Forms.Button();
            this.buttonStartAuto = new System.Windows.Forms.Button();
            this.chartValues = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.SerialPort = new System.IO.Ports.SerialPort(this.components);
            this.saveFileDialogInstrument = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialogInstrument = new System.Windows.Forms.OpenFileDialog();
            this.timerChartAdd = new System.Windows.Forms.Timer(this.components);
            this.timerSerialRecieve = new System.Windows.Forms.Timer(this.components);
            this.saveFileDialogValues = new System.Windows.Forms.SaveFileDialog();
            this.timerStatus = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.timerSerialPortCheck = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPageSerialPortConfig.SuspendLayout();
            this.tabPageInstrumentConfig.SuspendLayout();
            this.tabPageValues.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartValues)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageSerialPortConfig);
            this.tabControl1.Controls.Add(this.tabPageInstrumentConfig);
            this.tabControl1.Controls.Add(this.tabPageValues);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(706, 422);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageSerialPortConfig
            // 
            this.tabPageSerialPortConfig.Controls.Add(this.labelConnectSerial);
            this.tabPageSerialPortConfig.Controls.Add(this.radioButtonConnectedSerial);
            this.tabPageSerialPortConfig.Controls.Add(this.labelBaudRate);
            this.tabPageSerialPortConfig.Controls.Add(this.labelComPort);
            this.tabPageSerialPortConfig.Controls.Add(this.buttonDisconnect);
            this.tabPageSerialPortConfig.Controls.Add(this.buttonConnect);
            this.tabPageSerialPortConfig.Controls.Add(this.comboBoxBaudRate);
            this.tabPageSerialPortConfig.Controls.Add(this.comboBoxCOMPort);
            this.tabPageSerialPortConfig.Location = new System.Drawing.Point(4, 22);
            this.tabPageSerialPortConfig.Name = "tabPageSerialPortConfig";
            this.tabPageSerialPortConfig.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSerialPortConfig.Size = new System.Drawing.Size(698, 396);
            this.tabPageSerialPortConfig.TabIndex = 0;
            this.tabPageSerialPortConfig.Text = "Serial Port";
            this.tabPageSerialPortConfig.UseVisualStyleBackColor = true;
            // 
            // labelConnectSerial
            // 
            this.labelConnectSerial.AutoSize = true;
            this.labelConnectSerial.Location = new System.Drawing.Point(29, 375);
            this.labelConnectSerial.Name = "labelConnectSerial";
            this.labelConnectSerial.Size = new System.Drawing.Size(0, 13);
            this.labelConnectSerial.TabIndex = 41;
            // 
            // radioButtonConnectedSerial
            // 
            this.radioButtonConnectedSerial.AutoSize = true;
            this.radioButtonConnectedSerial.Enabled = false;
            this.radioButtonConnectedSerial.Location = new System.Drawing.Point(8, 375);
            this.radioButtonConnectedSerial.Name = "radioButtonConnectedSerial";
            this.radioButtonConnectedSerial.Size = new System.Drawing.Size(14, 13);
            this.radioButtonConnectedSerial.TabIndex = 9;
            this.radioButtonConnectedSerial.TabStop = true;
            this.toolTip1.SetToolTip(this.radioButtonConnectedSerial, "Fills if connected.");
            this.radioButtonConnectedSerial.UseVisualStyleBackColor = true;
            // 
            // labelBaudRate
            // 
            this.labelBaudRate.AutoSize = true;
            this.labelBaudRate.Location = new System.Drawing.Point(220, 149);
            this.labelBaudRate.Name = "labelBaudRate";
            this.labelBaudRate.Size = new System.Drawing.Size(58, 13);
            this.labelBaudRate.TabIndex = 8;
            this.labelBaudRate.Text = "Baud Rate";
            // 
            // labelComPort
            // 
            this.labelComPort.AutoSize = true;
            this.labelComPort.Location = new System.Drawing.Point(220, 96);
            this.labelComPort.Name = "labelComPort";
            this.labelComPort.Size = new System.Drawing.Size(53, 13);
            this.labelComPort.TabIndex = 7;
            this.labelComPort.Text = "COM Port";
            // 
            // buttonDisconnect
            // 
            this.buttonDisconnect.Location = new System.Drawing.Point(285, 253);
            this.buttonDisconnect.Name = "buttonDisconnect";
            this.buttonDisconnect.Size = new System.Drawing.Size(121, 23);
            this.buttonDisconnect.TabIndex = 40;
            this.buttonDisconnect.Text = "Disconnect";
            this.toolTip1.SetToolTip(this.buttonDisconnect, "Disconnect from device.");
            this.buttonDisconnect.UseVisualStyleBackColor = true;
            this.buttonDisconnect.Click += new System.EventHandler(this.buttonDisconnect_Click);
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(285, 202);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(121, 23);
            this.buttonConnect.TabIndex = 30;
            this.buttonConnect.Text = "Connect";
            this.toolTip1.SetToolTip(this.buttonConnect, "Connect to device.");
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // comboBoxBaudRate
            // 
            this.comboBoxBaudRate.FormattingEnabled = true;
            this.comboBoxBaudRate.Items.AddRange(new object[] {
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400"});
            this.comboBoxBaudRate.Location = new System.Drawing.Point(285, 146);
            this.comboBoxBaudRate.Name = "comboBoxBaudRate";
            this.comboBoxBaudRate.Size = new System.Drawing.Size(121, 21);
            this.comboBoxBaudRate.TabIndex = 20;
            this.toolTip1.SetToolTip(this.comboBoxBaudRate, "Choose a baud rate.");
            // 
            // comboBoxCOMPort
            // 
            this.comboBoxCOMPort.FormattingEnabled = true;
            this.comboBoxCOMPort.Location = new System.Drawing.Point(285, 93);
            this.comboBoxCOMPort.Name = "comboBoxCOMPort";
            this.comboBoxCOMPort.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCOMPort.TabIndex = 10;
            this.toolTip1.SetToolTip(this.comboBoxCOMPort, "Choose a COM port.");
            this.comboBoxCOMPort.Enter += new System.EventHandler(this.comboBoxCOMPort_Enter);
            // 
            // tabPageInstrumentConfig
            // 
            this.tabPageInstrumentConfig.Controls.Add(this.labelConnectInstrument);
            this.tabPageInstrumentConfig.Controls.Add(this.radioButtonConnectedInstrument);
            this.tabPageInstrumentConfig.Controls.Add(this.buttonOpenFile);
            this.tabPageInstrumentConfig.Controls.Add(this.buttonSave);
            this.tabPageInstrumentConfig.Controls.Add(this.buttonWrite);
            this.tabPageInstrumentConfig.Controls.Add(this.buttonLoad);
            this.tabPageInstrumentConfig.Controls.Add(this.labelAH);
            this.tabPageInstrumentConfig.Controls.Add(this.labelAL);
            this.tabPageInstrumentConfig.Controls.Add(this.labelURV);
            this.tabPageInstrumentConfig.Controls.Add(this.labelLRV);
            this.tabPageInstrumentConfig.Controls.Add(this.labelTagName);
            this.tabPageInstrumentConfig.Controls.Add(this.textBoxAlarmHigh);
            this.tabPageInstrumentConfig.Controls.Add(this.textBoxAlarmLow);
            this.tabPageInstrumentConfig.Controls.Add(this.textBoxURV);
            this.tabPageInstrumentConfig.Controls.Add(this.textBoxLRV);
            this.tabPageInstrumentConfig.Controls.Add(this.textBoxTagName);
            this.tabPageInstrumentConfig.Location = new System.Drawing.Point(4, 22);
            this.tabPageInstrumentConfig.Name = "tabPageInstrumentConfig";
            this.tabPageInstrumentConfig.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageInstrumentConfig.Size = new System.Drawing.Size(698, 396);
            this.tabPageInstrumentConfig.TabIndex = 1;
            this.tabPageInstrumentConfig.Text = "Instrument";
            this.tabPageInstrumentConfig.UseVisualStyleBackColor = true;
            // 
            // labelConnectInstrument
            // 
            this.labelConnectInstrument.AutoSize = true;
            this.labelConnectInstrument.Location = new System.Drawing.Point(29, 375);
            this.labelConnectInstrument.Name = "labelConnectInstrument";
            this.labelConnectInstrument.Size = new System.Drawing.Size(0, 13);
            this.labelConnectInstrument.TabIndex = 92;
            // 
            // radioButtonConnectedInstrument
            // 
            this.radioButtonConnectedInstrument.AutoSize = true;
            this.radioButtonConnectedInstrument.Enabled = false;
            this.radioButtonConnectedInstrument.Location = new System.Drawing.Point(8, 375);
            this.radioButtonConnectedInstrument.Name = "radioButtonConnectedInstrument";
            this.radioButtonConnectedInstrument.Size = new System.Drawing.Size(14, 13);
            this.radioButtonConnectedInstrument.TabIndex = 91;
            this.radioButtonConnectedInstrument.TabStop = true;
            this.toolTip1.SetToolTip(this.radioButtonConnectedInstrument, "Fills if connected.");
            this.radioButtonConnectedInstrument.UseVisualStyleBackColor = true;
            // 
            // buttonOpenFile
            // 
            this.buttonOpenFile.Location = new System.Drawing.Point(451, 242);
            this.buttonOpenFile.Name = "buttonOpenFile";
            this.buttonOpenFile.Size = new System.Drawing.Size(59, 48);
            this.buttonOpenFile.TabIndex = 90;
            this.buttonOpenFile.Text = "Open File";
            this.toolTip1.SetToolTip(this.buttonOpenFile, "Open an existing file.");
            this.buttonOpenFile.UseVisualStyleBackColor = true;
            this.buttonOpenFile.Click += new System.EventHandler(this.buttonOpenFile_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(382, 242);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(59, 48);
            this.buttonSave.TabIndex = 80;
            this.buttonSave.Text = "Save";
            this.toolTip1.SetToolTip(this.buttonSave, "Save data in file.");
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonWrite
            // 
            this.buttonWrite.Location = new System.Drawing.Point(313, 242);
            this.buttonWrite.Name = "buttonWrite";
            this.buttonWrite.Size = new System.Drawing.Size(59, 48);
            this.buttonWrite.TabIndex = 70;
            this.buttonWrite.Text = "Write Data";
            this.toolTip1.SetToolTip(this.buttonWrite, "Write data to device.");
            this.buttonWrite.UseVisualStyleBackColor = true;
            this.buttonWrite.Click += new System.EventHandler(this.buttonWrite_Click);
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(244, 242);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(59, 48);
            this.buttonLoad.TabIndex = 60;
            this.buttonLoad.Text = "Read Data";
            this.toolTip1.SetToolTip(this.buttonLoad, "Read data from device.");
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // labelAH
            // 
            this.labelAH.AutoSize = true;
            this.labelAH.Location = new System.Drawing.Point(134, 198);
            this.labelAH.Name = "labelAH";
            this.labelAH.Size = new System.Drawing.Size(58, 13);
            this.labelAH.TabIndex = 9;
            this.labelAH.Text = "Alarm High";
            // 
            // labelAL
            // 
            this.labelAL.AutoSize = true;
            this.labelAL.Location = new System.Drawing.Point(134, 165);
            this.labelAL.Name = "labelAL";
            this.labelAL.Size = new System.Drawing.Size(56, 13);
            this.labelAL.TabIndex = 8;
            this.labelAL.Text = "Alarm Low";
            // 
            // labelURV
            // 
            this.labelURV.AutoSize = true;
            this.labelURV.Location = new System.Drawing.Point(134, 132);
            this.labelURV.Name = "labelURV";
            this.labelURV.Size = new System.Drawing.Size(101, 13);
            this.labelURV.TabIndex = 7;
            this.labelURV.Text = "Upper Range Value";
            // 
            // labelLRV
            // 
            this.labelLRV.AutoSize = true;
            this.labelLRV.Location = new System.Drawing.Point(134, 99);
            this.labelLRV.Name = "labelLRV";
            this.labelLRV.Size = new System.Drawing.Size(101, 13);
            this.labelLRV.TabIndex = 6;
            this.labelLRV.Text = "Lower Range Value";
            // 
            // labelTagName
            // 
            this.labelTagName.AutoSize = true;
            this.labelTagName.Location = new System.Drawing.Point(134, 66);
            this.labelTagName.Name = "labelTagName";
            this.labelTagName.Size = new System.Drawing.Size(57, 13);
            this.labelTagName.TabIndex = 5;
            this.labelTagName.Text = "Tag Name";
            // 
            // textBoxAlarmHigh
            // 
            this.textBoxAlarmHigh.Location = new System.Drawing.Point(244, 198);
            this.textBoxAlarmHigh.MaxLength = 4;
            this.textBoxAlarmHigh.Name = "textBoxAlarmHigh";
            this.textBoxAlarmHigh.Size = new System.Drawing.Size(266, 20);
            this.textBoxAlarmHigh.TabIndex = 50;
            this.textBoxAlarmHigh.Text = "440";
            this.toolTip1.SetToolTip(this.textBoxAlarmHigh, "Enter highest alarm range.");
            this.textBoxAlarmHigh.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAlarmHigh_KeyPress);
            // 
            // textBoxAlarmLow
            // 
            this.textBoxAlarmLow.Location = new System.Drawing.Point(244, 165);
            this.textBoxAlarmLow.MaxLength = 4;
            this.textBoxAlarmLow.Name = "textBoxAlarmLow";
            this.textBoxAlarmLow.Size = new System.Drawing.Size(266, 20);
            this.textBoxAlarmLow.TabIndex = 40;
            this.textBoxAlarmLow.Text = "40";
            this.toolTip1.SetToolTip(this.textBoxAlarmLow, "Enter lowest alarm range.");
            this.textBoxAlarmLow.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAlarmLow_KeyPress);
            // 
            // textBoxURV
            // 
            this.textBoxURV.Location = new System.Drawing.Point(244, 132);
            this.textBoxURV.MaxLength = 7;
            this.textBoxURV.Name = "textBoxURV";
            this.textBoxURV.Size = new System.Drawing.Size(266, 20);
            this.textBoxURV.TabIndex = 30;
            this.textBoxURV.Text = "500.0";
            this.toolTip1.SetToolTip(this.textBoxURV, "Enter a upper range value.");
            this.textBoxURV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxURV_KeyPress);
            // 
            // textBoxLRV
            // 
            this.textBoxLRV.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBoxLRV.Location = new System.Drawing.Point(244, 99);
            this.textBoxLRV.MaxLength = 7;
            this.textBoxLRV.Name = "textBoxLRV";
            this.textBoxLRV.Size = new System.Drawing.Size(266, 20);
            this.textBoxLRV.TabIndex = 20;
            this.textBoxLRV.Text = "0.0";
            this.toolTip1.SetToolTip(this.textBoxLRV, "Enter a lower range value.");
            this.textBoxLRV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxLRV_KeyPress);
            // 
            // textBoxTagName
            // 
            this.textBoxTagName.Location = new System.Drawing.Point(244, 66);
            this.textBoxTagName.MaxLength = 10;
            this.textBoxTagName.Name = "textBoxTagName";
            this.textBoxTagName.Size = new System.Drawing.Size(266, 20);
            this.textBoxTagName.TabIndex = 10;
            this.textBoxTagName.Text = "C385IT001";
            this.toolTip1.SetToolTip(this.textBoxTagName, "Enter Tag Name of device.");
            // 
            // tabPageValues
            // 
            this.tabPageValues.Controls.Add(this.labelConnectValues);
            this.tabPageValues.Controls.Add(this.radioButtonConnectedValues);
            this.tabPageValues.Controls.Add(this.labelStatus);
            this.tabPageValues.Controls.Add(this.textBoxStatus);
            this.tabPageValues.Controls.Add(this.listBoxSensorData);
            this.tabPageValues.Controls.Add(this.labelSensorSignal);
            this.tabPageValues.Controls.Add(this.comboBoxSensorSignal);
            this.tabPageValues.Controls.Add(this.buttonStopAuto);
            this.tabPageValues.Controls.Add(this.buttonStartAuto);
            this.tabPageValues.Controls.Add(this.chartValues);
            this.tabPageValues.Location = new System.Drawing.Point(4, 22);
            this.tabPageValues.Name = "tabPageValues";
            this.tabPageValues.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageValues.Size = new System.Drawing.Size(698, 396);
            this.tabPageValues.TabIndex = 2;
            this.tabPageValues.Text = "Values";
            this.tabPageValues.UseVisualStyleBackColor = true;
            // 
            // labelConnectValues
            // 
            this.labelConnectValues.AutoSize = true;
            this.labelConnectValues.Location = new System.Drawing.Point(29, 375);
            this.labelConnectValues.Name = "labelConnectValues";
            this.labelConnectValues.Size = new System.Drawing.Size(0, 13);
            this.labelConnectValues.TabIndex = 43;
            // 
            // radioButtonConnectedValues
            // 
            this.radioButtonConnectedValues.AutoSize = true;
            this.radioButtonConnectedValues.Enabled = false;
            this.radioButtonConnectedValues.Location = new System.Drawing.Point(8, 375);
            this.radioButtonConnectedValues.Name = "radioButtonConnectedValues";
            this.radioButtonConnectedValues.Size = new System.Drawing.Size(14, 13);
            this.radioButtonConnectedValues.TabIndex = 42;
            this.radioButtonConnectedValues.TabStop = true;
            this.toolTip1.SetToolTip(this.radioButtonConnectedValues, "Fills if connected.");
            this.radioButtonConnectedValues.UseVisualStyleBackColor = true;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(308, 356);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(40, 13);
            this.labelStatus.TabIndex = 8;
            this.labelStatus.Text = "Status:";
            // 
            // textBoxStatus
            // 
            this.textBoxStatus.Location = new System.Drawing.Point(349, 353);
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.ReadOnly = true;
            this.textBoxStatus.Size = new System.Drawing.Size(100, 20);
            this.textBoxStatus.TabIndex = 7;
            this.textBoxStatus.TabStop = false;
            this.toolTip1.SetToolTip(this.textBoxStatus, "Status from device.");
            // 
            // listBoxSensorData
            // 
            this.listBoxSensorData.FormattingEnabled = true;
            this.listBoxSensorData.Location = new System.Drawing.Point(19, 139);
            this.listBoxSensorData.Name = "listBoxSensorData";
            this.listBoxSensorData.Size = new System.Drawing.Size(154, 186);
            this.listBoxSensorData.TabIndex = 6;
            this.listBoxSensorData.TabStop = false;
            this.toolTip1.SetToolTip(this.listBoxSensorData, "Data from device as text.");
            // 
            // labelSensorSignal
            // 
            this.labelSensorSignal.AutoSize = true;
            this.labelSensorSignal.Location = new System.Drawing.Point(16, 15);
            this.labelSensorSignal.Name = "labelSensorSignal";
            this.labelSensorSignal.Size = new System.Drawing.Size(110, 13);
            this.labelSensorSignal.TabIndex = 5;
            this.labelSensorSignal.Text = "Choose sensor signal:";
            // 
            // comboBoxSensorSignal
            // 
            this.comboBoxSensorSignal.FormattingEnabled = true;
            this.comboBoxSensorSignal.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBoxSensorSignal.Items.AddRange(new object[] {
            "Raw",
            "Scaled"});
            this.comboBoxSensorSignal.Location = new System.Drawing.Point(19, 31);
            this.comboBoxSensorSignal.Name = "comboBoxSensorSignal";
            this.comboBoxSensorSignal.Size = new System.Drawing.Size(154, 21);
            this.comboBoxSensorSignal.Sorted = true;
            this.comboBoxSensorSignal.TabIndex = 10;
            this.toolTip1.SetToolTip(this.comboBoxSensorSignal, "Choose a sensor signal from the dropdown menu.");
            // 
            // buttonStopAuto
            // 
            this.buttonStopAuto.Location = new System.Drawing.Point(100, 74);
            this.buttonStopAuto.Name = "buttonStopAuto";
            this.buttonStopAuto.Size = new System.Drawing.Size(75, 23);
            this.buttonStopAuto.TabIndex = 30;
            this.buttonStopAuto.Text = "Stop";
            this.toolTip1.SetToolTip(this.buttonStopAuto, "Stop reading from device and save to file.");
            this.buttonStopAuto.UseVisualStyleBackColor = true;
            this.buttonStopAuto.Click += new System.EventHandler(this.buttonStopAuto_Click);
            // 
            // buttonStartAuto
            // 
            this.buttonStartAuto.Location = new System.Drawing.Point(19, 74);
            this.buttonStartAuto.Name = "buttonStartAuto";
            this.buttonStartAuto.Size = new System.Drawing.Size(75, 23);
            this.buttonStartAuto.TabIndex = 20;
            this.buttonStartAuto.Text = "Start";
            this.toolTip1.SetToolTip(this.buttonStartAuto, "Start reading from device.");
            this.buttonStartAuto.UseVisualStyleBackColor = true;
            this.buttonStartAuto.Click += new System.EventHandler(this.buttonStartAuto_Click);
            // 
            // chartValues
            // 
            chartArea4.Name = "ChartArea1";
            this.chartValues.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartValues.Legends.Add(legend4);
            this.chartValues.Location = new System.Drawing.Point(201, 6);
            this.chartValues.Name = "chartValues";
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series7.Legend = "Legend1";
            series7.Name = "SeriesRaw";
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series8.Legend = "Legend1";
            series8.Name = "SeriesScaled";
            this.chartValues.Series.Add(series7);
            this.chartValues.Series.Add(series8);
            this.chartValues.Size = new System.Drawing.Size(479, 341);
            this.chartValues.TabIndex = 0;
            this.chartValues.TabStop = false;
            this.chartValues.Text = "Values";
            this.toolTip1.SetToolTip(this.chartValues, "Chart of data from device as chart.");
            // 
            // saveFileDialogInstrument
            // 
            this.saveFileDialogInstrument.DefaultExt = "ssc";
            // 
            // openFileDialogInstrument
            // 
            this.openFileDialogInstrument.FileName = "openFileDialog1";
            // 
            // timerChartAdd
            // 
            this.timerChartAdd.Tick += new System.EventHandler(this.timerChartAdd_Tick);
            // 
            // timerSerialRecieve
            // 
            this.timerSerialRecieve.Tick += new System.EventHandler(this.timerSerialRecieve_Tick);
            // 
            // saveFileDialogValues
            // 
            this.saveFileDialogValues.DefaultExt = "csv";
            // 
            // timerStatus
            // 
            this.timerStatus.Interval = 50;
            this.timerStatus.Tick += new System.EventHandler(this.timerStatus_Tick);
            // 
            // timerSerialPortCheck
            // 
            this.timerSerialPortCheck.Tick += new System.EventHandler(this.timerSerialPortCheck_Tick);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 422);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormMain";
            this.Text = "SoftSensConf";
            this.tabControl1.ResumeLayout(false);
            this.tabPageSerialPortConfig.ResumeLayout(false);
            this.tabPageSerialPortConfig.PerformLayout();
            this.tabPageInstrumentConfig.ResumeLayout(false);
            this.tabPageInstrumentConfig.PerformLayout();
            this.tabPageValues.ResumeLayout(false);
            this.tabPageValues.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartValues)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageInstrumentConfig;
        private System.Windows.Forms.TabPage tabPageValues;
        private System.Windows.Forms.TabPage tabPageSerialPortConfig;
        private System.Windows.Forms.RadioButton radioButtonConnectedSerial;
        private System.Windows.Forms.Label labelBaudRate;
        private System.Windows.Forms.Label labelComPort;
        private System.Windows.Forms.Button buttonDisconnect;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.ComboBox comboBoxBaudRate;
        private System.Windows.Forms.ComboBox comboBoxCOMPort;
        private System.IO.Ports.SerialPort SerialPort;
        private System.Windows.Forms.Label labelAH;
        private System.Windows.Forms.Label labelAL;
        private System.Windows.Forms.Label labelURV;
        private System.Windows.Forms.Label labelLRV;
        private System.Windows.Forms.Label labelTagName;
        private System.Windows.Forms.TextBox textBoxAlarmHigh;
        private System.Windows.Forms.TextBox textBoxAlarmLow;
        private System.Windows.Forms.TextBox textBoxURV;
        private System.Windows.Forms.TextBox textBoxLRV;
        private System.Windows.Forms.TextBox textBoxTagName;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonWrite;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.SaveFileDialog saveFileDialogInstrument;
        private System.Windows.Forms.OpenFileDialog openFileDialogInstrument;
        private System.Windows.Forms.Button buttonOpenFile;
        private System.Windows.Forms.Button buttonStopAuto;
        private System.Windows.Forms.Button buttonStartAuto;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartValues;
        private System.Windows.Forms.Timer timerChartAdd;
        private System.Windows.Forms.Timer timerSerialRecieve;
        private System.Windows.Forms.Label labelSensorSignal;
        private System.Windows.Forms.ListBox listBoxSensorData;
        private System.Windows.Forms.SaveFileDialog saveFileDialogValues;
        private System.Windows.Forms.Timer timerStatus;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.TextBox textBoxStatus;
        private System.Windows.Forms.ComboBox comboBoxSensorSignal;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label labelConnectSerial;
        private System.Windows.Forms.Label labelConnectInstrument;
        private System.Windows.Forms.RadioButton radioButtonConnectedInstrument;
        private System.Windows.Forms.Label labelConnectValues;
        private System.Windows.Forms.RadioButton radioButtonConnectedValues;
        private System.Windows.Forms.Timer timerSerialPortCheck;
    }
}

