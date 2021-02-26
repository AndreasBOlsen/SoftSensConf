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
            if (SerialPort.IsOpen == true)
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
            }
        }

        private void buttonDisconnect_Click(object sender, EventArgs e)
        {
            timerSerialPortCheck.Enabled = false;
            SerialPort.Close();
            radioButtonConnectedSerial.Checked = false;
            radioButtonConnectedInstrument.Checked = false;
            radioButtonConnectedValues.Checked = false;
            labelConnectSerial.Text = "Disconnected";
            labelConnectInstrument.Text = "Disconnected";
            labelConnectValues.Text = "Disconnected";
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            if (SerialPort.IsOpen)
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
                labelConnectInstrument.Text = "Disconnected";
                labelConnectValues.Text = "Disconnected";
            }
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
            if (SerialPort.IsOpen)
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
                labelConnectInstrument.Text = "Disconnected";
                labelConnectValues.Text = "Disconnected";
            }
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
            if (SerialPort.IsOpen)
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
                labelConnectInstrument.Text = "Disconnected";
                labelConnectValues.Text = "Disconnected";
            }
        }

        private void timerSerialRecieve_Tick(object sender, EventArgs e)
        {
            if (SerialPort.BytesToRead > 0)
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
            }
        }
        private void timerStatus_Tick(object sender, EventArgs e)
        {
            if (SerialPort.BytesToRead > 0)
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
            }
        }

        private void buttonStartAuto_Click(object sender, EventArgs e)
        {
            timerChartAdd.Enabled = true;
        }

        private void buttonStopAuto_Click(object sender, EventArgs e)
        {
            if (SerialPort.IsOpen)
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
            }
        }

        private void timerSerialPortCheck_Tick(object sender, EventArgs e)
        {
            if (!SerialPort.IsOpen)
            {
                timerSerialPortCheck.Enabled = false;
                MessageBox.Show("Serial Port disconnected");
                radioButtonConnectedSerial.Checked = false;
                radioButtonConnectedInstrument.Checked = false;
                radioButtonConnectedValues.Checked = false;
                labelConnectSerial.Text = "Disconnected";
                labelConnectInstrument.Text = "Disconnected";
                labelConnectValues.Text = "Disconnected";
            }
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

