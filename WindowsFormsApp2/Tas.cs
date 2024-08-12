using Ejercicio1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Tas : Form
    {
       
        public Tas()
        {
            InitializeComponent();
        }

        public void btnCalcular_Click(object sender, EventArgs e)
        {
            Ver resultados = new Ver();

            //resultados.lbVer.Items.Clear();

            string marca = tbMarca.Text;
            int modelo = Convert.ToInt32(nudModelo.Value);
            double valor = Convert.ToDouble(tbValor.Text);
            //int año = Convert.ToInt32(nudAño.Text);
            //int vida = Convert.ToInt32(tbVida.Text);
            //double tasa = Convert.ToDouble(tbTasa.Text);

            Moto motito;

            motito = new Moto(marca, modelo, valor);
                          
           double lineal = motito.CalcularDepreciacionLineal(Convert.ToInt32(nudAño.Text), Convert.ToInt32(tbVida.Text));
                    
           double anual = motito.CalcularDepreciacionAnual(Convert.ToInt32(nudAño.Text), Convert.ToDouble(tbTasa.Text));
                
           string datos = motito.VerDescripcion();             

                resultados.lbVer.Items.Add($"{datos}");
                resultados.lbVer.Items.Add($"Depreciación lineal: {lineal,10:f2}");
                resultados.lbVer.Items.Add($"Depreciación anual: {anual,10:f2}");
                resultados.ShowDialog();
            

        }
    }
}
