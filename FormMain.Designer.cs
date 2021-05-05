
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
            System.Windows.Forms.Label area_IDLabel;
            System.Windows.Forms.Label cOM_TypeLabel;
            System.Windows.Forms.Label baud_RateLabel;
            System.Windows.Forms.Label cOM_PortLabel;
            System.Windows.Forms.Label rCD_IDLabel1;
            System.Windows.Forms.Label area_IDLabel1;
            System.Windows.Forms.Label tagNameLabel;
            System.Windows.Forms.Label lRVLabel;
            System.Windows.Forms.Label uRVLabel;
            System.Windows.Forms.Label alarmLowLabel;
            System.Windows.Forms.Label alarmHighLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label unitLabel;
            System.Windows.Forms.Label type_IDLabel;
            System.Windows.Forms.Label maker_IDLabel;
            System.Windows.Forms.Label model_IDLabel;
            System.Windows.Forms.Label frequencyLabel1;
            System.Windows.Forms.Label input_OutputLabel;
            System.Windows.Forms.Label analog_DigitalLabel;
            System.Windows.Forms.Label area_IDLabel2;
            System.Windows.Forms.Label labelValueTagName;
            System.Windows.Forms.Label labelValueLRV;
            System.Windows.Forms.Label labelValueURV;
            System.Windows.Forms.Label labelValueAlarmLow;
            System.Windows.Forms.Label labelValueAlarmHigh;
            System.Windows.Forms.Label labelValueAnalogDigital;
            System.Windows.Forms.Label labelValueInputOutput;
            System.Windows.Forms.Label labelValueLogInterval;
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageSerialPortConfig = new System.Windows.Forms.TabPage();
            this.buttonTransferConnect = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelConnect = new System.Windows.Forms.Label();
            this.labelComPort = new System.Windows.Forms.Label();
            this.comboBoxCOMPort = new System.Windows.Forms.ComboBox();
            this.comboBoxBaudRate = new System.Windows.Forms.ComboBox();
            this.labelConnectSerial = new System.Windows.Forms.Label();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.radioButtonConnectedSerial = new System.Windows.Forms.RadioButton();
            this.buttonDisconnect = new System.Windows.Forms.Button();
            this.labelBaudRate = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.config_DAUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._Assignment_2__InstrumentDataSet = new SoftSensConf._Assignment_2__InstrumentDataSet();
            this.labelSerialPortLogINterval = new System.Windows.Forms.Label();
            this.labelDAU = new System.Windows.Forms.Label();
            this.comboBoxDAUAreaDescription = new System.Windows.Forms.ComboBox();
            this.areaForDAUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelFindDAU = new System.Windows.Forms.Label();
            this.comboBoxFindDAU = new System.Windows.Forms.ComboBox();
            this.configDAUComboBoxBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cOM_PortTextBox = new System.Windows.Forms.TextBox();
            this.baud_RateTextBox = new System.Windows.Forms.TextBox();
            this.cOM_TypeTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelRDC = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxAreaDescription = new System.Windows.Forms.ComboBox();
            this.config_RCDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.areaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxAreaID = new System.Windows.Forms.ComboBox();
            this.comboBoxFindRDC = new System.Windows.Forms.ComboBox();
            this.configRCDComboBoxBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelFindRDC = new System.Windows.Forms.Label();
            this.rCD_IDTextBox1 = new System.Windows.Forms.TextBox();
            this.tabPageInstrumentConfig = new System.Windows.Forms.TabPage();
            this.panel6 = new System.Windows.Forms.Panel();
            this.labelTypeSignal = new System.Windows.Forms.Label();
            this.labelInputOutput = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.input_OutputCheckBox = new System.Windows.Forms.CheckBox();
            this.config_InstrumentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.analog_DigitalCheckBox = new System.Windows.Forms.CheckBox();
            this.labelConnectInstrument = new System.Windows.Forms.Label();
            this.radioButtonConnectedInstrument = new System.Windows.Forms.RadioButton();
            this.comboBoxModelIDInstrument = new System.Windows.Forms.ComboBox();
            this.modelTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSourceSQL = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxMakerIDInstrument = new System.Windows.Forms.ComboBox();
            this.makerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxTypeIDInstrument = new System.Windows.Forms.ComboBox();
            this.typeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.frequencyTextBox1 = new System.Windows.Forms.TextBox();
            this.comboBoxAreaIDInstrument = new System.Windows.Forms.ComboBox();
            this.areaForInstrumentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._Assignment_2__InstrumentDataSet3 = new SoftSensConf._Assignment_2__InstrumentDataSet();
            this.comboBoxTagName = new System.Windows.Forms.ComboBox();
            this.configInstrumentChooseBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.lRVTextBox = new System.Windows.Forms.TextBox();
            this.unitTextBox = new System.Windows.Forms.TextBox();
            this.uRVTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.alarmLowTextBox = new System.Windows.Forms.TextBox();
            this.alarmHighTextBox = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.buttonTranferEditToInstrument = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonOpenFile = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBoxAlarmHigh = new System.Windows.Forms.TextBox();
            this.textBoxURV = new System.Windows.Forms.TextBox();
            this.textBoxAlarmLow = new System.Windows.Forms.TextBox();
            this.labelURV = new System.Windows.Forms.Label();
            this.labelAL = new System.Windows.Forms.Label();
            this.labelAH = new System.Windows.Forms.Label();
            this.labelLRV = new System.Windows.Forms.Label();
            this.textBoxTagName = new System.Windows.Forms.TextBox();
            this.textBoxLRV = new System.Windows.Forms.TextBox();
            this.labelTagName = new System.Windows.Forms.Label();
            this.buttonWrite = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.buttonTransferValuesInstrument = new System.Windows.Forms.Button();
            this.tabPageValues = new System.Windows.Forms.TabPage();
            this.panel7 = new System.Windows.Forms.Panel();
            this.labelValueSimulation = new System.Windows.Forms.Label();
            this.buttonStartAuto = new System.Windows.Forms.Button();
            this.buttonStopAuto = new System.Windows.Forms.Button();
            this.labelINSTRUMENT_INFO = new System.Windows.Forms.Label();
            this.labelVALUES = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textBoxValueLogInterval = new System.Windows.Forms.TextBox();
            this.labelValueType = new System.Windows.Forms.Label();
            this.labelValueState = new System.Windows.Forms.Label();
            this.textBoxValueAlarmHigh = new System.Windows.Forms.TextBox();
            this.textBoxValueAlarmLow = new System.Windows.Forms.TextBox();
            this.textBoxValueURV = new System.Windows.Forms.TextBox();
            this.textBoxValueLRV = new System.Windows.Forms.TextBox();
            this.textBoxValueTagName = new System.Windows.Forms.TextBox();
            this.radioButtonConnectedValues = new System.Windows.Forms.RadioButton();
            this.labelConnectValues = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.textBoxStatus = new System.Windows.Forms.TextBox();
            this.listBoxSensorData = new System.Windows.Forms.ListBox();
            this.comboBoxSensorSignal = new System.Windows.Forms.ComboBox();
            this.chartValues = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.configInstrumentChooseBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.configInstrumentChooseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._Assignment_2__InstrumentDataSet2 = new SoftSensConf._Assignment_2__InstrumentDataSet();
            this.SerialPort = new System.IO.Ports.SerialPort(this.components);
            this.saveFileDialogInstrument = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialogInstrument = new System.Windows.Forms.OpenFileDialog();
            this.timerChartAdd = new System.Windows.Forms.Timer(this.components);
            this.timerSerialRecieve = new System.Windows.Forms.Timer(this.components);
            this.saveFileDialogValues = new System.Windows.Forms.SaveFileDialog();
            this.timerStatus = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.timerSerialPortCheck = new System.Windows.Forms.Timer(this.components);
            this.config_DAUTableAdapter = new SoftSensConf._Assignment_2__InstrumentDataSetTableAdapters.Config_DAUTableAdapter();
            this.tableAdapterManager = new SoftSensConf._Assignment_2__InstrumentDataSetTableAdapters.TableAdapterManager();
            this.config_RCDTableAdapter = new SoftSensConf._Assignment_2__InstrumentDataSetTableAdapters.Config_RCDTableAdapter();
            this.config_RCDComboBoxTableAdapter = new SoftSensConf._Assignment_2__InstrumentDataSetTableAdapters.Config_RCDComboBoxTableAdapter();
            this.config_DAUComboBoxTableAdapter = new SoftSensConf._Assignment_2__InstrumentDataSetTableAdapters.Config_DAUComboBoxTableAdapter();
            this.areaTableAdapter = new SoftSensConf._Assignment_2__InstrumentDataSetTableAdapters.AreaTableAdapter();
            this.configDAUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.areaForDAUTableAdapter = new SoftSensConf._Assignment_2__InstrumentDataSetTableAdapters.AreaForDAUTableAdapter();
            this.config_InstrumentTableAdapter = new SoftSensConf._Assignment_2__InstrumentDataSetTableAdapters.Config_InstrumentTableAdapter();
            this._Assignment_2__InstrumentDataSet1 = new SoftSensConf._Assignment_2__InstrumentDataSet();
            this.configInstrument1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.config_InstrumentChooseTableAdapter = new SoftSensConf._Assignment_2__InstrumentDataSetTableAdapters.Config_InstrumentChooseTableAdapter();
            this.areaForInstrumentTableAdapter = new SoftSensConf._Assignment_2__InstrumentDataSetTableAdapters.AreaForInstrumentTableAdapter();
            this.typeTableAdapter = new SoftSensConf._Assignment_2__InstrumentDataSetTableAdapters.TypeTableAdapter();
            this.makerTableAdapter = new SoftSensConf._Assignment_2__InstrumentDataSetTableAdapters.MakerTableAdapter();
            this.model_TableTableAdapter = new SoftSensConf._Assignment_2__InstrumentDataSetTableAdapters.Model_TableTableAdapter();
            this.timerStartRandom = new System.Windows.Forms.Timer(this.components);
            this.buttonValueClear = new System.Windows.Forms.Button();
            area_IDLabel = new System.Windows.Forms.Label();
            cOM_TypeLabel = new System.Windows.Forms.Label();
            baud_RateLabel = new System.Windows.Forms.Label();
            cOM_PortLabel = new System.Windows.Forms.Label();
            rCD_IDLabel1 = new System.Windows.Forms.Label();
            area_IDLabel1 = new System.Windows.Forms.Label();
            tagNameLabel = new System.Windows.Forms.Label();
            lRVLabel = new System.Windows.Forms.Label();
            uRVLabel = new System.Windows.Forms.Label();
            alarmLowLabel = new System.Windows.Forms.Label();
            alarmHighLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            unitLabel = new System.Windows.Forms.Label();
            type_IDLabel = new System.Windows.Forms.Label();
            maker_IDLabel = new System.Windows.Forms.Label();
            model_IDLabel = new System.Windows.Forms.Label();
            frequencyLabel1 = new System.Windows.Forms.Label();
            input_OutputLabel = new System.Windows.Forms.Label();
            analog_DigitalLabel = new System.Windows.Forms.Label();
            area_IDLabel2 = new System.Windows.Forms.Label();
            labelValueTagName = new System.Windows.Forms.Label();
            labelValueLRV = new System.Windows.Forms.Label();
            labelValueURV = new System.Windows.Forms.Label();
            labelValueAlarmLow = new System.Windows.Forms.Label();
            labelValueAlarmHigh = new System.Windows.Forms.Label();
            labelValueAnalogDigital = new System.Windows.Forms.Label();
            labelValueInputOutput = new System.Windows.Forms.Label();
            labelValueLogInterval = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPageSerialPortConfig.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.config_DAUBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._Assignment_2__InstrumentDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.areaForDAUBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.configDAUComboBoxBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.config_RCDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.areaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.configRCDComboBoxBindingSource)).BeginInit();
            this.tabPageInstrumentConfig.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.config_InstrumentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceSQL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.makerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.areaForInstrumentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._Assignment_2__InstrumentDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.configInstrumentChooseBindingSource2)).BeginInit();
            this.panel5.SuspendLayout();
            this.tabPageValues.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartValues)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.configInstrumentChooseBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.configInstrumentChooseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._Assignment_2__InstrumentDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.configDAUBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._Assignment_2__InstrumentDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.configInstrument1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // area_IDLabel
            // 
            area_IDLabel.AutoSize = true;
            area_IDLabel.Location = new System.Drawing.Point(11, 67);
            area_IDLabel.Name = "area_IDLabel";
            area_IDLabel.Size = new System.Drawing.Size(46, 13);
            area_IDLabel.TabIndex = 45;
            area_IDLabel.Text = "Area ID:";
            // 
            // cOM_TypeLabel
            // 
            cOM_TypeLabel.AutoSize = true;
            cOM_TypeLabel.Location = new System.Drawing.Point(11, 127);
            cOM_TypeLabel.Name = "cOM_TypeLabel";
            cOM_TypeLabel.Size = new System.Drawing.Size(61, 13);
            cOM_TypeLabel.TabIndex = 49;
            cOM_TypeLabel.Text = "COM Type:";
            // 
            // baud_RateLabel
            // 
            baud_RateLabel.AutoSize = true;
            baud_RateLabel.Location = new System.Drawing.Point(11, 157);
            baud_RateLabel.Name = "baud_RateLabel";
            baud_RateLabel.Size = new System.Drawing.Size(61, 13);
            baud_RateLabel.TabIndex = 51;
            baud_RateLabel.Text = "Baud Rate:";
            // 
            // cOM_PortLabel
            // 
            cOM_PortLabel.AutoSize = true;
            cOM_PortLabel.Location = new System.Drawing.Point(10, 97);
            cOM_PortLabel.Name = "cOM_PortLabel";
            cOM_PortLabel.Size = new System.Drawing.Size(56, 13);
            cOM_PortLabel.TabIndex = 53;
            cOM_PortLabel.Text = "COM-Port:";
            // 
            // rCD_IDLabel1
            // 
            rCD_IDLabel1.AutoSize = true;
            rCD_IDLabel1.Location = new System.Drawing.Point(8, 67);
            rCD_IDLabel1.Name = "rCD_IDLabel1";
            rCD_IDLabel1.Size = new System.Drawing.Size(47, 13);
            rCD_IDLabel1.TabIndex = 56;
            rCD_IDLabel1.Text = "RCD ID:";
            // 
            // area_IDLabel1
            // 
            area_IDLabel1.AutoSize = true;
            area_IDLabel1.Location = new System.Drawing.Point(8, 94);
            area_IDLabel1.Name = "area_IDLabel1";
            area_IDLabel1.Size = new System.Drawing.Size(51, 13);
            area_IDLabel1.TabIndex = 58;
            area_IDLabel1.Text = "Location:";
            // 
            // tagNameLabel
            // 
            tagNameLabel.AutoSize = true;
            tagNameLabel.Location = new System.Drawing.Point(9, 50);
            tagNameLabel.Name = "tagNameLabel";
            tagNameLabel.Size = new System.Drawing.Size(60, 13);
            tagNameLabel.TabIndex = 92;
            tagNameLabel.Text = "Tag Name:";
            // 
            // lRVLabel
            // 
            lRVLabel.AutoSize = true;
            lRVLabel.Location = new System.Drawing.Point(9, 76);
            lRVLabel.Name = "lRVLabel";
            lRVLabel.Size = new System.Drawing.Size(31, 13);
            lRVLabel.TabIndex = 94;
            lRVLabel.Text = "LRV:";
            // 
            // uRVLabel
            // 
            uRVLabel.AutoSize = true;
            uRVLabel.Location = new System.Drawing.Point(9, 102);
            uRVLabel.Name = "uRVLabel";
            uRVLabel.Size = new System.Drawing.Size(33, 13);
            uRVLabel.TabIndex = 96;
            uRVLabel.Text = "URV:";
            // 
            // alarmLowLabel
            // 
            alarmLowLabel.AutoSize = true;
            alarmLowLabel.Location = new System.Drawing.Point(9, 128);
            alarmLowLabel.Name = "alarmLowLabel";
            alarmLowLabel.Size = new System.Drawing.Size(59, 13);
            alarmLowLabel.TabIndex = 98;
            alarmLowLabel.Text = "Alarm Low:";
            // 
            // alarmHighLabel
            // 
            alarmHighLabel.AutoSize = true;
            alarmHighLabel.Location = new System.Drawing.Point(9, 154);
            alarmHighLabel.Name = "alarmHighLabel";
            alarmHighLabel.Size = new System.Drawing.Size(61, 13);
            alarmHighLabel.TabIndex = 100;
            alarmHighLabel.Text = "Alarm High:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(9, 206);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(63, 13);
            descriptionLabel.TabIndex = 106;
            descriptionLabel.Text = "Description:";
            // 
            // unitLabel
            // 
            unitLabel.AutoSize = true;
            unitLabel.Location = new System.Drawing.Point(9, 232);
            unitLabel.Name = "unitLabel";
            unitLabel.Size = new System.Drawing.Size(29, 13);
            unitLabel.TabIndex = 108;
            unitLabel.Text = "Unit:";
            // 
            // type_IDLabel
            // 
            type_IDLabel.AutoSize = true;
            type_IDLabel.Location = new System.Drawing.Point(9, 258);
            type_IDLabel.Name = "type_IDLabel";
            type_IDLabel.Size = new System.Drawing.Size(48, 13);
            type_IDLabel.TabIndex = 110;
            type_IDLabel.Text = "Type ID:";
            // 
            // maker_IDLabel
            // 
            maker_IDLabel.AutoSize = true;
            maker_IDLabel.Location = new System.Drawing.Point(9, 284);
            maker_IDLabel.Name = "maker_IDLabel";
            maker_IDLabel.Size = new System.Drawing.Size(54, 13);
            maker_IDLabel.TabIndex = 112;
            maker_IDLabel.Text = "Maker ID:";
            // 
            // model_IDLabel
            // 
            model_IDLabel.AutoSize = true;
            model_IDLabel.Location = new System.Drawing.Point(9, 310);
            model_IDLabel.Name = "model_IDLabel";
            model_IDLabel.Size = new System.Drawing.Size(53, 13);
            model_IDLabel.TabIndex = 114;
            model_IDLabel.Text = "Model ID:";
            // 
            // frequencyLabel1
            // 
            frequencyLabel1.AutoSize = true;
            frequencyLabel1.Location = new System.Drawing.Point(9, 336);
            frequencyLabel1.Name = "frequencyLabel1";
            frequencyLabel1.Size = new System.Drawing.Size(66, 13);
            frequencyLabel1.TabIndex = 116;
            frequencyLabel1.Text = "Log Interval:";
            // 
            // input_OutputLabel
            // 
            input_OutputLabel.AutoSize = true;
            input_OutputLabel.Location = new System.Drawing.Point(9, 364);
            input_OutputLabel.Name = "input_OutputLabel";
            input_OutputLabel.Size = new System.Drawing.Size(71, 13);
            input_OutputLabel.TabIndex = 118;
            input_OutputLabel.Text = "Input/Output:";
            // 
            // analog_DigitalLabel
            // 
            analog_DigitalLabel.AutoSize = true;
            analog_DigitalLabel.Location = new System.Drawing.Point(9, 394);
            analog_DigitalLabel.Name = "analog_DigitalLabel";
            analog_DigitalLabel.Size = new System.Drawing.Size(77, 13);
            analog_DigitalLabel.TabIndex = 120;
            analog_DigitalLabel.Text = "Analog/Digital:";
            // 
            // area_IDLabel2
            // 
            area_IDLabel2.AutoSize = true;
            area_IDLabel2.Location = new System.Drawing.Point(9, 180);
            area_IDLabel2.Name = "area_IDLabel2";
            area_IDLabel2.Size = new System.Drawing.Size(46, 13);
            area_IDLabel2.TabIndex = 104;
            area_IDLabel2.Text = "Area ID:";
            // 
            // labelValueTagName
            // 
            labelValueTagName.AutoSize = true;
            labelValueTagName.Location = new System.Drawing.Point(3, 29);
            labelValueTagName.Name = "labelValueTagName";
            labelValueTagName.Size = new System.Drawing.Size(60, 13);
            labelValueTagName.TabIndex = 93;
            labelValueTagName.Text = "Tag Name:";
            // 
            // labelValueLRV
            // 
            labelValueLRV.AutoSize = true;
            labelValueLRV.Location = new System.Drawing.Point(3, 57);
            labelValueLRV.Name = "labelValueLRV";
            labelValueLRV.Size = new System.Drawing.Size(31, 13);
            labelValueLRV.TabIndex = 101;
            labelValueLRV.Text = "LRV:";
            // 
            // labelValueURV
            // 
            labelValueURV.AutoSize = true;
            labelValueURV.Location = new System.Drawing.Point(3, 86);
            labelValueURV.Name = "labelValueURV";
            labelValueURV.Size = new System.Drawing.Size(33, 13);
            labelValueURV.TabIndex = 102;
            labelValueURV.Text = "URV:";
            // 
            // labelValueAlarmLow
            // 
            labelValueAlarmLow.AutoSize = true;
            labelValueAlarmLow.Location = new System.Drawing.Point(3, 115);
            labelValueAlarmLow.Name = "labelValueAlarmLow";
            labelValueAlarmLow.Size = new System.Drawing.Size(59, 13);
            labelValueAlarmLow.TabIndex = 103;
            labelValueAlarmLow.Text = "Alarm Low:";
            // 
            // labelValueAlarmHigh
            // 
            labelValueAlarmHigh.AutoSize = true;
            labelValueAlarmHigh.Location = new System.Drawing.Point(3, 144);
            labelValueAlarmHigh.Name = "labelValueAlarmHigh";
            labelValueAlarmHigh.Size = new System.Drawing.Size(61, 13);
            labelValueAlarmHigh.TabIndex = 104;
            labelValueAlarmHigh.Text = "Alarm High:";
            // 
            // labelValueAnalogDigital
            // 
            labelValueAnalogDigital.AutoSize = true;
            labelValueAnalogDigital.Location = new System.Drawing.Point(3, 176);
            labelValueAnalogDigital.Name = "labelValueAnalogDigital";
            labelValueAnalogDigital.Size = new System.Drawing.Size(77, 13);
            labelValueAnalogDigital.TabIndex = 132;
            labelValueAnalogDigital.Text = "Analog/Digital:";
            // 
            // labelValueInputOutput
            // 
            labelValueInputOutput.AutoSize = true;
            labelValueInputOutput.Location = new System.Drawing.Point(3, 204);
            labelValueInputOutput.Name = "labelValueInputOutput";
            labelValueInputOutput.Size = new System.Drawing.Size(71, 13);
            labelValueInputOutput.TabIndex = 131;
            labelValueInputOutput.Text = "Input/Output:";
            // 
            // labelValueLogInterval
            // 
            labelValueLogInterval.AutoSize = true;
            labelValueLogInterval.Location = new System.Drawing.Point(3, 232);
            labelValueLogInterval.Name = "labelValueLogInterval";
            labelValueLogInterval.Size = new System.Drawing.Size(66, 13);
            labelValueLogInterval.TabIndex = 133;
            labelValueLogInterval.Text = "Log Interval:";
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
            this.tabControl1.Size = new System.Drawing.Size(783, 458);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageSerialPortConfig
            // 
            this.tabPageSerialPortConfig.AutoScroll = true;
            this.tabPageSerialPortConfig.Controls.Add(this.buttonTransferConnect);
            this.tabPageSerialPortConfig.Controls.Add(this.panel3);
            this.tabPageSerialPortConfig.Controls.Add(this.panel2);
            this.tabPageSerialPortConfig.Controls.Add(this.panel1);
            this.tabPageSerialPortConfig.Location = new System.Drawing.Point(4, 22);
            this.tabPageSerialPortConfig.Name = "tabPageSerialPortConfig";
            this.tabPageSerialPortConfig.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSerialPortConfig.Size = new System.Drawing.Size(775, 432);
            this.tabPageSerialPortConfig.TabIndex = 0;
            this.tabPageSerialPortConfig.Text = "Serial Port";
            this.tabPageSerialPortConfig.UseVisualStyleBackColor = true;
            // 
            // buttonTransferConnect
            // 
            this.buttonTransferConnect.Location = new System.Drawing.Point(355, 158);
            this.buttonTransferConnect.Name = "buttonTransferConnect";
            this.buttonTransferConnect.Size = new System.Drawing.Size(91, 81);
            this.buttonTransferConnect.TabIndex = 128;
            this.buttonTransferConnect.Text = "Transfer Values  --->";
            this.buttonTransferConnect.UseVisualStyleBackColor = true;
            this.buttonTransferConnect.Click += new System.EventHandler(this.buttonTransferConnect_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.labelConnect);
            this.panel3.Controls.Add(this.labelComPort);
            this.panel3.Controls.Add(this.comboBoxCOMPort);
            this.panel3.Controls.Add(this.comboBoxBaudRate);
            this.panel3.Controls.Add(this.labelConnectSerial);
            this.panel3.Controls.Add(this.buttonConnect);
            this.panel3.Controls.Add(this.radioButtonConnectedSerial);
            this.panel3.Controls.Add(this.buttonDisconnect);
            this.panel3.Controls.Add(this.labelBaudRate);
            this.panel3.Location = new System.Drawing.Point(520, 18);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(221, 392);
            this.panel3.TabIndex = 64;
            // 
            // labelConnect
            // 
            this.labelConnect.AutoSize = true;
            this.labelConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.labelConnect.Location = new System.Drawing.Point(77, 8);
            this.labelConnect.Name = "labelConnect";
            this.labelConnect.Size = new System.Drawing.Size(75, 17);
            this.labelConnect.TabIndex = 69;
            this.labelConnect.Text = "CONNECT";
            // 
            // labelComPort
            // 
            this.labelComPort.AutoSize = true;
            this.labelComPort.Location = new System.Drawing.Point(15, 61);
            this.labelComPort.Name = "labelComPort";
            this.labelComPort.Size = new System.Drawing.Size(53, 13);
            this.labelComPort.TabIndex = 7;
            this.labelComPort.Text = "COM Port";
            // 
            // comboBoxCOMPort
            // 
            this.comboBoxCOMPort.FormattingEnabled = true;
            this.comboBoxCOMPort.Location = new System.Drawing.Point(80, 58);
            this.comboBoxCOMPort.Name = "comboBoxCOMPort";
            this.comboBoxCOMPort.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCOMPort.TabIndex = 10;
            this.toolTip1.SetToolTip(this.comboBoxCOMPort, "Choose a COM port.");
            this.comboBoxCOMPort.Enter += new System.EventHandler(this.comboBoxCOMPort_Enter);
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
            this.comboBoxBaudRate.Location = new System.Drawing.Point(80, 111);
            this.comboBoxBaudRate.Name = "comboBoxBaudRate";
            this.comboBoxBaudRate.Size = new System.Drawing.Size(121, 21);
            this.comboBoxBaudRate.TabIndex = 20;
            this.toolTip1.SetToolTip(this.comboBoxBaudRate, "Choose a baud rate.");
            // 
            // labelConnectSerial
            // 
            this.labelConnectSerial.AutoSize = true;
            this.labelConnectSerial.Location = new System.Drawing.Point(75, 168);
            this.labelConnectSerial.Name = "labelConnectSerial";
            this.labelConnectSerial.Size = new System.Drawing.Size(0, 13);
            this.labelConnectSerial.TabIndex = 41;
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(54, 217);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(121, 23);
            this.buttonConnect.TabIndex = 30;
            this.buttonConnect.Text = "Connect";
            this.toolTip1.SetToolTip(this.buttonConnect, "Connect to device.");
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // radioButtonConnectedSerial
            // 
            this.radioButtonConnectedSerial.AutoSize = true;
            this.radioButtonConnectedSerial.Enabled = false;
            this.radioButtonConnectedSerial.Location = new System.Drawing.Point(54, 168);
            this.radioButtonConnectedSerial.Name = "radioButtonConnectedSerial";
            this.radioButtonConnectedSerial.Size = new System.Drawing.Size(14, 13);
            this.radioButtonConnectedSerial.TabIndex = 9;
            this.radioButtonConnectedSerial.TabStop = true;
            this.toolTip1.SetToolTip(this.radioButtonConnectedSerial, "Fills if connected.");
            this.radioButtonConnectedSerial.UseVisualStyleBackColor = true;
            // 
            // buttonDisconnect
            // 
            this.buttonDisconnect.Location = new System.Drawing.Point(54, 268);
            this.buttonDisconnect.Name = "buttonDisconnect";
            this.buttonDisconnect.Size = new System.Drawing.Size(121, 23);
            this.buttonDisconnect.TabIndex = 40;
            this.buttonDisconnect.Text = "Disconnect";
            this.toolTip1.SetToolTip(this.buttonDisconnect, "Disconnect from device.");
            this.buttonDisconnect.UseVisualStyleBackColor = true;
            this.buttonDisconnect.Click += new System.EventHandler(this.buttonDisconnect_Click);
            // 
            // labelBaudRate
            // 
            this.labelBaudRate.AutoSize = true;
            this.labelBaudRate.Location = new System.Drawing.Point(15, 114);
            this.labelBaudRate.Name = "labelBaudRate";
            this.labelBaudRate.Size = new System.Drawing.Size(58, 13);
            this.labelBaudRate.TabIndex = 8;
            this.labelBaudRate.Text = "Baud Rate";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.labelSerialPortLogINterval);
            this.panel2.Controls.Add(this.labelDAU);
            this.panel2.Controls.Add(this.comboBoxDAUAreaDescription);
            this.panel2.Controls.Add(this.labelFindDAU);
            this.panel2.Controls.Add(this.comboBoxFindDAU);
            this.panel2.Controls.Add(this.cOM_PortTextBox);
            this.panel2.Controls.Add(cOM_PortLabel);
            this.panel2.Controls.Add(this.baud_RateTextBox);
            this.panel2.Controls.Add(area_IDLabel);
            this.panel2.Controls.Add(baud_RateLabel);
            this.panel2.Controls.Add(this.cOM_TypeTextBox);
            this.panel2.Controls.Add(cOM_TypeLabel);
            this.panel2.Location = new System.Drawing.Point(8, 208);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(289, 209);
            this.panel2.TabIndex = 63;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.config_DAUBindingSource, "Frequency", true));
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(81, 181);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(171, 20);
            this.textBox1.TabIndex = 70;
            // 
            // config_DAUBindingSource
            // 
            this.config_DAUBindingSource.DataMember = "Config-DAU";
            this.config_DAUBindingSource.DataSource = this._Assignment_2__InstrumentDataSet;
            // 
            // _Assignment_2__InstrumentDataSet
            // 
            this._Assignment_2__InstrumentDataSet.DataSetName = "_Assignment_2__InstrumentDataSet";
            this._Assignment_2__InstrumentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labelSerialPortLogINterval
            // 
            this.labelSerialPortLogINterval.AutoSize = true;
            this.labelSerialPortLogINterval.Location = new System.Drawing.Point(8, 184);
            this.labelSerialPortLogINterval.Name = "labelSerialPortLogINterval";
            this.labelSerialPortLogINterval.Size = new System.Drawing.Size(66, 13);
            this.labelSerialPortLogINterval.TabIndex = 69;
            this.labelSerialPortLogINterval.Text = "Log Interval:";
            // 
            // labelDAU
            // 
            this.labelDAU.AutoSize = true;
            this.labelDAU.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.labelDAU.Location = new System.Drawing.Point(128, 6);
            this.labelDAU.Name = "labelDAU";
            this.labelDAU.Size = new System.Drawing.Size(37, 17);
            this.labelDAU.TabIndex = 68;
            this.labelDAU.Text = "DAU";
            // 
            // comboBoxDAUAreaDescription
            // 
            this.comboBoxDAUAreaDescription.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.config_DAUBindingSource, "Area_ID", true));
            this.comboBoxDAUAreaDescription.DataSource = this.areaForDAUBindingSource;
            this.comboBoxDAUAreaDescription.DisplayMember = "Description";
            this.comboBoxDAUAreaDescription.Enabled = false;
            this.comboBoxDAUAreaDescription.FormattingEnabled = true;
            this.comboBoxDAUAreaDescription.Location = new System.Drawing.Point(80, 64);
            this.comboBoxDAUAreaDescription.Name = "comboBoxDAUAreaDescription";
            this.comboBoxDAUAreaDescription.Size = new System.Drawing.Size(171, 21);
            this.comboBoxDAUAreaDescription.TabIndex = 67;
            this.comboBoxDAUAreaDescription.ValueMember = "Area_ID";
            // 
            // areaForDAUBindingSource
            // 
            this.areaForDAUBindingSource.DataMember = "AreaForDAU";
            this.areaForDAUBindingSource.DataSource = this._Assignment_2__InstrumentDataSet;
            // 
            // labelFindDAU
            // 
            this.labelFindDAU.AutoSize = true;
            this.labelFindDAU.Location = new System.Drawing.Point(11, 37);
            this.labelFindDAU.Name = "labelFindDAU";
            this.labelFindDAU.Size = new System.Drawing.Size(56, 13);
            this.labelFindDAU.TabIndex = 58;
            this.labelFindDAU.Text = "Find DAU:";
            // 
            // comboBoxFindDAU
            // 
            this.comboBoxFindDAU.DataSource = this.configDAUComboBoxBindingSource;
            this.comboBoxFindDAU.DisplayMember = "Description";
            this.comboBoxFindDAU.FormattingEnabled = true;
            this.comboBoxFindDAU.Location = new System.Drawing.Point(80, 33);
            this.comboBoxFindDAU.Name = "comboBoxFindDAU";
            this.comboBoxFindDAU.Size = new System.Drawing.Size(171, 21);
            this.comboBoxFindDAU.TabIndex = 57;
            this.comboBoxFindDAU.ValueMember = "DAU_ID";
            this.comboBoxFindDAU.SelectedIndexChanged += new System.EventHandler(this.comboBoxFindDAU_SelectedIndexChanged);
            // 
            // configDAUComboBoxBindingSource
            // 
            this.configDAUComboBoxBindingSource.DataMember = "Config-DAUComboBox";
            this.configDAUComboBoxBindingSource.DataSource = this._Assignment_2__InstrumentDataSet;
            // 
            // cOM_PortTextBox
            // 
            this.cOM_PortTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.config_DAUBindingSource, "COM-Port", true));
            this.cOM_PortTextBox.Enabled = false;
            this.cOM_PortTextBox.Location = new System.Drawing.Point(80, 94);
            this.cOM_PortTextBox.Name = "cOM_PortTextBox";
            this.cOM_PortTextBox.Size = new System.Drawing.Size(171, 20);
            this.cOM_PortTextBox.TabIndex = 54;
            // 
            // baud_RateTextBox
            // 
            this.baud_RateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.config_DAUBindingSource, "Baud Rate", true));
            this.baud_RateTextBox.Enabled = false;
            this.baud_RateTextBox.Location = new System.Drawing.Point(81, 154);
            this.baud_RateTextBox.Name = "baud_RateTextBox";
            this.baud_RateTextBox.Size = new System.Drawing.Size(171, 20);
            this.baud_RateTextBox.TabIndex = 52;
            // 
            // cOM_TypeTextBox
            // 
            this.cOM_TypeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.config_DAUBindingSource, "COM_Type", true));
            this.cOM_TypeTextBox.Enabled = false;
            this.cOM_TypeTextBox.Location = new System.Drawing.Point(81, 124);
            this.cOM_TypeTextBox.Name = "cOM_TypeTextBox";
            this.cOM_TypeTextBox.Size = new System.Drawing.Size(171, 20);
            this.cOM_TypeTextBox.TabIndex = 50;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.labelRDC);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboBoxAreaDescription);
            this.panel1.Controls.Add(this.comboBoxAreaID);
            this.panel1.Controls.Add(this.comboBoxFindRDC);
            this.panel1.Controls.Add(this.labelFindRDC);
            this.panel1.Controls.Add(rCD_IDLabel1);
            this.panel1.Controls.Add(this.rCD_IDTextBox1);
            this.panel1.Controls.Add(area_IDLabel1);
            this.panel1.Location = new System.Drawing.Point(8, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(289, 161);
            this.panel1.TabIndex = 62;
            // 
            // labelRDC
            // 
            this.labelRDC.AutoSize = true;
            this.labelRDC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.labelRDC.Location = new System.Drawing.Point(128, 8);
            this.labelRDC.Name = "labelRDC";
            this.labelRDC.Size = new System.Drawing.Size(37, 17);
            this.labelRDC.TabIndex = 67;
            this.labelRDC.Text = "RDC";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 66;
            this.label1.Text = "Description:";
            // 
            // comboBoxAreaDescription
            // 
            this.comboBoxAreaDescription.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.config_RCDBindingSource, "Area_ID", true));
            this.comboBoxAreaDescription.DataSource = this.areaBindingSource;
            this.comboBoxAreaDescription.DisplayMember = "Description";
            this.comboBoxAreaDescription.Enabled = false;
            this.comboBoxAreaDescription.FormattingEnabled = true;
            this.comboBoxAreaDescription.Location = new System.Drawing.Point(77, 119);
            this.comboBoxAreaDescription.Name = "comboBoxAreaDescription";
            this.comboBoxAreaDescription.Size = new System.Drawing.Size(171, 21);
            this.comboBoxAreaDescription.TabIndex = 65;
            this.comboBoxAreaDescription.ValueMember = "Area_ID";
            // 
            // config_RCDBindingSource
            // 
            this.config_RCDBindingSource.DataMember = "Config-RCD";
            this.config_RCDBindingSource.DataSource = this._Assignment_2__InstrumentDataSet;
            // 
            // areaBindingSource
            // 
            this.areaBindingSource.DataMember = "Area";
            this.areaBindingSource.DataSource = this._Assignment_2__InstrumentDataSet;
            // 
            // comboBoxAreaID
            // 
            this.comboBoxAreaID.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.config_RCDBindingSource, "Area_ID", true));
            this.comboBoxAreaID.DataSource = this.areaBindingSource;
            this.comboBoxAreaID.DisplayMember = "Location";
            this.comboBoxAreaID.Enabled = false;
            this.comboBoxAreaID.FormattingEnabled = true;
            this.comboBoxAreaID.Location = new System.Drawing.Point(77, 91);
            this.comboBoxAreaID.Name = "comboBoxAreaID";
            this.comboBoxAreaID.Size = new System.Drawing.Size(171, 21);
            this.comboBoxAreaID.TabIndex = 64;
            this.comboBoxAreaID.ValueMember = "Area_ID";
            // 
            // comboBoxFindRDC
            // 
            this.comboBoxFindRDC.DataSource = this.configRCDComboBoxBindingSource;
            this.comboBoxFindRDC.DisplayMember = "Description";
            this.comboBoxFindRDC.FormattingEnabled = true;
            this.comboBoxFindRDC.Location = new System.Drawing.Point(77, 35);
            this.comboBoxFindRDC.Name = "comboBoxFindRDC";
            this.comboBoxFindRDC.Size = new System.Drawing.Size(171, 21);
            this.comboBoxFindRDC.TabIndex = 63;
            this.comboBoxFindRDC.ValueMember = "RCD_ID";
            this.comboBoxFindRDC.SelectedIndexChanged += new System.EventHandler(this.comboBoxFindRDC_SelectedIndexChanged);
            // 
            // configRCDComboBoxBindingSource
            // 
            this.configRCDComboBoxBindingSource.DataMember = "Config-RCDComboBox";
            this.configRCDComboBoxBindingSource.DataSource = this._Assignment_2__InstrumentDataSet;
            // 
            // labelFindRDC
            // 
            this.labelFindRDC.AutoSize = true;
            this.labelFindRDC.Location = new System.Drawing.Point(8, 38);
            this.labelFindRDC.Name = "labelFindRDC";
            this.labelFindRDC.Size = new System.Drawing.Size(56, 13);
            this.labelFindRDC.TabIndex = 62;
            this.labelFindRDC.Text = "Find RDC:";
            // 
            // rCD_IDTextBox1
            // 
            this.rCD_IDTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.config_RCDBindingSource, "Description", true));
            this.rCD_IDTextBox1.Enabled = false;
            this.rCD_IDTextBox1.Location = new System.Drawing.Point(77, 64);
            this.rCD_IDTextBox1.Name = "rCD_IDTextBox1";
            this.rCD_IDTextBox1.Size = new System.Drawing.Size(171, 20);
            this.rCD_IDTextBox1.TabIndex = 57;
            // 
            // tabPageInstrumentConfig
            // 
            this.tabPageInstrumentConfig.AutoScroll = true;
            this.tabPageInstrumentConfig.Controls.Add(this.panel6);
            this.tabPageInstrumentConfig.Controls.Add(this.panel5);
            this.tabPageInstrumentConfig.Controls.Add(this.buttonWrite);
            this.tabPageInstrumentConfig.Controls.Add(this.buttonLoad);
            this.tabPageInstrumentConfig.Controls.Add(this.buttonTransferValuesInstrument);
            this.tabPageInstrumentConfig.Location = new System.Drawing.Point(4, 22);
            this.tabPageInstrumentConfig.Name = "tabPageInstrumentConfig";
            this.tabPageInstrumentConfig.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageInstrumentConfig.Size = new System.Drawing.Size(775, 432);
            this.tabPageInstrumentConfig.TabIndex = 1;
            this.tabPageInstrumentConfig.Text = "Instrument";
            this.tabPageInstrumentConfig.UseVisualStyleBackColor = true;
            this.tabPageInstrumentConfig.Enter += new System.EventHandler(this.tabPageInstrumentConfig_Enter);
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.labelTypeSignal);
            this.panel6.Controls.Add(this.labelInputOutput);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Controls.Add(this.input_OutputCheckBox);
            this.panel6.Controls.Add(this.analog_DigitalCheckBox);
            this.panel6.Controls.Add(tagNameLabel);
            this.panel6.Controls.Add(this.labelConnectInstrument);
            this.panel6.Controls.Add(analog_DigitalLabel);
            this.panel6.Controls.Add(this.radioButtonConnectedInstrument);
            this.panel6.Controls.Add(this.comboBoxModelIDInstrument);
            this.panel6.Controls.Add(this.comboBoxMakerIDInstrument);
            this.panel6.Controls.Add(input_OutputLabel);
            this.panel6.Controls.Add(this.comboBoxTypeIDInstrument);
            this.panel6.Controls.Add(this.frequencyTextBox1);
            this.panel6.Controls.Add(this.comboBoxAreaIDInstrument);
            this.panel6.Controls.Add(frequencyLabel1);
            this.panel6.Controls.Add(this.comboBoxTagName);
            this.panel6.Controls.Add(model_IDLabel);
            this.panel6.Controls.Add(maker_IDLabel);
            this.panel6.Controls.Add(lRVLabel);
            this.panel6.Controls.Add(type_IDLabel);
            this.panel6.Controls.Add(this.lRVTextBox);
            this.panel6.Controls.Add(this.unitTextBox);
            this.panel6.Controls.Add(uRVLabel);
            this.panel6.Controls.Add(unitLabel);
            this.panel6.Controls.Add(this.uRVTextBox);
            this.panel6.Controls.Add(this.descriptionTextBox);
            this.panel6.Controls.Add(alarmLowLabel);
            this.panel6.Controls.Add(descriptionLabel);
            this.panel6.Controls.Add(this.alarmLowTextBox);
            this.panel6.Controls.Add(area_IDLabel2);
            this.panel6.Controls.Add(alarmHighLabel);
            this.panel6.Controls.Add(this.alarmHighTextBox);
            this.panel6.Location = new System.Drawing.Point(8, 6);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(273, 418);
            this.panel6.TabIndex = 129;
            // 
            // labelTypeSignal
            // 
            this.labelTypeSignal.AutoSize = true;
            this.labelTypeSignal.Location = new System.Drawing.Point(115, 394);
            this.labelTypeSignal.Name = "labelTypeSignal";
            this.labelTypeSignal.Size = new System.Drawing.Size(31, 13);
            this.labelTypeSignal.TabIndex = 129;
            this.labelTypeSignal.Text = "Type";
            // 
            // labelInputOutput
            // 
            this.labelInputOutput.AutoSize = true;
            this.labelInputOutput.Location = new System.Drawing.Point(115, 364);
            this.labelInputOutput.Name = "labelInputOutput";
            this.labelInputOutput.Size = new System.Drawing.Size(32, 13);
            this.labelInputOutput.TabIndex = 128;
            this.labelInputOutput.Text = "State";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.Location = new System.Drawing.Point(9, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 17);
            this.label2.TabIndex = 127;
            this.label2.Text = "INSTRUMENT:";
            // 
            // input_OutputCheckBox
            // 
            this.input_OutputCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.config_InstrumentBindingSource, "Input/Output", true));
            this.input_OutputCheckBox.Enabled = false;
            this.input_OutputCheckBox.Location = new System.Drawing.Point(92, 359);
            this.input_OutputCheckBox.Name = "input_OutputCheckBox";
            this.input_OutputCheckBox.Size = new System.Drawing.Size(104, 24);
            this.input_OutputCheckBox.TabIndex = 119;
            this.input_OutputCheckBox.UseVisualStyleBackColor = true;
            // 
            // config_InstrumentBindingSource
            // 
            this.config_InstrumentBindingSource.DataMember = "Config-Instrument";
            this.config_InstrumentBindingSource.DataSource = this._Assignment_2__InstrumentDataSet;
            // 
            // analog_DigitalCheckBox
            // 
            this.analog_DigitalCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.config_InstrumentBindingSource, "Analog/Digital", true));
            this.analog_DigitalCheckBox.Enabled = false;
            this.analog_DigitalCheckBox.Location = new System.Drawing.Point(92, 389);
            this.analog_DigitalCheckBox.Name = "analog_DigitalCheckBox";
            this.analog_DigitalCheckBox.Size = new System.Drawing.Size(104, 24);
            this.analog_DigitalCheckBox.TabIndex = 121;
            this.analog_DigitalCheckBox.UseVisualStyleBackColor = true;
            // 
            // labelConnectInstrument
            // 
            this.labelConnectInstrument.AutoSize = true;
            this.labelConnectInstrument.Location = new System.Drawing.Point(147, 15);
            this.labelConnectInstrument.Name = "labelConnectInstrument";
            this.labelConnectInstrument.Size = new System.Drawing.Size(0, 13);
            this.labelConnectInstrument.TabIndex = 92;
            // 
            // radioButtonConnectedInstrument
            // 
            this.radioButtonConnectedInstrument.AutoSize = true;
            this.radioButtonConnectedInstrument.Checked = true;
            this.radioButtonConnectedInstrument.Enabled = false;
            this.radioButtonConnectedInstrument.Location = new System.Drawing.Point(126, 15);
            this.radioButtonConnectedInstrument.Name = "radioButtonConnectedInstrument";
            this.radioButtonConnectedInstrument.Size = new System.Drawing.Size(14, 13);
            this.radioButtonConnectedInstrument.TabIndex = 91;
            this.radioButtonConnectedInstrument.TabStop = true;
            this.toolTip1.SetToolTip(this.radioButtonConnectedInstrument, "Fills if connected.");
            this.radioButtonConnectedInstrument.UseVisualStyleBackColor = true;
            // 
            // comboBoxModelIDInstrument
            // 
            this.comboBoxModelIDInstrument.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.config_InstrumentBindingSource, "Model_ID", true));
            this.comboBoxModelIDInstrument.DataSource = this.modelTableBindingSource;
            this.comboBoxModelIDInstrument.DisplayMember = "Name";
            this.comboBoxModelIDInstrument.Enabled = false;
            this.comboBoxModelIDInstrument.FormattingEnabled = true;
            this.comboBoxModelIDInstrument.Location = new System.Drawing.Point(92, 307);
            this.comboBoxModelIDInstrument.Name = "comboBoxModelIDInstrument";
            this.comboBoxModelIDInstrument.Size = new System.Drawing.Size(171, 21);
            this.comboBoxModelIDInstrument.TabIndex = 126;
            this.comboBoxModelIDInstrument.ValueMember = "Model_ID";
            // 
            // modelTableBindingSource
            // 
            this.modelTableBindingSource.DataMember = "Model_Table";
            this.modelTableBindingSource.DataSource = this.bindingSourceSQL;
            // 
            // bindingSourceSQL
            // 
            this.bindingSourceSQL.DataSource = this._Assignment_2__InstrumentDataSet;
            this.bindingSourceSQL.Position = 0;
            // 
            // comboBoxMakerIDInstrument
            // 
            this.comboBoxMakerIDInstrument.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.config_InstrumentBindingSource, "Maker_ID", true));
            this.comboBoxMakerIDInstrument.DataSource = this.makerBindingSource;
            this.comboBoxMakerIDInstrument.DisplayMember = "Name";
            this.comboBoxMakerIDInstrument.Enabled = false;
            this.comboBoxMakerIDInstrument.FormattingEnabled = true;
            this.comboBoxMakerIDInstrument.Location = new System.Drawing.Point(92, 281);
            this.comboBoxMakerIDInstrument.Name = "comboBoxMakerIDInstrument";
            this.comboBoxMakerIDInstrument.Size = new System.Drawing.Size(171, 21);
            this.comboBoxMakerIDInstrument.TabIndex = 125;
            this.comboBoxMakerIDInstrument.ValueMember = "Maker_ID";
            // 
            // makerBindingSource
            // 
            this.makerBindingSource.DataMember = "Maker";
            this.makerBindingSource.DataSource = this.bindingSourceSQL;
            // 
            // comboBoxTypeIDInstrument
            // 
            this.comboBoxTypeIDInstrument.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.config_InstrumentBindingSource, "Type_ID", true));
            this.comboBoxTypeIDInstrument.DataSource = this.typeBindingSource;
            this.comboBoxTypeIDInstrument.DisplayMember = "Description";
            this.comboBoxTypeIDInstrument.Enabled = false;
            this.comboBoxTypeIDInstrument.FormattingEnabled = true;
            this.comboBoxTypeIDInstrument.Location = new System.Drawing.Point(92, 255);
            this.comboBoxTypeIDInstrument.Name = "comboBoxTypeIDInstrument";
            this.comboBoxTypeIDInstrument.Size = new System.Drawing.Size(171, 21);
            this.comboBoxTypeIDInstrument.TabIndex = 124;
            this.comboBoxTypeIDInstrument.ValueMember = "Type_ID";
            // 
            // typeBindingSource
            // 
            this.typeBindingSource.DataMember = "Type";
            this.typeBindingSource.DataSource = this.bindingSourceSQL;
            // 
            // frequencyTextBox1
            // 
            this.frequencyTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.config_DAUBindingSource, "Frequency", true));
            this.frequencyTextBox1.Enabled = false;
            this.frequencyTextBox1.Location = new System.Drawing.Point(92, 333);
            this.frequencyTextBox1.Name = "frequencyTextBox1";
            this.frequencyTextBox1.Size = new System.Drawing.Size(171, 20);
            this.frequencyTextBox1.TabIndex = 117;
            // 
            // comboBoxAreaIDInstrument
            // 
            this.comboBoxAreaIDInstrument.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.config_InstrumentBindingSource, "Area_ID", true));
            this.comboBoxAreaIDInstrument.DataSource = this.areaForInstrumentBindingSource;
            this.comboBoxAreaIDInstrument.DisplayMember = "Description";
            this.comboBoxAreaIDInstrument.Enabled = false;
            this.comboBoxAreaIDInstrument.FormattingEnabled = true;
            this.comboBoxAreaIDInstrument.Location = new System.Drawing.Point(92, 177);
            this.comboBoxAreaIDInstrument.Name = "comboBoxAreaIDInstrument";
            this.comboBoxAreaIDInstrument.Size = new System.Drawing.Size(171, 21);
            this.comboBoxAreaIDInstrument.TabIndex = 123;
            this.comboBoxAreaIDInstrument.ValueMember = "Area_ID";
            // 
            // areaForInstrumentBindingSource
            // 
            this.areaForInstrumentBindingSource.DataMember = "AreaForInstrument";
            this.areaForInstrumentBindingSource.DataSource = this._Assignment_2__InstrumentDataSet3;
            // 
            // _Assignment_2__InstrumentDataSet3
            // 
            this._Assignment_2__InstrumentDataSet3.DataSetName = "_Assignment_2__InstrumentDataSet";
            this._Assignment_2__InstrumentDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBoxTagName
            // 
            this.comboBoxTagName.DataSource = this.configInstrumentChooseBindingSource2;
            this.comboBoxTagName.DisplayMember = "TagName";
            this.comboBoxTagName.FormattingEnabled = true;
            this.comboBoxTagName.Location = new System.Drawing.Point(92, 45);
            this.comboBoxTagName.Name = "comboBoxTagName";
            this.comboBoxTagName.Size = new System.Drawing.Size(171, 21);
            this.comboBoxTagName.TabIndex = 122;
            this.comboBoxTagName.ValueMember = "TagName";
            this.comboBoxTagName.SelectedIndexChanged += new System.EventHandler(this.comboBoxTagName_SelectedIndexChanged);
            // 
            // configInstrumentChooseBindingSource2
            // 
            this.configInstrumentChooseBindingSource2.DataMember = "Config-InstrumentChoose";
            this.configInstrumentChooseBindingSource2.DataSource = this.bindingSourceSQL;
            // 
            // lRVTextBox
            // 
            this.lRVTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.config_InstrumentBindingSource, "LRV", true));
            this.lRVTextBox.Enabled = false;
            this.lRVTextBox.Location = new System.Drawing.Point(92, 73);
            this.lRVTextBox.Name = "lRVTextBox";
            this.lRVTextBox.Size = new System.Drawing.Size(171, 20);
            this.lRVTextBox.TabIndex = 95;
            // 
            // unitTextBox
            // 
            this.unitTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.config_InstrumentBindingSource, "Unit", true));
            this.unitTextBox.Enabled = false;
            this.unitTextBox.Location = new System.Drawing.Point(92, 229);
            this.unitTextBox.Name = "unitTextBox";
            this.unitTextBox.Size = new System.Drawing.Size(171, 20);
            this.unitTextBox.TabIndex = 109;
            // 
            // uRVTextBox
            // 
            this.uRVTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.config_InstrumentBindingSource, "URV", true));
            this.uRVTextBox.Enabled = false;
            this.uRVTextBox.Location = new System.Drawing.Point(92, 99);
            this.uRVTextBox.Name = "uRVTextBox";
            this.uRVTextBox.Size = new System.Drawing.Size(171, 20);
            this.uRVTextBox.TabIndex = 97;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.config_InstrumentBindingSource, "Description", true));
            this.descriptionTextBox.Enabled = false;
            this.descriptionTextBox.Location = new System.Drawing.Point(92, 203);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(171, 20);
            this.descriptionTextBox.TabIndex = 107;
            // 
            // alarmLowTextBox
            // 
            this.alarmLowTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.config_InstrumentBindingSource, "AlarmLow", true));
            this.alarmLowTextBox.Enabled = false;
            this.alarmLowTextBox.Location = new System.Drawing.Point(92, 125);
            this.alarmLowTextBox.Name = "alarmLowTextBox";
            this.alarmLowTextBox.Size = new System.Drawing.Size(171, 20);
            this.alarmLowTextBox.TabIndex = 99;
            // 
            // alarmHighTextBox
            // 
            this.alarmHighTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.config_InstrumentBindingSource, "AlarmHigh", true));
            this.alarmHighTextBox.Enabled = false;
            this.alarmHighTextBox.Location = new System.Drawing.Point(92, 151);
            this.alarmHighTextBox.Name = "alarmHighTextBox";
            this.alarmHighTextBox.Size = new System.Drawing.Size(171, 20);
            this.alarmHighTextBox.TabIndex = 101;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.buttonTranferEditToInstrument);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.buttonOpenFile);
            this.panel5.Controls.Add(this.buttonSave);
            this.panel5.Controls.Add(this.textBoxAlarmHigh);
            this.panel5.Controls.Add(this.textBoxURV);
            this.panel5.Controls.Add(this.textBoxAlarmLow);
            this.panel5.Controls.Add(this.labelURV);
            this.panel5.Controls.Add(this.labelAL);
            this.panel5.Controls.Add(this.labelAH);
            this.panel5.Controls.Add(this.labelLRV);
            this.panel5.Controls.Add(this.textBoxTagName);
            this.panel5.Controls.Add(this.textBoxLRV);
            this.panel5.Controls.Add(this.labelTagName);
            this.panel5.Location = new System.Drawing.Point(438, 57);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(317, 283);
            this.panel5.TabIndex = 128;
            // 
            // buttonTranferEditToInstrument
            // 
            this.buttonTranferEditToInstrument.Location = new System.Drawing.Point(39, 215);
            this.buttonTranferEditToInstrument.Name = "buttonTranferEditToInstrument";
            this.buttonTranferEditToInstrument.Size = new System.Drawing.Size(71, 48);
            this.buttonTranferEditToInstrument.TabIndex = 130;
            this.buttonTranferEditToInstrument.Text = "Save to Database";
            this.buttonTranferEditToInstrument.UseVisualStyleBackColor = true;
            this.buttonTranferEditToInstrument.Click += new System.EventHandler(this.buttonTranferEditToInstrument_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label3.Location = new System.Drawing.Point(110, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 17);
            this.label3.TabIndex = 128;
            this.label3.Text = "EDIT VALUES";
            // 
            // buttonOpenFile
            // 
            this.buttonOpenFile.Location = new System.Drawing.Point(224, 215);
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
            this.buttonSave.Location = new System.Drawing.Point(137, 215);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(59, 48);
            this.buttonSave.TabIndex = 80;
            this.buttonSave.Text = "Save to File";
            this.toolTip1.SetToolTip(this.buttonSave, "Save data in file.");
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // textBoxAlarmHigh
            // 
            this.textBoxAlarmHigh.Location = new System.Drawing.Point(146, 177);
            this.textBoxAlarmHigh.MaxLength = 4;
            this.textBoxAlarmHigh.Name = "textBoxAlarmHigh";
            this.textBoxAlarmHigh.Size = new System.Drawing.Size(137, 20);
            this.textBoxAlarmHigh.TabIndex = 50;
            this.toolTip1.SetToolTip(this.textBoxAlarmHigh, "Enter highest alarm range.");
            this.textBoxAlarmHigh.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAlarmHigh_KeyPress);
            // 
            // textBoxURV
            // 
            this.textBoxURV.Location = new System.Drawing.Point(146, 111);
            this.textBoxURV.MaxLength = 7;
            this.textBoxURV.Name = "textBoxURV";
            this.textBoxURV.Size = new System.Drawing.Size(137, 20);
            this.textBoxURV.TabIndex = 30;
            this.toolTip1.SetToolTip(this.textBoxURV, "Enter a upper range value.");
            this.textBoxURV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxURV_KeyPress);
            // 
            // textBoxAlarmLow
            // 
            this.textBoxAlarmLow.Location = new System.Drawing.Point(146, 144);
            this.textBoxAlarmLow.MaxLength = 4;
            this.textBoxAlarmLow.Name = "textBoxAlarmLow";
            this.textBoxAlarmLow.Size = new System.Drawing.Size(137, 20);
            this.textBoxAlarmLow.TabIndex = 40;
            this.toolTip1.SetToolTip(this.textBoxAlarmLow, "Enter lowest alarm range.");
            this.textBoxAlarmLow.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAlarmLow_KeyPress);
            // 
            // labelURV
            // 
            this.labelURV.AutoSize = true;
            this.labelURV.Location = new System.Drawing.Point(36, 111);
            this.labelURV.Name = "labelURV";
            this.labelURV.Size = new System.Drawing.Size(101, 13);
            this.labelURV.TabIndex = 7;
            this.labelURV.Text = "Upper Range Value";
            // 
            // labelAL
            // 
            this.labelAL.AutoSize = true;
            this.labelAL.Location = new System.Drawing.Point(36, 144);
            this.labelAL.Name = "labelAL";
            this.labelAL.Size = new System.Drawing.Size(56, 13);
            this.labelAL.TabIndex = 8;
            this.labelAL.Text = "Alarm Low";
            // 
            // labelAH
            // 
            this.labelAH.AutoSize = true;
            this.labelAH.Location = new System.Drawing.Point(36, 177);
            this.labelAH.Name = "labelAH";
            this.labelAH.Size = new System.Drawing.Size(58, 13);
            this.labelAH.TabIndex = 9;
            this.labelAH.Text = "Alarm High";
            // 
            // labelLRV
            // 
            this.labelLRV.AutoSize = true;
            this.labelLRV.Location = new System.Drawing.Point(36, 78);
            this.labelLRV.Name = "labelLRV";
            this.labelLRV.Size = new System.Drawing.Size(101, 13);
            this.labelLRV.TabIndex = 6;
            this.labelLRV.Text = "Lower Range Value";
            // 
            // textBoxTagName
            // 
            this.textBoxTagName.Enabled = false;
            this.textBoxTagName.Location = new System.Drawing.Point(146, 45);
            this.textBoxTagName.MaxLength = 10;
            this.textBoxTagName.Name = "textBoxTagName";
            this.textBoxTagName.Size = new System.Drawing.Size(137, 20);
            this.textBoxTagName.TabIndex = 10;
            this.toolTip1.SetToolTip(this.textBoxTagName, "Enter Tag Name of device.");
            // 
            // textBoxLRV
            // 
            this.textBoxLRV.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBoxLRV.Location = new System.Drawing.Point(146, 78);
            this.textBoxLRV.MaxLength = 7;
            this.textBoxLRV.Name = "textBoxLRV";
            this.textBoxLRV.Size = new System.Drawing.Size(137, 20);
            this.textBoxLRV.TabIndex = 20;
            this.toolTip1.SetToolTip(this.textBoxLRV, "Enter a lower range value.");
            this.textBoxLRV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxLRV_KeyPress);
            // 
            // labelTagName
            // 
            this.labelTagName.AutoSize = true;
            this.labelTagName.Location = new System.Drawing.Point(36, 45);
            this.labelTagName.Name = "labelTagName";
            this.labelTagName.Size = new System.Drawing.Size(57, 13);
            this.labelTagName.TabIndex = 5;
            this.labelTagName.Text = "Tag Name";
            // 
            // buttonWrite
            // 
            this.buttonWrite.Location = new System.Drawing.Point(552, 366);
            this.buttonWrite.Name = "buttonWrite";
            this.buttonWrite.Size = new System.Drawing.Size(59, 48);
            this.buttonWrite.TabIndex = 70;
            this.buttonWrite.Text = "Write Data";
            this.toolTip1.SetToolTip(this.buttonWrite, "Write data to device.");
            this.buttonWrite.UseVisualStyleBackColor = true;
            this.buttonWrite.Visible = false;
            this.buttonWrite.Click += new System.EventHandler(this.buttonWrite_Click);
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(478, 366);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(59, 48);
            this.buttonLoad.TabIndex = 60;
            this.buttonLoad.Text = "Read Data";
            this.toolTip1.SetToolTip(this.buttonLoad, "Read data from device.");
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Visible = false;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // buttonTransferValuesInstrument
            // 
            this.buttonTransferValuesInstrument.Location = new System.Drawing.Point(313, 83);
            this.buttonTransferValuesInstrument.Name = "buttonTransferValuesInstrument";
            this.buttonTransferValuesInstrument.Size = new System.Drawing.Size(89, 80);
            this.buttonTransferValuesInstrument.TabIndex = 127;
            this.buttonTransferValuesInstrument.Text = "Transfer Values  To Edit ---->";
            this.buttonTransferValuesInstrument.UseVisualStyleBackColor = true;
            this.buttonTransferValuesInstrument.Click += new System.EventHandler(this.buttonTransferValuesInstrument_Click);
            // 
            // tabPageValues
            // 
            this.tabPageValues.Controls.Add(this.panel7);
            this.tabPageValues.Controls.Add(this.labelINSTRUMENT_INFO);
            this.tabPageValues.Controls.Add(this.labelVALUES);
            this.tabPageValues.Controls.Add(this.panel4);
            this.tabPageValues.Controls.Add(this.labelStatus);
            this.tabPageValues.Controls.Add(this.textBoxStatus);
            this.tabPageValues.Controls.Add(this.listBoxSensorData);
            this.tabPageValues.Controls.Add(this.comboBoxSensorSignal);
            this.tabPageValues.Controls.Add(this.chartValues);
            this.tabPageValues.Location = new System.Drawing.Point(4, 22);
            this.tabPageValues.Name = "tabPageValues";
            this.tabPageValues.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageValues.Size = new System.Drawing.Size(775, 432);
            this.tabPageValues.TabIndex = 2;
            this.tabPageValues.Text = "Values";
            this.tabPageValues.UseVisualStyleBackColor = true;
            this.tabPageValues.Enter += new System.EventHandler(this.tabPageValues_Enter);
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.buttonValueClear);
            this.panel7.Controls.Add(this.labelValueSimulation);
            this.panel7.Controls.Add(this.buttonStartAuto);
            this.panel7.Controls.Add(this.buttonStopAuto);
            this.panel7.Location = new System.Drawing.Point(19, 16);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(204, 70);
            this.panel7.TabIndex = 132;
            // 
            // labelValueSimulation
            // 
            this.labelValueSimulation.AutoSize = true;
            this.labelValueSimulation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.labelValueSimulation.Location = new System.Drawing.Point(3, 9);
            this.labelValueSimulation.Name = "labelValueSimulation";
            this.labelValueSimulation.Size = new System.Drawing.Size(95, 17);
            this.labelValueSimulation.TabIndex = 131;
            this.labelValueSimulation.Text = "SIMULATION:";
            // 
            // buttonStartAuto
            // 
            this.buttonStartAuto.Location = new System.Drawing.Point(2, 36);
            this.buttonStartAuto.Name = "buttonStartAuto";
            this.buttonStartAuto.Size = new System.Drawing.Size(96, 23);
            this.buttonStartAuto.TabIndex = 20;
            this.buttonStartAuto.Text = "Start";
            this.toolTip1.SetToolTip(this.buttonStartAuto, "Start reading from device.");
            this.buttonStartAuto.UseVisualStyleBackColor = true;
            this.buttonStartAuto.Click += new System.EventHandler(this.buttonStartAuto_Click);
            // 
            // buttonStopAuto
            // 
            this.buttonStopAuto.Location = new System.Drawing.Point(105, 36);
            this.buttonStopAuto.Name = "buttonStopAuto";
            this.buttonStopAuto.Size = new System.Drawing.Size(89, 23);
            this.buttonStopAuto.TabIndex = 30;
            this.buttonStopAuto.Text = "Stop";
            this.toolTip1.SetToolTip(this.buttonStopAuto, "Stop reading from device and save to file.");
            this.buttonStopAuto.UseVisualStyleBackColor = true;
            this.buttonStopAuto.Click += new System.EventHandler(this.buttonStopAuto_Click);
            // 
            // labelINSTRUMENT_INFO
            // 
            this.labelINSTRUMENT_INFO.AutoSize = true;
            this.labelINSTRUMENT_INFO.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.labelINSTRUMENT_INFO.Location = new System.Drawing.Point(16, 97);
            this.labelINSTRUMENT_INFO.Name = "labelINSTRUMENT_INFO";
            this.labelINSTRUMENT_INFO.Size = new System.Drawing.Size(138, 17);
            this.labelINSTRUMENT_INFO.TabIndex = 130;
            this.labelINSTRUMENT_INFO.Text = "INSTRUMENT INFO:";
            // 
            // labelVALUES
            // 
            this.labelVALUES.AutoSize = true;
            this.labelVALUES.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.labelVALUES.Location = new System.Drawing.Point(243, 16);
            this.labelVALUES.Name = "labelVALUES";
            this.labelVALUES.Size = new System.Drawing.Size(62, 17);
            this.labelVALUES.TabIndex = 129;
            this.labelVALUES.Text = "VALUES";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.textBoxValueLogInterval);
            this.panel4.Controls.Add(labelValueLogInterval);
            this.panel4.Controls.Add(labelValueAnalogDigital);
            this.panel4.Controls.Add(labelValueInputOutput);
            this.panel4.Controls.Add(this.labelValueType);
            this.panel4.Controls.Add(this.labelValueState);
            this.panel4.Controls.Add(this.textBoxValueAlarmHigh);
            this.panel4.Controls.Add(this.textBoxValueAlarmLow);
            this.panel4.Controls.Add(this.textBoxValueURV);
            this.panel4.Controls.Add(this.textBoxValueLRV);
            this.panel4.Controls.Add(labelValueLRV);
            this.panel4.Controls.Add(labelValueURV);
            this.panel4.Controls.Add(labelValueAlarmLow);
            this.panel4.Controls.Add(labelValueAlarmHigh);
            this.panel4.Controls.Add(labelValueTagName);
            this.panel4.Controls.Add(this.textBoxValueTagName);
            this.panel4.Controls.Add(this.radioButtonConnectedValues);
            this.panel4.Controls.Add(this.labelConnectValues);
            this.panel4.Location = new System.Drawing.Point(19, 117);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(204, 260);
            this.panel4.TabIndex = 44;
            // 
            // textBoxValueLogInterval
            // 
            this.textBoxValueLogInterval.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.config_InstrumentBindingSource, "Frequency", true));
            this.textBoxValueLogInterval.Enabled = false;
            this.textBoxValueLogInterval.Location = new System.Drawing.Point(85, 229);
            this.textBoxValueLogInterval.Name = "textBoxValueLogInterval";
            this.textBoxValueLogInterval.Size = new System.Drawing.Size(108, 20);
            this.textBoxValueLogInterval.TabIndex = 134;
            // 
            // labelValueType
            // 
            this.labelValueType.AutoSize = true;
            this.labelValueType.Location = new System.Drawing.Point(86, 176);
            this.labelValueType.Name = "labelValueType";
            this.labelValueType.Size = new System.Drawing.Size(31, 13);
            this.labelValueType.TabIndex = 130;
            this.labelValueType.Text = "Type";
            // 
            // labelValueState
            // 
            this.labelValueState.AutoSize = true;
            this.labelValueState.Location = new System.Drawing.Point(85, 204);
            this.labelValueState.Name = "labelValueState";
            this.labelValueState.Size = new System.Drawing.Size(32, 13);
            this.labelValueState.TabIndex = 129;
            this.labelValueState.Text = "State";
            // 
            // textBoxValueAlarmHigh
            // 
            this.textBoxValueAlarmHigh.Enabled = false;
            this.textBoxValueAlarmHigh.Location = new System.Drawing.Point(85, 144);
            this.textBoxValueAlarmHigh.Name = "textBoxValueAlarmHigh";
            this.textBoxValueAlarmHigh.Size = new System.Drawing.Size(108, 20);
            this.textBoxValueAlarmHigh.TabIndex = 108;
            // 
            // textBoxValueAlarmLow
            // 
            this.textBoxValueAlarmLow.Enabled = false;
            this.textBoxValueAlarmLow.Location = new System.Drawing.Point(86, 115);
            this.textBoxValueAlarmLow.Name = "textBoxValueAlarmLow";
            this.textBoxValueAlarmLow.Size = new System.Drawing.Size(108, 20);
            this.textBoxValueAlarmLow.TabIndex = 107;
            // 
            // textBoxValueURV
            // 
            this.textBoxValueURV.Enabled = false;
            this.textBoxValueURV.Location = new System.Drawing.Point(86, 86);
            this.textBoxValueURV.Name = "textBoxValueURV";
            this.textBoxValueURV.Size = new System.Drawing.Size(108, 20);
            this.textBoxValueURV.TabIndex = 106;
            // 
            // textBoxValueLRV
            // 
            this.textBoxValueLRV.Enabled = false;
            this.textBoxValueLRV.Location = new System.Drawing.Point(86, 57);
            this.textBoxValueLRV.Name = "textBoxValueLRV";
            this.textBoxValueLRV.Size = new System.Drawing.Size(108, 20);
            this.textBoxValueLRV.TabIndex = 105;
            // 
            // textBoxValueTagName
            // 
            this.textBoxValueTagName.Enabled = false;
            this.textBoxValueTagName.Location = new System.Drawing.Point(86, 26);
            this.textBoxValueTagName.Name = "textBoxValueTagName";
            this.textBoxValueTagName.Size = new System.Drawing.Size(108, 20);
            this.textBoxValueTagName.TabIndex = 44;
            // 
            // radioButtonConnectedValues
            // 
            this.radioButtonConnectedValues.AutoSize = true;
            this.radioButtonConnectedValues.Enabled = false;
            this.radioButtonConnectedValues.Location = new System.Drawing.Point(3, 3);
            this.radioButtonConnectedValues.Name = "radioButtonConnectedValues";
            this.radioButtonConnectedValues.Size = new System.Drawing.Size(14, 13);
            this.radioButtonConnectedValues.TabIndex = 42;
            this.radioButtonConnectedValues.TabStop = true;
            this.toolTip1.SetToolTip(this.radioButtonConnectedValues, "Fills if connected.");
            this.radioButtonConnectedValues.UseVisualStyleBackColor = true;
            // 
            // labelConnectValues
            // 
            this.labelConnectValues.AutoSize = true;
            this.labelConnectValues.Location = new System.Drawing.Point(24, 3);
            this.labelConnectValues.Name = "labelConnectValues";
            this.labelConnectValues.Size = new System.Drawing.Size(0, 13);
            this.labelConnectValues.TabIndex = 43;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(337, 360);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(40, 13);
            this.labelStatus.TabIndex = 8;
            this.labelStatus.Text = "Status:";
            // 
            // textBoxStatus
            // 
            this.textBoxStatus.Location = new System.Drawing.Point(378, 357);
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.ReadOnly = true;
            this.textBoxStatus.Size = new System.Drawing.Size(274, 20);
            this.textBoxStatus.TabIndex = 7;
            this.textBoxStatus.TabStop = false;
            this.toolTip1.SetToolTip(this.textBoxStatus, "Status from device.");
            this.textBoxStatus.TextChanged += new System.EventHandler(this.textBoxStatus_TextChanged);
            // 
            // listBoxSensorData
            // 
            this.listBoxSensorData.FormattingEnabled = true;
            this.listBoxSensorData.Location = new System.Drawing.Point(246, 38);
            this.listBoxSensorData.Name = "listBoxSensorData";
            this.listBoxSensorData.Size = new System.Drawing.Size(74, 381);
            this.listBoxSensorData.TabIndex = 6;
            this.listBoxSensorData.TabStop = false;
            this.toolTip1.SetToolTip(this.listBoxSensorData, "Data from device as text.");
            // 
            // comboBoxSensorSignal
            // 
            this.comboBoxSensorSignal.Enabled = false;
            this.comboBoxSensorSignal.FormattingEnabled = true;
            this.comboBoxSensorSignal.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBoxSensorSignal.Items.AddRange(new object[] {
            "Raw",
            "Scaled"});
            this.comboBoxSensorSignal.Location = new System.Drawing.Point(19, 398);
            this.comboBoxSensorSignal.Name = "comboBoxSensorSignal";
            this.comboBoxSensorSignal.Size = new System.Drawing.Size(204, 21);
            this.comboBoxSensorSignal.Sorted = true;
            this.comboBoxSensorSignal.TabIndex = 10;
            this.toolTip1.SetToolTip(this.comboBoxSensorSignal, "Choose a sensor signal from the dropdown menu.");
            this.comboBoxSensorSignal.Visible = false;
            // 
            // chartValues
            // 
            chartArea1.Name = "ChartArea1";
            this.chartValues.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartValues.Legends.Add(legend1);
            this.chartValues.Location = new System.Drawing.Point(317, 10);
            this.chartValues.Name = "chartValues";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Value";
            this.chartValues.Series.Add(series1);
            this.chartValues.Size = new System.Drawing.Size(441, 341);
            this.chartValues.TabIndex = 0;
            this.chartValues.TabStop = false;
            this.chartValues.Text = "Values";
            this.toolTip1.SetToolTip(this.chartValues, "Chart of data from device as chart.");
            // 
            // configInstrumentChooseBindingSource1
            // 
            this.configInstrumentChooseBindingSource1.DataMember = "Config-InstrumentChoose";
            this.configInstrumentChooseBindingSource1.DataSource = this._Assignment_2__InstrumentDataSet;
            // 
            // configInstrumentChooseBindingSource
            // 
            this.configInstrumentChooseBindingSource.DataMember = "Config-InstrumentChoose";
            this.configInstrumentChooseBindingSource.DataSource = this._Assignment_2__InstrumentDataSet2;
            // 
            // _Assignment_2__InstrumentDataSet2
            // 
            this._Assignment_2__InstrumentDataSet2.DataSetName = "_Assignment_2__InstrumentDataSet";
            this._Assignment_2__InstrumentDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // config_DAUTableAdapter
            // 
            this.config_DAUTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AreaForDAUTableAdapter = null;
            this.tableAdapterManager.AreaForInstrumentTableAdapter = null;
            this.tableAdapterManager.AreaTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Config_DAUComboBoxTableAdapter = null;
            this.tableAdapterManager.Config_DAUTableAdapter = this.config_DAUTableAdapter;
            this.tableAdapterManager.Config_InstrumentChooseTableAdapter = null;
            this.tableAdapterManager.Config_InstrumentTableAdapter = null;
            this.tableAdapterManager.Config_RCDComboBoxTableAdapter = null;
            this.tableAdapterManager.Config_RCDTableAdapter = this.config_RCDTableAdapter;
            this.tableAdapterManager.Log_AITableAdapter = null;
            this.tableAdapterManager.Log_AOTableAdapter = null;
            this.tableAdapterManager.Log_DITableAdapter = null;
            this.tableAdapterManager.Log_DOTableAdapter = null;
            this.tableAdapterManager.MakerTableAdapter = null;
            this.tableAdapterManager.Model_TableTableAdapter = null;
            this.tableAdapterManager.TypeTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SoftSensConf._Assignment_2__InstrumentDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // config_RCDTableAdapter
            // 
            this.config_RCDTableAdapter.ClearBeforeFill = true;
            // 
            // config_RCDComboBoxTableAdapter
            // 
            this.config_RCDComboBoxTableAdapter.ClearBeforeFill = true;
            // 
            // config_DAUComboBoxTableAdapter
            // 
            this.config_DAUComboBoxTableAdapter.ClearBeforeFill = true;
            // 
            // areaTableAdapter
            // 
            this.areaTableAdapter.ClearBeforeFill = true;
            // 
            // configDAUBindingSource
            // 
            this.configDAUBindingSource.DataMember = "Config-DAU";
            this.configDAUBindingSource.DataSource = this._Assignment_2__InstrumentDataSet;
            // 
            // areaForDAUTableAdapter
            // 
            this.areaForDAUTableAdapter.ClearBeforeFill = true;
            // 
            // config_InstrumentTableAdapter
            // 
            this.config_InstrumentTableAdapter.ClearBeforeFill = true;
            // 
            // _Assignment_2__InstrumentDataSet1
            // 
            this._Assignment_2__InstrumentDataSet1.DataSetName = "_Assignment_2__InstrumentDataSet";
            this._Assignment_2__InstrumentDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // configInstrument1BindingSource
            // 
            this.configInstrument1BindingSource.DataMember = "Config-Instrument1";
            this.configInstrument1BindingSource.DataSource = this._Assignment_2__InstrumentDataSet1;
            // 
            // config_InstrumentChooseTableAdapter
            // 
            this.config_InstrumentChooseTableAdapter.ClearBeforeFill = true;
            // 
            // areaForInstrumentTableAdapter
            // 
            this.areaForInstrumentTableAdapter.ClearBeforeFill = true;
            // 
            // typeTableAdapter
            // 
            this.typeTableAdapter.ClearBeforeFill = true;
            // 
            // makerTableAdapter
            // 
            this.makerTableAdapter.ClearBeforeFill = true;
            // 
            // model_TableTableAdapter
            // 
            this.model_TableTableAdapter.ClearBeforeFill = true;
            // 
            // timerStartRandom
            // 
            this.timerStartRandom.Tick += new System.EventHandler(this.timerStartRandom_Tick);
            // 
            // buttonValueClear
            // 
            this.buttonValueClear.Location = new System.Drawing.Point(105, 5);
            this.buttonValueClear.Name = "buttonValueClear";
            this.buttonValueClear.Size = new System.Drawing.Size(88, 23);
            this.buttonValueClear.TabIndex = 132;
            this.buttonValueClear.Text = "Clear";
            this.buttonValueClear.UseVisualStyleBackColor = true;
            this.buttonValueClear.Click += new System.EventHandler(this.buttonValueClear_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 458);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormMain";
            this.Text = "SoftSensConf";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageSerialPortConfig.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.config_DAUBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._Assignment_2__InstrumentDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.areaForDAUBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.configDAUComboBoxBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.config_RCDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.areaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.configRCDComboBoxBindingSource)).EndInit();
            this.tabPageInstrumentConfig.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.config_InstrumentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceSQL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.makerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.areaForInstrumentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._Assignment_2__InstrumentDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.configInstrumentChooseBindingSource2)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.tabPageValues.ResumeLayout(false);
            this.tabPageValues.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartValues)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.configInstrumentChooseBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.configInstrumentChooseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._Assignment_2__InstrumentDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.configDAUBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._Assignment_2__InstrumentDataSet1)).EndInit();
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
        private System.Windows.Forms.BindingSource bindingSourceSQL;
        private _Assignment_2__InstrumentDataSet _Assignment_2__InstrumentDataSet;
        private System.Windows.Forms.BindingSource config_DAUBindingSource;
        private _Assignment_2__InstrumentDataSetTableAdapters.Config_DAUTableAdapter config_DAUTableAdapter;
        private _Assignment_2__InstrumentDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox cOM_TypeTextBox;
        private System.Windows.Forms.TextBox baud_RateTextBox;
        private System.Windows.Forms.TextBox cOM_PortTextBox;
        private _Assignment_2__InstrumentDataSetTableAdapters.Config_RCDTableAdapter config_RCDTableAdapter;
        private System.Windows.Forms.BindingSource config_RCDBindingSource;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox rCD_IDTextBox1;
        private System.Windows.Forms.ComboBox comboBoxFindDAU;
        private System.Windows.Forms.ComboBox comboBoxFindRDC;
        private System.Windows.Forms.Label labelFindRDC;
        private System.Windows.Forms.BindingSource configRCDComboBoxBindingSource;
        private _Assignment_2__InstrumentDataSetTableAdapters.Config_RCDComboBoxTableAdapter config_RCDComboBoxTableAdapter;
        private System.Windows.Forms.BindingSource configDAUComboBoxBindingSource;
        private _Assignment_2__InstrumentDataSetTableAdapters.Config_DAUComboBoxTableAdapter config_DAUComboBoxTableAdapter;
        private System.Windows.Forms.BindingSource areaBindingSource;
        private _Assignment_2__InstrumentDataSetTableAdapters.AreaTableAdapter areaTableAdapter;
        private System.Windows.Forms.ComboBox comboBoxAreaID;
        private System.Windows.Forms.ComboBox comboBoxAreaDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelFindDAU;
        private System.Windows.Forms.ComboBox comboBoxDAUAreaDescription;
        private System.Windows.Forms.BindingSource configDAUBindingSource;
        private System.Windows.Forms.BindingSource areaForDAUBindingSource;
        private _Assignment_2__InstrumentDataSetTableAdapters.AreaForDAUTableAdapter areaForDAUTableAdapter;
        private System.Windows.Forms.Label labelDAU;
        private System.Windows.Forms.Label labelRDC;
        private System.Windows.Forms.BindingSource config_InstrumentBindingSource;
        private _Assignment_2__InstrumentDataSetTableAdapters.Config_InstrumentTableAdapter config_InstrumentTableAdapter;
        private System.Windows.Forms.TextBox lRVTextBox;
        private System.Windows.Forms.TextBox uRVTextBox;
        private System.Windows.Forms.TextBox alarmLowTextBox;
        private System.Windows.Forms.TextBox alarmHighTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox unitTextBox;
        private System.Windows.Forms.TextBox frequencyTextBox1;
        private System.Windows.Forms.CheckBox input_OutputCheckBox;
        private System.Windows.Forms.CheckBox analog_DigitalCheckBox;
        private _Assignment_2__InstrumentDataSet _Assignment_2__InstrumentDataSet1;
        private System.Windows.Forms.BindingSource configInstrument1BindingSource;
        private _Assignment_2__InstrumentDataSet _Assignment_2__InstrumentDataSet2;
        private System.Windows.Forms.BindingSource configInstrumentChooseBindingSource;
        private System.Windows.Forms.ComboBox comboBoxTagName;
        private System.Windows.Forms.BindingSource configInstrumentChooseBindingSource1;
        private _Assignment_2__InstrumentDataSetTableAdapters.Config_InstrumentChooseTableAdapter config_InstrumentChooseTableAdapter;
        private System.Windows.Forms.BindingSource configInstrumentChooseBindingSource2;
        private _Assignment_2__InstrumentDataSet _Assignment_2__InstrumentDataSet3;
        private System.Windows.Forms.BindingSource areaForInstrumentBindingSource;
        private _Assignment_2__InstrumentDataSetTableAdapters.AreaForInstrumentTableAdapter areaForInstrumentTableAdapter;
        private System.Windows.Forms.ComboBox comboBoxAreaIDInstrument;
        private System.Windows.Forms.ComboBox comboBoxTypeIDInstrument;
        private System.Windows.Forms.BindingSource typeBindingSource;
        private _Assignment_2__InstrumentDataSetTableAdapters.TypeTableAdapter typeTableAdapter;
        private System.Windows.Forms.ComboBox comboBoxModelIDInstrument;
        private System.Windows.Forms.ComboBox comboBoxMakerIDInstrument;
        private System.Windows.Forms.BindingSource makerBindingSource;
        private _Assignment_2__InstrumentDataSetTableAdapters.MakerTableAdapter makerTableAdapter;
        private System.Windows.Forms.BindingSource modelTableBindingSource;
        private _Assignment_2__InstrumentDataSetTableAdapters.Model_TableTableAdapter model_TableTableAdapter;
        private System.Windows.Forms.Button buttonTransferValuesInstrument;
        private System.Windows.Forms.Button buttonTransferConnect;
        private System.Windows.Forms.Timer timerStartRandom;
        private System.Windows.Forms.Label labelConnect;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelTypeSignal;
        private System.Windows.Forms.Label labelInputOutput;
        private System.Windows.Forms.Label labelINSTRUMENT_INFO;
        private System.Windows.Forms.Label labelVALUES;
        private System.Windows.Forms.TextBox textBoxValueTagName;
        private System.Windows.Forms.Label labelValueType;
        private System.Windows.Forms.Label labelValueState;
        private System.Windows.Forms.TextBox textBoxValueAlarmHigh;
        private System.Windows.Forms.TextBox textBoxValueAlarmLow;
        private System.Windows.Forms.TextBox textBoxValueURV;
        private System.Windows.Forms.TextBox textBoxValueLRV;
        private System.Windows.Forms.Label labelValueSimulation;
        private System.Windows.Forms.TextBox textBoxValueLogInterval;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button buttonTranferEditToInstrument;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelSerialPortLogINterval;
        private System.Windows.Forms.Button buttonValueClear;
    }
}

