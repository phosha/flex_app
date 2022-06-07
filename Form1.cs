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
           

            string[] items = { "HELLO", "PEPE"};
            comboBox1.Items.AddRange(inputs);
            comboBox1.SelectedIndex = 0;
           
        }


        void get_ports() {

            String[] ports = SerialPort.GetPortNames();
            Port_data.List = ports;
        }








        private void cOMпортToolStripMenuItem_Click(object sender, EventArgs e)
        {
            get_ports();
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
