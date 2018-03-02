using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _47FarbcodeDerWiderstände
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Farben(comboBox1);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Farben(comboBox2);
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            Farben(comboBox3);
        }

        private void Farben(ComboBox cb)
        {
            switch (cb.Text)
            {
                case "schwarz":
                    {
                        cb.BackColor = Color.Black;
                        cb.ForeColor = Color.White;
                    }
                    break;
                case "braun":
                    {
                        cb.BackColor = Color.Brown;
                    }
                    break;
                case "rot":
                    {
                        cb.BackColor = Color.Red;
                    }
                    break;
                case "orange":
                    {
                        cb.BackColor = Color.Orange;
                    }
                    break;
                case "gelb":
                    {
                        cb.ForeColor = Color.Black;
                        cb.BackColor = Color.Yellow;
                    }
                    break;
                case "grün":
                    {
                        cb.BackColor = Color.Green;
                    }
                    break;
                case "blau":
                    {
                        cb.ForeColor = Color.White;
                        cb.BackColor = Color.Blue;
                    }
                    break;
                case "violett":
                    {
                        cb.BackColor = Color.Violet;
                    }
                    break;
                case "grau":
                    {
                        cb.BackColor = Color.Gray;
                    }
                    break;
                case "weiß":
                    {
                        cb.ForeColor = Color.Black;
                        cb.BackColor = Color.White;
                    }
                    break;

            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox4.Text)
            {
                case "grau   +-0.05%":
                    {
                        comboBox4.BackColor = Color.Gray;
                    }
                    break;
                case "violett   +-0.1%":
                    {
                        comboBox4.BackColor = Color.Violet;
                    }
                    break;

                case "grün   +-0.5%":
                    {
                        comboBox4.BackColor = Color.Green;
                    }
                    break;
                case "braun   +-1%":
                    {
                        comboBox4.BackColor = Color.Brown;
                    }
                    break;
                case "rot   +-2%":
                    {
                        comboBox4.BackColor = Color.Red;
                    }
                    break;
                case "gold   +-5%":
                    {
                        comboBox4.BackColor = Color.Gold;
                    }
                    break;
                case "silber   +-10%":
                    {
                        comboBox4.BackColor = Color.Silver;
                    }
                    break;
                case "keine   +-20%":
                    {
                        comboBox4.ForeColor = Color.Black;
                        comboBox4.BackColor = Color.White;
                    }
                    break;
                case "blau   +-0.25%":
                    {
                        comboBox4.ForeColor = Color.White;
                        comboBox4.BackColor = Color.Blue;
                    }
                    break;
            }
        }
       

       


    }
}
