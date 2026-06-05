using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pry_CAlculadoraaaa
{
    public partial class frmCalculadora : Form
    {
        //Objeto
        
        public frmCalculadora()
        {
            InitializeComponent();
        }
        //Suma
        private void btnSumar_Click(object sender, EventArgs e)
        {
            clsCalculadoracs calc = new clsCalculadoracs(float.Parse(txtN1.Text), float.Parse(txtN2.Text));
            txtResult.Text = calc.sumar().ToString("");
        }
        //Resta
        private void btnRestar_Click(object sender, EventArgs e)
        {
            clsCalculadoracs calc = new clsCalculadoracs(float.Parse(txtN1.Text), float.Parse(txtN2.Text));
            txtResult.Text = calc.restar().ToString("");
        }
        //Multiplicacion
        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            clsCalculadoracs calc = new clsCalculadoracs(float.Parse(txtN1.Text), float.Parse(txtN2.Text));
            txtResult.Text = calc.multiplicar().ToString("");
        }
        //Division
        private void btnDvidir_Click(object sender, EventArgs e)
        {
            clsCalculadoracs calc = new clsCalculadoracs(float.Parse(txtN1.Text), float.Parse(txtN2.Text));
            txtResult.Text = calc.dividir().ToString("");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
