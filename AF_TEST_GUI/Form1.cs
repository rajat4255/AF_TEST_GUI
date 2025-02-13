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

namespace AF_TEST_GUI
{
    public partial class Form1 : Form
    {
        private SerialPort _serialPort;
        public Form1()
        {
            InitializeComponent();
            LoadAvailablePorts();
        }
        private void LoadAvailablePorts()
        {
            string[] ports = SerialPort.GetPortNames();
            comboBox1.Items.AddRange(ports);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                _serialPort = new SerialPort(comboBox1.SelectedItem.ToString(),115200);
                _serialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
                try
                {
                    _serialPort.Open();
                    MessageBox.Show("Port Opened Successfully");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error opening port: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Please select a COM port.");
            }

        }
        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            string data = _serialPort.ReadExisting();
            Invoke(new Action(() => textBox1.AppendText(data + Environment.NewLine)));
            if (data[0] =='F')
            {

                //Invoke(new Action(() => FW_P_OUT.AppendText("")));
                string value = data.Substring(1);
                Invoke(new Action(() => FW_P_OUT.Text = value));
                

            }
            if(data[0] =='R')
            {

                string value = data.Substring(1);
                Invoke(new Action(() => RW_PWR_OUT.Text = value));
            }
            if (data[0] == 'T')
            {

                string value = data.Substring(1);
                Invoke(new Action(() => TMP_OUTPUT.Text = value));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (_serialPort != null && _serialPort.IsOpen)
            {
                _serialPort.Close();
                MessageBox.Show("Port Closed");
            }

        }

        private void meter2_AfterChangeValue(object sender, NationalInstruments.UI.AfterChangeNumericValueEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void FW_POWER_AfterChangeValue(object sender, NationalInstruments.UI.AfterChangeNumericValueEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
