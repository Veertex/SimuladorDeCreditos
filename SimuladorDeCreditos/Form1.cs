using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimuladorDeCreditos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (verificarMonto(textBox3.Text)==true && verificarCuotas(textBox4.Text) == true)
            {
                textBox8.Text = textBox1.Text;
                textBox7.Text = textBox2.Text;
                int montoASolicitar = Convert.ToInt32(textBox3.Text);
                int cantidadDeCuotas = Convert.ToInt32(textBox4.Text);
                textBox6.Text =
                    Convert.ToString(cantidadTotal(Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text)));
                textBox5.Text =
                    Convert.ToString((valorCuotas(cantidadTotal(Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text)), Convert.ToInt32(textBox4.Text))));
            }
        }

        private int cantidadTotal(int monto, int cantidadCuotas)
        {
            if (cantidadCuotas>=1&&cantidadCuotas <= 12)
            {
                return monto + (monto * 10 / 100);
            }
            else if (cantidadCuotas >= 13 && cantidadCuotas <= 24)
            {
                return monto + (monto * 20 / 100);
            }
            else if (cantidadCuotas >= 24 && cantidadCuotas <= 36)
            {
                return monto + (monto * 35 / 100);
            }
            return 0;
        }

        private int valorCuotas(int cantidadTotal,int cantidadCuotas)
        {
            return cantidadTotal/cantidadCuotas;
        }


        private bool verificarCuotas(String cuotas)
        {
            if (Convert.ToInt32(cuotas) >=1&&Convert.ToInt32(cuotas) <= 36)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Valores ingresados no corresponden a una cantidad de cuotas valida" +
                    "\nProfavor, ingresar numero de cuotas entre el rango 1-36");
                return false;
            }
        }

        private bool verificarMonto(String monto)
        {
            if (Convert.ToInt32(monto) >= 0 && Convert.ToInt32(monto) >= 500000)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Valores ingresados no corresponden a un monto valido" +
                    "\nProfavor, ingresar monto mayor o igual a 500.000, valores negativos no permitidos");
                return false;
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
