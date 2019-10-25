using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegisztracioAlkalmazas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton_ferfi_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton_no_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void button_hozzaad_Click(object sender, EventArgs e)
        {
            listBox_hobbilista.Items.Add(textBox_hobbi.Text);
            textBox_hobbi.Text = "";
        }

        private void button_mentes_Click(object sender, EventArgs e)
        {
            StreamWriter szemelyes = new StreamWriter("SzemelyesAdatok.txt", false, Encoding.UTF8);
            
            if (textBox_nev.Text != "")
            {
                szemelyes.Write(textBox_nev.Text+",");
            }
            if (textBox_szuldatum.Text != "")
            {
                szemelyes.Write(textBox_szuldatum.Text + ",");
            }
            if (radioButton_ferfi.Checked == true)
            {
                szemelyes.Write("Férfi");
            }
            else
            {
                szemelyes.Write("Nő");
            }
            szemelyes.Close();

            //StreamWriter hobbik = new StreamWriter("Hobbik.txt", true, Encoding.UTF8);
            File.WriteAllLines("hobbik.txt",listBox_hobbilista.Items.Cast<string>());
            //hobbik.Close();

        }

        private void button_betolt_Click(object sender, EventArgs e)
        {
            foreach (var line in File.ReadLines("hobbik.txt"))
            {
                listBox_hobbilista.Items.Add(line);
            }
            foreach (var xD in File.ReadLines("SzemelyesAdatok.txt"))
            {
                string[] sor = xD.Split(',');
                textBox_nev.Text = sor[0];
                textBox_szuldatum.Text = sor[1];
                if (sor[2].Equals("Férfi"))
                {
                    radioButton_ferfi.Checked = true;
                }
                else
                {
                    radioButton_no.Checked = true;
                }
            }
        }
    }
}
