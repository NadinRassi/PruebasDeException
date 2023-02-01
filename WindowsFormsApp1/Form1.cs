using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PruebasExcTP.Medico;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCaso1_Click(object sender, EventArgs e)
        {
            try
            {
                Medico medico = new Medico("Luis");
                MessageBox.Show("El nombre del medico es " + medico.Nombre);
            }

            catch (Exception ex)
            {
                MessageBox.Show("Medico Invalido");

            }





        }

        private void btncaso2_Click(object sender, EventArgs e)
        {

            try { 

            Medico medico = new Medico("LuisCarlosGutierrez1234567891011121314151611718192021");
            MessageBox.Show("El nombre del medico es " + medico.Nombre);
            }

            catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void btncaso3_Click(object sender, EventArgs e)
        {
            try
            {
                Medico medico = new Medico("");
                MessageBox.Show("El nombre del medico es " + medico.Nombre);
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);

            }
        }
    }
}
