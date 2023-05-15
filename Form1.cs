using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ENTORNOSDEDESARROLLO_Ejercicio_21_Validaciones
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            MaskedTextBox fecha = new MaskedTextBox();
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            label7.Text = "Valor incorrecto";
        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            label8.Text = "Valor incorrecto";
        }

        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            label9.Text = "Valor incorrecto";
        }

        private void maskedTextBox5_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            label11.Text = "Valor incorrecto";
        }

        private void maskedTextBox6_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            label12.Text = "Valor incorrecto";
        }
    }
}