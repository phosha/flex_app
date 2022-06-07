using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace flex_app
{
    public partial class Form2 : Form
    {
        private string[] baud_list = { "9600", "19200", "38400", "115200" };
        public Form2()
        {
            InitializeComponent();

            listBox1.Items.AddRange(Port_data.List);

            comboBox1.Items.AddRange(baud_list);
            comboBox1.SelectedIndex = 3;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Port_data.Port_set = listBox1.SelectedItem.ToString();
            
        }
    }
}
