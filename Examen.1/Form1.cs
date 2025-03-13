using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void variable1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1, num2;

            if (int.TryParse(txtnum1.Text, out num1) && int.TryParse(txtnum2.Text, out num2))
            {
                if (num1 < num2)
                {
                    MessageBox.Show("El número " + txtnum2.Text + " es mayor que " + txtnum1.Text);
                }
                else if (num1 > num2)
                {
                    MessageBox.Show("El número " + txtnum1.Text + " es mayor que " + txtnum2.Text);
                }
                else
                {
                    MessageBox.Show("Los números son iguales");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingresa un valor válido");
            }
        }
    }
}