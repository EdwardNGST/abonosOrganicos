using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace abonosOrganicos.c_Carbono
{
    public partial class f_ricosenCarbono : Form
    {
        public f_ricosenCarbono()
        {
            InitializeComponent();
        }

        private void f_ricosenCarbono_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            try
            {
                for (int i = 0; i < matricesGenerales.matrizCarbono.Length - 1; i++)
                {
                    if (matricesGenerales.matrizCarbono[i] != null)
                    {
                        dgvResultado.Rows.Add(matricesGenerales.matrizCarbono[i].getMaterial(), matricesGenerales.matrizCarbono[i].getMO(), matricesGenerales.matrizCarbono[i].getC(), matricesGenerales.matrizCarbono[i].getN(), matricesGenerales.matrizCarbono[i].getCN(), matricesGenerales.matrizCarbono[i].getPO(), matricesGenerales.matrizCarbono[i].getKO());
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un error cargando la tabla");
            }
        }
    }
}
