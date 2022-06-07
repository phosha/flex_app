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
namespace flex_app
{
    public partial class Form1 : Form
    {
        
        private readonly string[] inputs = { "VGA", "HDMI", "DisplayPort", "DVI" };

        public Form1()
        {
            InitializeComponent();

            Port_data.Baud = Port_data.Baud_list[3];
            get_ports();
            Serial_setup();
            comboBox1.Items.AddRange(inputs);
            comboBox1.SelectedIndex = 0;
           
        }


        void get_ports() {

            String[] ports = SerialPort.GetPortNames();
            Port_data.List = ports;
        }

        void Serial_setup() {

            serialPort1.BaudRate = Int32.Parse(Port_data.Baud);
            serialPort1.PortName = Port_data.List[0];
            string sett_text = string.Format("Скорость {0}  Порт {1}", serialPort1.BaudRate.ToString(),serialPort1.PortName);
            toolStripStatusLabel2.Text = sett_text;
        }


        private void cOMпортToolStripMenuItem_Click(object sender, EventArgs e)
        {
            get_ports();
            Form2 form2 = new Form2();
            form2.Show();
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Serial_setup();
            if (serialPort1.IsOpen) serialPort1.Close();
            else {
                Serial_setup();
                serialPort1.Open();
                
            }
                
            toolStripStatusLabel4.Text = serialPort1.IsOpen ? "Connected" : "Disconnected";


        }



    }
}
