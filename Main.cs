using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exchange_rates
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();        
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
        //______________________________________
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }
//______________________________________
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(comboBox1.Text == "USD")
            {
                if(comboBox2.Text == "USD")
                {
                    if(int.TryParse(textBox1.Text, out int number))
                    {
                        textBox2.Text=(number).ToString();
                    }
                    else
                    {
                        textBox2.Text = string.Empty;
                    }
                }
                else if(comboBox2.Text =="EUR")
                {
                    if(int.TryParse(textBox1.Text,out int number))
                    {
                        textBox2.Text=(number*0.93).ToString();
                    }
                    else
                    {
                        textBox2.Text = string.Empty;
                    }
                }
                else if (comboBox2.Text == "PLN")
                {
                    if(int.TryParse(textBox1.Text,out int number))
                    {
                        textBox2.Text = (number * 3.99).ToString();
                    }
                    else
                    {
                        textBox2.Text = string.Empty;
                    }
                }
                else if (comboBox2.Text == "GBP")
                {
                    if(int.TryParse(textBox1.Text,out int number))
                    {
                        textBox2.Text=(number *0.78).ToString();
                    }
                    else
                    {
                        textBox2.Text = string.Empty;
                    }
                }
                else if (comboBox2.Text == "CHF")
                {
                    if(int.TryParse(textBox1.Text,out int number))
                    {
                        textBox2.Text = (number * 0.87).ToString();
                    }
                    else
                    {
                        textBox2.Text = string.Empty;
                    }
                }
                else if (comboBox2.Text == "AED")
                {
                    if(int.TryParse(textBox1.Text, out int number))
                    {
                        textBox2.Text = (number * 3.67).ToString();
                    }
                    else
                    {
                        textBox2.Text = string.Empty;
                    }
                }
                else if (comboBox2.Text == "AZN")
                {
                    if(int.TryParse(textBox1.Text,out int number))
                    {
                        textBox2.Text= (number *1.70).ToString();
                    }
                    else
                    {
                        textBox2.Text = string.Empty;
                    }
                }
                else if (comboBox2.Text == "BRL")
                {
                    if(int.TryParse(textBox1.Text,out int number))
                    {
                        textBox2.Text = (number * 5.75).ToString();
                    }
                    else
                    {
                        textBox2.Text = string.Empty;
                    }
                }

            }
            else if(comboBox1.Text =="EUR")
            {
                if (comboBox2.Text == "USD")
                {
                    if(int.TryParse(textBox1.Text,out int number))
                        {
                        textBox2.Text = (number * 1.08).ToString();
                        }
                    else
                    {
                        textBox2.Text = string.Empty;
                    }
                }
                else if (comboBox2.Text == "EUR")
                {
                    if (int.TryParse(textBox1.Text, out int number))
                    {
                        textBox2.Text = (number).ToString();
                    }
                    else
                    {
                        textBox2.Text = string.Empty;
                    }
                }
                else if (comboBox2.Text == "PLN")
                {
                    if(int.TryParse(textBox1.Text,out int number))
                    {
                        textBox2.Text= (number * 4.30).ToString(); 
                    }
                    else
                    {
                        textBox2.Text = string.Empty;
                    }
                }
                else if (comboBox2.Text == "GBP")
                {
                    if(int.TryParse (textBox1.Text,out int number))
                    {
                        textBox2.Text = (number * 0.85).ToString();
                    }
                    else
                    {
                        textBox2.Text = string.Empty;
                    }
                }
                else if (comboBox2.Text == "CHF")
                {
                    if (int.TryParse(textBox1.Text, out int number))
                    {
                        textBox2.Text = (number * 0.94).ToString();
                    }
                    else
                    {
                        textBox2.Text = string.Empty;
                    }
                }
                else if (comboBox2.Text == "AED")
                {
                    if (int.TryParse(textBox1.Text, out int number))
                    {
                        textBox2.Text = (number * 3.96).ToString();
                    }
                    else
                    {
                        textBox2.Text = string.Empty;
                    }
                }
                else if (comboBox2.Text == "AZN")
                {
                    if (int.TryParse(textBox1.Text, out int number))
                    {
                        textBox2.Text = (number * 1.83).ToString();
                    }
                    else
                    {
                        textBox2.Text = string.Empty;
                    }
                }
                else if (comboBox2.Text == "BRL")
                {
                    if (int.TryParse(textBox1.Text, out int number))
                    {
                        textBox2.Text = (number * 6.21).ToString();
                    }
                    else
                    {
                        textBox2.Text = string.Empty;
                    }
                }
            }
            else if (comboBox1.Text == "PLN")
            {
                if (comboBox2.Text == "USD")
                {
                    if (int.TryParse(textBox1.Text, out int number))
                    {
                        textBox2.Text = (number * 0.25).ToString();
                    }
                    else
                    {
                        textBox2.Text = string.Empty;
                    }
                }
                else if (comboBox2.Text == "EUR")
                {
                    if (int.TryParse(textBox1.Text, out int number))
                    {
                        textBox2.Text = (number * 0.23).ToString();
                    }
                    else
                    {
                        textBox2.Text = string.Empty;
                    }
                }
                else if (comboBox2.Text == "PLN")
                {
                    if (int.TryParse(textBox1.Text, out int number))
                    {
                        textBox2.Text = (number ).ToString();
                    }
                    else
                    {
                        textBox2.Text = string.Empty;
                    }
                }
                else if (comboBox2.Text == "GBP")
                {
                    if (int.TryParse(textBox1.Text, out int number))
                    {
                        textBox2.Text = (number * 0.20).ToString();
                    }
                    else
                    {
                        textBox2.Text = string.Empty;
                    }
                }
                else if (comboBox2.Text == "CHF")
                {
                    if (int.TryParse(textBox1.Text, out int number))
                    {
                        textBox2.Text = (number * 0.22).ToString();
                    }
                    else
                    {
                        textBox2.Text = string.Empty;
                    }
                }
                else if (comboBox2.Text == "AED")
                {
                    if (int.TryParse(textBox1.Text, out int number))
                    {
                        textBox2.Text = (number * 0.92).ToString();
                    }
                    else
                    {
                        textBox2.Text = string.Empty;
                    }
                }
                else if (comboBox2.Text == "AZN")
                {
                    if (int.TryParse(textBox1.Text, out int number))
                    {
                        textBox2.Text = (number * 0.43).ToString();
                    }
                    else
                    {
                        textBox2.Text = string.Empty;
                    }
                }
                else if (comboBox2.Text == "BRL")
                {
                    if (int.TryParse(textBox1.Text, out int number))
                    {
                        textBox2.Text = (number * 1.44).ToString();
                    }
                    else
                    {
                        textBox2.Text = string.Empty;
                    }
                }
            }
            else if (comboBox1.Text == "GBP")
            {
                if (comboBox2.Text == "USD")
                {
                    if (int.TryParse(textBox1.Text, out int number))
                    {
                        textBox2.Text = (number * 1.27).ToString();
                    }
                    else
                    {
                        textBox2.Text = string.Empty;
                    }
                }
                else if (comboBox2.Text == "EUR")
                {
                    if (int.TryParse(textBox1.Text, out int number))
                    {
                        textBox2.Text = (number * 1.18).ToString();
                    }
                    else
                    {
                        textBox2.Text = string.Empty;
                    }
                }
                else if (comboBox2.Text == "PLN")
                {
                    if (int.TryParse(textBox1.Text, out int number))
                    {
                        textBox2.Text = (number * 5.07).ToString();
                    }
                    else
                    {
                        textBox2.Text = string.Empty;
                    }
                }
                else if (comboBox2.Text == "GBP")
                {
                    if (int.TryParse(textBox1.Text, out int number))
                    {
                        textBox2.Text = (number * 52.39).ToString();
                    }
                    else
                    {
                        textBox2.Text = string.Empty;
                    }
                }
                else if (comboBox2.Text == "CHF")
                {
                    if (int.TryParse(textBox1.Text, out int number))
                    {
                        textBox2.Text = (number * 1.11).ToString();
                    }
                    else
                    {
                        textBox2.Text = string.Empty;
                    }
                }
                else if (comboBox2.Text == "AED")
                {
                    if (int.TryParse(textBox1.Text, out int number))
                    {
                        textBox2.Text = (number * 4.68).ToString();
                    }
                    else
                    {
                        textBox2.Text = string.Empty;
                    }
                }
                else if (comboBox2.Text == "AZN")
                {
                    if (int.TryParse(textBox1.Text, out int number))
                    {
                        textBox2.Text = (number * 2.17).ToString();
                    }
                    else
                    {
                        textBox2.Text = string.Empty;
                    }
                }
                else if (comboBox2.Text == "BRL")
                {
                    if (int.TryParse(textBox1.Text, out int number))
                    {
                        textBox2.Text = (number * 7.33).ToString();
                    }
                    else
                    {
                        textBox2.Text = string.Empty;
                    }
                }
            }
            else if (comboBox1.Text == "CHF")
            {
                if (comboBox2.Text == "USD")
                {
                    if (int.TryParse(textBox1.Text, out int number))
                    {
                        textBox2.Text = (number * 1.15).ToString();
                    }
                    else
                    {
                        textBox2.Text = string.Empty;
                    }
                }
                else if (comboBox2.Text == "EUR")
                {
                    if (int.TryParse(textBox1.Text, out int number))
                    {
                        textBox2.Text = (number * 1.06).ToString();
                    }
                    else
                    {
                        textBox2.Text = string.Empty;
                    }
                }
                else if (comboBox2.Text == "PLN")
                {
                    if (int.TryParse(textBox1.Text, out int number))
                    {
                        textBox2.Text = (number * 4.56).ToString();
                    }
                    else
                    {
                        textBox2.Text = string.Empty;
                    }
                }
                else if (comboBox2.Text == "GBP")
                {
                    if (int.TryParse(textBox1.Text, out int number))
                    {
                        textBox2.Text = (number * 0.90).ToString();
                    }
                    else
                    {
                        textBox2.Text = string.Empty;
                    }
                }
                else if (comboBox2.Text == "CHF")
                {
                    if (int.TryParse(textBox1.Text, out int number))
                    {
                        textBox2.Text = (number * 47.10).ToString();
                    }
                    else
                    {
                        textBox2.Text = string.Empty;
                    }
                }
                else if (comboBox2.Text == "AED")
                {
                    if (int.TryParse(textBox1.Text, out int number))
                    {
                        textBox2.Text = (number * 4.21).ToString();
                    }
                    else
                    {
                        textBox2.Text = string.Empty;
                    }
                }
                else if (comboBox2.Text == "AZN")
                {
                    if (int.TryParse(textBox1.Text, out int number))
                    {
                        textBox2.Text = (number * 1.95).ToString();
                    }
                    else
                    {
                        textBox2.Text = string.Empty;
                    }
                }
                else if (comboBox2.Text == "BRL")
                {
                    if (int.TryParse(textBox1.Text, out int number))
                    {
                        textBox2.Text = (number * 6.59).ToString();
                    }
                    else
                    {
                        textBox2.Text = string.Empty;
                    }
                }
            }
            else if (comboBox1.Text == "AED")
            {
                if (comboBox2.Text == "USD")
                {
                    if (int.TryParse(textBox1.Text, out int number))
                    {
                        textBox2.Text = (number * 0.27).ToString();
                    }
                    else
                    {
                        textBox2.Text = string.Empty;
                    }
                }
                else if (comboBox2.Text == "EUR")
                {
                    if (int.TryParse(textBox1.Text, out int number))
                    {
                        textBox2.Text = (number * 0.25).ToString();
                    }
                    else
                    {
                        textBox2.Text = string.Empty;
                    }
                }
                else if (comboBox2.Text == "PLN")
                {
                    if (int.TryParse(textBox1.Text, out int number))
                    {
                        textBox2.Text = (number * 1.08).ToString();
                    }
                    else
                    {
                        textBox2.Text = string.Empty;
                    }
                }
                else if (comboBox2.Text == "GBP")
                {
                    if (int.TryParse(textBox1.Text, out int number))
                    {
                        textBox2.Text = (number * 0.21).ToString();
                    }
                    else
                    {
                        textBox2.Text = string.Empty;
                    }
                }
                else if (comboBox2.Text == "CHF")
                {
                    if (int.TryParse(textBox1.Text, out int number))
                    {
                        textBox2.Text = (number * 0.24).ToString();
                    }
                    else
                    {
                        textBox2.Text = string.Empty;
                    }
                }
                else if (comboBox2.Text == "AED")
                {
                    if (int.TryParse(textBox1.Text, out int number))
                    {
                        textBox2.Text = (number * 11.20).ToString();
                    }
                    else
                    {
                        textBox2.Text = string.Empty;
                    }
                }
                else if (comboBox2.Text == "AZN")
                {
                    if (int.TryParse(textBox1.Text, out int number))
                    {
                        textBox2.Text = (number * 0.46).ToString();
                    }
                    else
                    {
                        textBox2.Text = string.Empty;
                    }
                }
                else if (comboBox2.Text == "BRL")
                {
                    if (int.TryParse(textBox1.Text, out int number))
                    {
                        textBox2.Text = (number * 1.57).ToString();
                    }
                    else
                    {
                        textBox2.Text = string.Empty;
                    }
                }
            }
            else if (comboBox1.Text == "AZN")
            {
                if (comboBox2.Text == "USD")
                {
                    if (int.TryParse(textBox1.Text, out int number))
                    {
                        textBox2.Text = (number * 0.59).ToString();
                    }
                    else
                    {
                        textBox2.Text = string.Empty;
                    }
                }
                else if (comboBox2.Text == "EUR")
                {
                    if (int.TryParse(textBox1.Text, out int number))
                    {
                        textBox2.Text = (number * 0.55).ToString();
                    }
                    else
                    {
                        textBox2.Text = string.Empty;
                    }
                }
                else if (comboBox2.Text == "PLN")
                {
                    if (int.TryParse(textBox1.Text, out int number))
                    {
                        textBox2.Text = (number * 2.34).ToString();
                    }
                    else
                    {
                        textBox2.Text = string.Empty;
                    }
                }
                else if (comboBox2.Text == "GBP")
                {
                    if (int.TryParse(textBox1.Text, out int number))
                    {
                        textBox2.Text = (number * 0.46).ToString();
                    }
                    else
                    {
                        textBox2.Text = string.Empty;
                    }
                }
                else if (comboBox2.Text == "CHF")
                {
                    if (int.TryParse(textBox1.Text, out int number))
                    {
                        textBox2.Text = (number * 0.51).ToString();
                    }
                    else
                    {
                        textBox2.Text = string.Empty;
                    }
                }
                else if (comboBox2.Text == "AED")
                {
                    if (int.TryParse(textBox1.Text, out int number))
                    {
                        textBox2.Text = (number * 2.16).ToString();
                    }
                    else
                    {
                        textBox2.Text = string.Empty;
                    }
                }
                else if (comboBox2.Text == "AZN")
                {
                    if (int.TryParse(textBox1.Text, out int number))
                    {
                        textBox2.Text = (number).ToString();
                    }
                    else
                    {
                        textBox2.Text = string.Empty;
                    }
                }
                else if (comboBox2.Text == "BRL")
                {
                    if (int.TryParse(textBox1.Text, out int number))
                    {
                        textBox2.Text = (number *3.38).ToString();
                    }
                    else
                    {
                        textBox2.Text = string.Empty;
                    }
                }
            }
            else if (comboBox1.Text == "BRL")
            {
                if (comboBox2.Text == "USD")
                {
                    if (int.TryParse(textBox1.Text, out int number))
                    {
                        textBox2.Text = (number * 0.17).ToString();
                    }
                    else
                    {
                        textBox2.Text = string.Empty;
                    }
                }
                else if (comboBox2.Text == "EUR")
                {
                    if (int.TryParse(textBox1.Text, out int number))
                    {
                        textBox2.Text = (number * 0.16).ToString();
                    }
                    else
                    {
                        textBox2.Text = string.Empty;
                    }
                }
                else if (comboBox2.Text == "PLN")
                {
                    if (int.TryParse(textBox1.Text, out int number))
                    {
                        textBox2.Text = (number * 0.69).ToString();
                    }
                    else
                    {
                        textBox2.Text = string.Empty;
                    }
                }
                else if (comboBox2.Text == "GBP")
                {
                    if (int.TryParse(textBox1.Text, out int number))
                    {
                        textBox2.Text = (number * 0.14).ToString();
                    }
                    else
                    {
                        textBox2.Text = string.Empty;
                    }
                }
                else if (comboBox2.Text == "CHF")
                {
                    if (int.TryParse(textBox1.Text, out int number))
                    {
                        textBox2.Text = (number * 0.15).ToString();
                    }
                    else
                    {
                        textBox2.Text = string.Empty;
                    }
                }
                else if (comboBox2.Text == "AED")
                {
                    if (int.TryParse(textBox1.Text, out int number))
                    {
                        textBox2.Text = (number * 0.64).ToString();
                    }
                    else
                    {
                        textBox2.Text = string.Empty;
                    }
                }
                else if (comboBox2.Text == "AZN")
                {
                    if (int.TryParse(textBox1.Text, out int number))
                    {
                        textBox2.Text = (number * 0.30).ToString();
                    }
                    else
                    {
                        textBox2.Text = string.Empty;
                    }
                }
                else if (comboBox2.Text == "BRL")
                {
                    if (int.TryParse(textBox1.Text, out int number))
                    {
                        textBox2.Text = (number).ToString();
                    }
                    else
                    {
                        textBox2.Text = string.Empty;
                    }
                }
            }
        }
    }
}
