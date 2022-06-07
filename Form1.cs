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
    public partial class Form1 : Form
    {
        private bool is_show = false;
        public Form1()
        {
            InitializeComponent();
            button1.Click += Button1_Click;
            string[] items = { "HELLO", "PEPE"};
            listBox1.Items.AddRange(items);
            listBox1.SetSelected(0,true);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            label2.Text = listBox1.SelectedItem.ToString();
            Console.WriteLine("HELP");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            is_show = !is_show;
          /*  if (is_show)
            {
                label1.Text = "Миша лох";
            }
            else
            {
                label1.Text = "Тут написана истина";
            }*/
            var test = is_show ? "Да" : "Нет";
            label1.Text = test;

            Console.WriteLine("IN LISTBOX SELECTED {0}", listBox1.SelectedItem.ToString());

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = listBox1.SelectedItem.ToString();
            Console.WriteLine("IT IS {0}!",item);
            switch (item)
            {
                case "PEPE":
                    Console.WriteLine("PEPE WAS CLICKED");
                    break;
                case "HELLO":
                    Console.WriteLine("HELLO WAS CLICKED");
                    break;
                default:
                    break;
            }
        }
    }
}
