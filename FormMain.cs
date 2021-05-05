using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;
using System.Threading;

namespace SoftSensConf
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }


        string defaultConfiguration = "C385IT001;0.0;500.0;40;440";
        string[] instrumentConfiguration;
        List<MeasurementPoint> allMeasuredPoints = new List<MeasurementPoint>();





        private void comboBoxCOMPort_Enter(object sender, EventArgs e)
        {
            comboBoxCOMPort.Items.Clear();
            string[] comPort = SerialPort.GetPortNames();
            foreach (string ports in comPort)
            {
                comboBoxCOMPort.Items.Add(ports);
            }
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            if ((comboBoxCOMPort.Text != "") & (comboBoxBaudRate.Text != ""))
            {
                radioButtonConnectedSerial.Checked = true;
                radioButtonConnectedInstrument.Checked = true;
                radioButtonConnectedValues.Checked = true;
                labelConnectSerial.Text = "Connected";
                labelConnectSerial.BackColor = System.Drawing.Color.Green;
                labelConnectInstrument.Text = "Connected";
                labelConnectInstrument.BackColor = System.Drawing.Color.Green;
                labelConnectValues.Text = "Connected";
                labelConnectValues.BackColor = System.Drawing.Color.Green;
                comboBoxFindRDC.Enabled = false;
                comboBoxFindDAU.Enabled = false;
            }
            else
            {
                MessageBox.Show("Please fill both Com-Port and Baud Rate correctly.");
            }
            /*if (SerialPort.IsOpen == true)
            {
                SerialPort.Close();
                radioButtonConnectedSerial.Checked = false;
            }
            else if (comboBoxCOMPort.SelectedIndex > -1)
            {
                SerialPort.PortName = comboBoxCOMPort.Items[comboBoxCOMPort.SelectedIndex].ToString();
                if (comboBoxBaudRate.SelectedIndex > -1)
                {
                    SerialPort.BaudRate = Convert.ToInt32(comboBoxBaudRate.Items[comboBoxBaudRate.SelectedIndex]);
                    try
                    {
                        SerialPort.Open();
                        timerSerialPortCheck.Enabled = true;
                        radioButtonConnectedSerial.Checked = true;
                        radioButtonConnectedInstrument.Checked = true;
                        radioButtonConnectedValues.Checked = true;
                        labelConnectSerial.Text = "Connected";
                        labelConnectInstrument.Text = "Connected";
                        labelConnectValues.Text = "Connected";
                    }
                    catch
                    {
                        radioButtonConnectedSerial.Checked = false;
                        labelConnectSerial.Text = "Disconnected";
                        labelConnectInstrument.Text = "Disconnected";
                        labelConnectValues.Text = "Disconnected";
                        MessageBox.Show("Unable to connect to port");
                    }
                }
            }*/
        }

        private void buttonDisconnect_Click(object sender, EventArgs e)
        {
            radioButtonConnectedSerial.Checked = false;
            radioButtonConnectedInstrument.Checked = false;
            radioButtonConnectedValues.Checked = false;
            labelConnectSerial.Text = "Disconnected";
            labelConnectSerial.BackColor = System.Drawing.Color.Red;
            labelConnectInstrument.Text = "Disconnected";
            labelConnectInstrument.BackColor = System.Drawing.Color.Red;
            labelConnectValues.Text = "Disconnected";
            labelConnectValues.BackColor = System.Drawing.Color.Red;
            comboBoxFindRDC.Enabled = true;
            comboBoxFindDAU.Enabled = true;

            /*timerSerialPortCheck.Enabled = false;
            SerialPort.Close();
            radioButtonConnectedSerial.Checked = false;
            radioButtonConnectedInstrument.Checked = false;
            radioButtonConnectedValues.Checked = false;
            labelConnectSerial.Text = "Disconnected";
            labelConnectInstrument.Text = "Disconnected";
            labelConnectValues.Text = "Disconnected";*/
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            /*if (SerialPort.IsOpen)
            {
                SerialPort.WriteLine("readconf");
                string readData = "";

                textBoxTagName.Clear();     textBoxTagName.AppendText(" ");
                textBoxLRV.Clear();         textBoxLRV.AppendText(" ");
                textBoxURV.Clear();         textBoxURV.AppendText("Waiting for configuration data.");
                textBoxAlarmLow.Clear();    textBoxAlarmLow.AppendText(" ");
                textBoxAlarmHigh.Clear();   textBoxAlarmHigh.AppendText(" ");

                Thread.Sleep(1500);    //Delay for getting correct data from instrument. If not delayed, no data is recieved.
                readData += SerialPort.ReadExisting().ToString();
                string[] readings = readData.Split(';');

                instrumentConfiguration = defaultConfiguration.Split(';');

                if (readings.Length == 5)
                {
                    textBoxTagName.Text = readings[0];
                    textBoxLRV.Text = readings[1];
                    textBoxURV.Text = readings[2];
                    textBoxAlarmLow.Text = readings[3];
                    textBoxAlarmHigh.Text = readings[4];
                }
                else
                {
                    MessageBox.Show("Failed to read configuration from instrument. Check the length and setup of your string.");
                    textBoxTagName.Text = instrumentConfiguration[0];
                    textBoxLRV.Text = instrumentConfiguration[1];
                    textBoxURV.Text = instrumentConfiguration[2];
                    textBoxAlarmLow.Text = instrumentConfiguration[3];
                    textBoxAlarmHigh.Text = instrumentConfiguration[4];
                }
            }
            else
            {
                MessageBox.Show("Serial port is not open");
                radioButtonConnectedSerial.Checked = false;
                radioButtonConnectedInstrument.Checked = false;
                radioButtonConnectedValues.Checked = false;
                labelConnectSerial.Text = "Disconnected";
                labelConnectSerial.BackColor = System.Drawing.Color.Red;
                labelConnectInstrument.Text = "Disconnected";
                labelConnectInstrument.BackColor = System.Drawing.Color.Red;
                labelConnectValues.Text = "Disconnected";
                labelConnectValues.BackColor = System.Drawing.Color.Red;
            }*/
        }  

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string filename = "";
            if (saveFileDialogInstrument.ShowDialog() == DialogResult.OK)
            {
                if ((textBoxTagName.Text=="") || (textBoxLRV.Text=="") || (textBoxURV.Text=="") || (textBoxAlarmLow.Text=="") || (textBoxAlarmHigh.Text==""))
                {
                    MessageBox.Show("Do not leave any spaces open.");
                }
                else
                {
                    string[] textBoxes = {  textBoxTagName.Text,
                                        textBoxLRV.Text,
                                        textBoxURV.Text,
                                        textBoxAlarmLow.Text,
                                        textBoxAlarmHigh.Text };
                    filename = saveFileDialogInstrument.FileName;
                    File.WriteAllText(saveFileDialogInstrument.FileName, string.Join(";", textBoxes));
                }
            }
        }

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            string filename;
            string fileContent;
            openFileDialogInstrument.InitialDirectory = "c:\\";
            openFileDialogInstrument.FileName = "";
            if (openFileDialogInstrument.ShowDialog()==DialogResult.OK)
            {
                filename = openFileDialogInstrument.FileName;
                fileContent = File.ReadAllText(filename);
                string[] fileContentArray;
                fileContentArray = fileContent.Split(';');
                if (fileContentArray.Length == 5)
                {
                    textBoxTagName.Text = fileContentArray[0];
                    textBoxLRV.Text = fileContentArray[1];
                    textBoxURV.Text = fileContentArray[2];
                    textBoxAlarmLow.Text = fileContentArray[3];
                    textBoxAlarmHigh.Text = fileContentArray[4];
                }
                else
                {
                    MessageBox.Show("Failed to open configuration from file. Check the length and setup of your string in file.");
                }
            }
        }

        private void buttonWrite_Click(object sender, EventArgs e)
        {
            /*if (SerialPort.IsOpen)
            {
                string writingString;
                string passwordString = "";
                FormPassword passord = new FormPassword();
                if (passord.ShowDialog() == DialogResult.OK)
                {
                    if ((textBoxTagName.Text == "") || (textBoxLRV.Text == "") || (textBoxURV.Text == "") || (textBoxAlarmLow.Text == "") || (textBoxAlarmHigh.Text == ""))
                    {
                        MessageBox.Show("Do not leave any spaces open.");
                    }
                    else
                    {
                        passwordString = FormPassword.password;
                        string[] textBoxes = {  textBoxTagName.Text,
                                    textBoxLRV.Text,
                                    textBoxURV.Text,
                                    textBoxAlarmLow.Text,
                                    textBoxAlarmHigh.Text };
                        writingString = "writeconf>" + passwordString + ">" + string.Join(";", textBoxes);
                        SerialPort.WriteLine(writingString);
                        string passwordRead;
                        Thread.Sleep(1500);    //Delay for getting correct data from instrument. If not delayed, no data is recieved.
                        passwordRead = SerialPort.ReadExisting().ToString();
                        if (passwordRead == "1")
                        {
                            MessageBox.Show("Configuration completed.");
                        }
                        else
                        {
                            MessageBox.Show("Password is wrong.");
                        }
                    }
                }
                
            }
            else
            {
                MessageBox.Show("Serial port is not open");
                radioButtonConnectedSerial.Checked = false;
                radioButtonConnectedInstrument.Checked = false;
                radioButtonConnectedValues.Checked = false;
                labelConnectSerial.Text = "Disconnected";
                labelConnectSerial.BackColor = System.Drawing.Color.Red;
                labelConnectInstrument.Text = "Disconnected";
                labelConnectInstrument.BackColor = System.Drawing.Color.Red;
                labelConnectValues.Text = "Disconnected";
                labelConnectValues.BackColor = System.Drawing.Color.Red;
            }*/
        }

        private void textBoxLRV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxURV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxAlarmLow_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxAlarmHigh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void timerChartAdd_Tick(object sender, EventArgs e)
        {
            /*if (SerialPort.IsOpen)
            {
                if (comboBoxSensorSignal.Text == "Raw")
                {
                    SerialPort.DiscardInBuffer();
                    SerialPort.DiscardOutBuffer();
                    SerialPort.WriteLine("readraw");
                    timerSerialRecieve.Enabled = true;
                    timerChartAdd.Enabled = false;
                    comboBoxSensorSignal.Enabled = false;

                }
                else if (comboBoxSensorSignal.Text == "Scaled")
                {
                    SerialPort.DiscardInBuffer();
                    SerialPort.DiscardOutBuffer();
                    SerialPort.WriteLine("readscaled");
                    timerSerialRecieve.Enabled = true;
                    timerChartAdd.Enabled = false;
                    comboBoxSensorSignal.Enabled = false;
                }
                else
                {
                    comboBoxSensorSignal.Enabled = true;
                    timerChartAdd.Enabled = false;
                    MessageBox.Show("Please choose a signal type to view.");
                }
            }
            else
            {
                timerChartAdd.Enabled = false;
                MessageBox.Show("Serial port is not open");
                radioButtonConnectedSerial.Checked = false;
                radioButtonConnectedInstrument.Checked = false;
                radioButtonConnectedValues.Checked = false;
                labelConnectSerial.Text = "Disconnected";
                labelConnectSerial.BackColor = System.Drawing.Color.Red;
                labelConnectInstrument.Text = "Disconnected";
                labelConnectInstrument.BackColor = System.Drawing.Color.Red;
                labelConnectValues.Text = "Disconnected";
                labelConnectValues.BackColor = System.Drawing.Color.Red;
            }*/
        }

        private void timerSerialRecieve_Tick(object sender, EventArgs e)
        {
            /*if (SerialPort.BytesToRead > 0)
            {
                string dataAvailable = "";
                MeasurementPoint measuredPoint;
                dataAvailable = SerialPort.ReadExisting().ToString();
                SerialPort.DiscardInBuffer();
                SerialPort.DiscardOutBuffer();
                listBoxSensorData.Items.Add(dataAvailable);
                SerialPort.WriteLine("readstatus"); //Sending new command to device, wich will be read in next timer.
                if (comboBoxSensorSignal.Text=="Raw")
                {
                    measuredPoint = new MeasurementPoint(DateTime.Now.ToLongTimeString(), dataAvailable);
                    chartValues.Series[0].Points.AddXY(measuredPoint.time, measuredPoint.vab);
                    allMeasuredPoints.Add(measuredPoint);
                }
                else if (comboBoxSensorSignal.Text == "Scaled")
                {
                    measuredPoint = new MeasurementPoint(DateTime.Now.ToLongTimeString(),dataAvailable);
                    chartValues.Series[1].Points.AddXY(measuredPoint.time, measuredPoint.vab);
                    allMeasuredPoints.Add(measuredPoint);
                }
                timerStatus.Enabled = true;
                timerSerialRecieve.Enabled = false;
            }*/
        }
        private void timerStatus_Tick(object sender, EventArgs e)
        {
            /*if (SerialPort.BytesToRead > 0)
            {
                string status = "";
                status = SerialPort.ReadExisting().ToString();
                int statusInt = Convert.ToInt32(status);
                if (statusInt == 0)
                {
                    textBoxStatus.Text = "OK";
                }
                else if (statusInt == 1)
                {
                    textBoxStatus.Text = "FAIL";
                }
                else if (statusInt == 2)
                {
                    textBoxStatus.Text = "Alarm Low";
                }
                else if (statusInt == 3)
                {
                    textBoxStatus.Text = "Alarm High";
                }
                else
                {
                    MessageBox.Show("Read value from device is not correct length, or wrong numbers.");
                }
                timerChartAdd.Enabled = true;
                timerStatus.Enabled = false;
            }*/
        }

        private void buttonStartAuto_Click(object sender, EventArgs e)
        {
            //timerChartAdd.Enabled = true;
            if (radioButtonConnectedSerial.Checked==true)
            {
                timerStartRandom.Interval = Convert.ToInt32(frequencyTextBox1.Text);
                timerStartRandom.Enabled = true;
            }
            else
            {
                MessageBox.Show("Please connect first.");
            }
        }

        private void buttonStopAuto_Click(object sender, EventArgs e)
        {
            timerStartRandom.Enabled = false;
           /* if (SerialPort.IsOpen)
            {
                timerChartAdd.Enabled = false;
                timerSerialRecieve.Enabled = false;
                timerStatus.Enabled = false;
                comboBoxSensorSignal.Enabled = true;
                if (MessageBox.Show("Want to save the data?", "Saving Data", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (saveFileDialogValues.ShowDialog() == DialogResult.OK)
                    {
                        using (StreamWriter streamWritePoints = new StreamWriter(saveFileDialogValues.FileName))

                            foreach (MeasurementPoint point in allMeasuredPoints)
                            {
                                streamWritePoints.WriteLine(point.ToString());
                            }

                    }
                }
            }
            else
            {
                MessageBox.Show("Serial port is not open");
                radioButtonConnectedSerial.Checked = false;
                radioButtonConnectedInstrument.Checked = false;
                radioButtonConnectedValues.Checked = false;
                labelConnectSerial.Text = "Disconnected";
                labelConnectInstrument.Text = "Disconnected";
                labelConnectValues.Text = "Disconnected";
            }*/
        }

        private void timerSerialPortCheck_Tick(object sender, EventArgs e)
        {
            /*if (!SerialPort.IsOpen)
            {
                timerSerialPortCheck.Enabled = false;
                MessageBox.Show("Serial Port disconnected");
                radioButtonConnectedSerial.Checked = false;
                radioButtonConnectedInstrument.Checked = false;
                radioButtonConnectedValues.Checked = false;
                labelConnectSerial.Text = "Disconnected";
                labelConnectSerial.BackColor = System.Drawing.Color.Red;
                labelConnectInstrument.Text = "Disconnected";
                labelConnectInstrument.BackColor = System.Drawing.Color.Red;
                labelConnectValues.Text = "Disconnected";
                labelConnectValues.BackColor = System.Drawing.Color.Red;
            }*/
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_Assignment_2__InstrumentDataSet.Model_Table' table. You can move, or remove it, as needed.
            this.model_TableTableAdapter.Fill(this._Assignment_2__InstrumentDataSet.Model_Table);
            // TODO: This line of code loads data into the '_Assignment_2__InstrumentDataSet.Maker' table. You can move, or remove it, as needed.
            this.makerTableAdapter.Fill(this._Assignment_2__InstrumentDataSet.Maker);
            // TODO: This line of code loads data into the '_Assignment_2__InstrumentDataSet.Type' table. You can move, or remove it, as needed.
            this.typeTableAdapter.Fill(this._Assignment_2__InstrumentDataSet.Type);
            // TODO: This line of code loads data into the '_Assignment_2__InstrumentDataSet3.AreaForInstrument' table. You can move, or remove it, as needed.
            this.areaForInstrumentTableAdapter.FillAreaInstrument(this._Assignment_2__InstrumentDataSet3.AreaForInstrument);
            // TODO: This line of code loads data into the '_Assignment_2__InstrumentDataSet._Config_InstrumentChoose' table. You can move, or remove it, as needed.
            this.config_InstrumentChooseTableAdapter.Fill(this._Assignment_2__InstrumentDataSet._Config_InstrumentChoose);
            // TODO: This line of code loads data into the '_Assignment_2__InstrumentDataSet._Config_Instrument' table. You can move, or remove it, as needed.
            this.config_InstrumentTableAdapter.Fill(this._Assignment_2__InstrumentDataSet._Config_Instrument);
            // TODO: This line of code loads data into the '_Assignment_2__InstrumentDataSet.AreaForDAU' table. You can move, or remove it, as needed.
            this.areaForDAUTableAdapter.Fill(this._Assignment_2__InstrumentDataSet.AreaForDAU);
            // TODO: This line of code loads data into the '_Assignment_2__InstrumentDataSet.Area' table. You can move, or remove it, as needed.
            this.areaTableAdapter.Fill(this._Assignment_2__InstrumentDataSet.Area);
            // TODO: This line of code loads data into the '_Assignment_2__InstrumentDataSet._Config_DAUComboBox' table. You can move, or remove it, as needed.
            this.config_DAUComboBoxTableAdapter.Fill(this._Assignment_2__InstrumentDataSet._Config_DAUComboBox);
            // TODO: This line of code loads data into the '_Assignment_2__InstrumentDataSet._Config_RCDComboBox' table. You can move, or remove it, as needed.
            this.config_RCDComboBoxTableAdapter.Fill(this._Assignment_2__InstrumentDataSet._Config_RCDComboBox);
            // TODO: This line of code loads data into the '_Assignment_2__InstrumentDataSet._Config_RCD' table. You can move, or remove it, as needed.
            this.config_RCDTableAdapter.Fill(this._Assignment_2__InstrumentDataSet._Config_RCD);
            // TODO: This line of code loads data into the '_Assignment_2__InstrumentDataSet._Config_DAU' table. You can move, or remove it, as needed.
            this.config_DAUTableAdapter.Fill(this._Assignment_2__InstrumentDataSet._Config_DAU);
            int filterRDCID = Convert.ToInt32(comboBoxFindRDC.SelectedValue.ToString());
            this.config_RCDTableAdapter.FillByRCDID(this._Assignment_2__InstrumentDataSet._Config_RCD, filterRDCID);
            config_DAUComboBoxTableAdapter.FillByDAUComboBox(_Assignment_2__InstrumentDataSet._Config_DAUComboBox, filterRDCID);
            int filterDAUID = Convert.ToInt32(comboBoxFindDAU.SelectedValue.ToString());
            this.config_DAUTableAdapter.FillByDAUID(this._Assignment_2__InstrumentDataSet._Config_DAU, filterDAUID);
            config_InstrumentChooseTableAdapter.FillByFilterDAUTagName(_Assignment_2__InstrumentDataSet._Config_InstrumentChoose, filterDAUID);
            string filterTagName = comboBoxTagName.SelectedValue.ToString();
            this.config_InstrumentTableAdapter.FillByInstrumentDAU(this._Assignment_2__InstrumentDataSet._Config_Instrument, filterTagName);
            if (input_OutputCheckBox.Checked == true)
            {
                labelInputOutput.Text = "Input";
            }
            else
            {
                labelInputOutput.Text = "Output";
            }
            if (analog_DigitalCheckBox.Checked == true)
            {
                labelTypeSignal.Text = "Analog";
            }
            else
            {
                labelTypeSignal.Text = "Digital";
            }
            radioButtonConnectedSerial.Checked = false;
            radioButtonConnectedInstrument.Checked = false;
            radioButtonConnectedValues.Checked = false;
            labelConnectSerial.Text = "Disconnected";
            labelConnectSerial.BackColor = System.Drawing.Color.Red;
            labelConnectInstrument.Text = "Disconnected";
            labelConnectInstrument.BackColor = System.Drawing.Color.Red;
            labelConnectValues.Text = "Disconnected";
            labelConnectValues.BackColor = System.Drawing.Color.Red;
        }

        private void comboBoxFindRDC_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxFindRDC.SelectedIndex >-1)
            {
                int filterRDCID = Convert.ToInt32(comboBoxFindRDC.SelectedValue.ToString());
                this.config_RCDTableAdapter.FillByRCDID(this._Assignment_2__InstrumentDataSet._Config_RCD, filterRDCID);
                config_DAUComboBoxTableAdapter.FillByDAUComboBox(_Assignment_2__InstrumentDataSet._Config_DAUComboBox, filterRDCID);
                int filterDAUID = Convert.ToInt32(comboBoxFindDAU.SelectedValue.ToString());
                this.config_DAUTableAdapter.FillByDAUID(this._Assignment_2__InstrumentDataSet._Config_DAU, filterDAUID);
                config_InstrumentChooseTableAdapter.FillByFilterDAUTagName(_Assignment_2__InstrumentDataSet._Config_InstrumentChoose, filterDAUID);
                string filterTagName = comboBoxTagName.SelectedValue.ToString();
                this.config_InstrumentTableAdapter.FillByInstrumentDAU(this._Assignment_2__InstrumentDataSet._Config_Instrument, filterTagName);
                if (input_OutputCheckBox.Checked == true)
                {
                    labelInputOutput.Text = "Input";
                }
                else
                {
                    labelInputOutput.Text = "Output";
                }
                if (analog_DigitalCheckBox.Checked == true)
                {
                    labelTypeSignal.Text = "Analog";
                }
                else
                {
                    labelTypeSignal.Text = "Digital";
                }
            }
        }

        private void comboBoxFindDAU_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxFindDAU.SelectedIndex > -1)
            {
                int filterDAUID = Convert.ToInt32(comboBoxFindDAU.SelectedValue.ToString());
                this.config_DAUTableAdapter.FillByDAUID(this._Assignment_2__InstrumentDataSet._Config_DAU, filterDAUID);
                config_InstrumentChooseTableAdapter.FillByFilterDAUTagName(_Assignment_2__InstrumentDataSet._Config_InstrumentChoose, filterDAUID);
                string filterTagName = comboBoxTagName.SelectedValue.ToString();
                this.config_InstrumentTableAdapter.FillByInstrumentDAU(this._Assignment_2__InstrumentDataSet._Config_Instrument, filterTagName);
                if (input_OutputCheckBox.Checked == true)
                {
                    labelInputOutput.Text = "Input";
                }
                else
                {
                    labelInputOutput.Text = "Output";
                }
                if (analog_DigitalCheckBox.Checked == true)
                {
                    labelTypeSignal.Text = "Analog";
                }
                else
                {
                    labelTypeSignal.Text = "Digital";
                }
            }
        }

        private void comboBoxTagName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxTagName.SelectedIndex > -1)
            {
                string filterTagName = comboBoxTagName.SelectedValue.ToString();
                this.config_InstrumentTableAdapter.FillByInstrumentDAU(this._Assignment_2__InstrumentDataSet._Config_Instrument,filterTagName);
                if (input_OutputCheckBox.Checked == true)
                {
                    labelInputOutput.Text = "Input";
                }
                else
                {
                    labelInputOutput.Text = "Output";
                }
                if (analog_DigitalCheckBox.Checked==true)
                {
                    labelTypeSignal.Text = "Analog";
                }
                else
                {
                    labelTypeSignal.Text = "Digital";
                }
            }
        }

        private void buttonTransferValuesInstrument_Click(object sender, EventArgs e)
        {
            textBoxTagName.Text = comboBoxTagName.Text;
            textBoxLRV.Text = lRVTextBox.Text;
            textBoxURV.Text = uRVTextBox.Text;
            textBoxAlarmLow.Text = alarmLowTextBox.Text;
            textBoxAlarmHigh.Text = alarmHighTextBox.Text;
        }

        private void buttonTransferConnect_Click(object sender, EventArgs e)
        {
            comboBoxCOMPort.Text = cOM_PortTextBox.Text;
            comboBoxBaudRate.Text = baud_RateTextBox.Text;
        }

        private void tabPageInstrumentConfig_Enter(object sender, EventArgs e)
        {

        }

        private void timerStartRandom_Tick(object sender, EventArgs e)
        {
            string time = DateTime.Now.ToString("HH:MM:ss");
            Random randomvalues = new Random();
            int randomPoints = randomvalues.Next(Convert.ToInt32(lRVTextBox.Text), Convert.ToInt32(uRVTextBox.Text));
            chartValues.Series[0].Points.AddXY(time, randomPoints);
            listBoxSensorData.Items.Insert(0,randomPoints);
            int alarmLow = Convert.ToInt32(alarmLowTextBox.Text);
            int alarmHigh = Convert.ToInt32(alarmHighTextBox.Text);
            if ((randomPoints>alarmHigh) || (randomPoints<alarmLow))
            {
                if (randomPoints > alarmHigh)
                {
                    textBoxStatus.Text = "HIGH VALUE!";
                    textBoxStatus.BackColor = System.Drawing.Color.Red;
                }
                else
                {
                    textBoxStatus.Text = "LOW VALUE!";
                    textBoxStatus.BackColor = System.Drawing.Color.Yellow;
                }
            }
            else
            {
                textBoxStatus.Text = "OK";
                textBoxStatus.BackColor = System.Drawing.Color.Green;
            }
        }

        private void textBoxStatus_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPageValues_Enter(object sender, EventArgs e)
        {
            textBoxValueTagName.Text = comboBoxTagName.Text;
            textBoxValueLRV.Text = lRVTextBox.Text;
            textBoxValueURV.Text = uRVTextBox.Text;
            textBoxValueAlarmLow.Text = alarmLowTextBox.Text;
            textBoxValueAlarmHigh.Text = alarmHighTextBox.Text;
            labelValueState.Text = labelInputOutput.Text;
            labelValueType.Text = labelTypeSignal.Text;
            textBoxValueLogInterval.Text = frequencyTextBox1.Text;
        }

        private void buttonTranferEditToInstrument_Click(object sender, EventArgs e)
        {
            if (comboBoxTagName.Text== textBoxTagName.Text)
            {
                comboBoxTagName.Text = textBoxTagName.Text;
                lRVTextBox.Text = textBoxLRV.Text;
                uRVTextBox.Text = textBoxURV.Text;
                alarmLowTextBox.Text = textBoxAlarmLow.Text;
                alarmHighTextBox.Text = textBoxAlarmHigh.Text;
                config_InstrumentBindingSource.EndEdit();
                config_InstrumentTableAdapter.Update(_Assignment_2__InstrumentDataSet._Config_Instrument);
            }
        }

        private void buttonValueClear_Click(object sender, EventArgs e)
        {
            listBoxSensorData.Items.Clear();
            chartValues.Series[0].Points.Clear();
        }
    }
    public class MeasurementPoint
        {
            //The objects variables
            //{get; set;} makes it possible to both change the variable(set) and read the variable(get)
            //It is possible to remove either get and set or both to make the object more rigid.
            public String time { get; set; }
            public string vab { get; set; }
            //The constructor of the object Needs to be called when you want to create a new object of this type
            public MeasurementPoint(String time, string vab)
            {
                //"this" referes to the objects variable. 
                //It is needed because the variables sent to the constructor and the objects variables are named the same. 
                this.time = time;
                this.vab = vab;
            }
            //overrides the base object ToString(). makes it possible to decide what is printed when ToString is called.
            public override string ToString()
            {
                return time + ";" + vab;
            }
        }
    }

