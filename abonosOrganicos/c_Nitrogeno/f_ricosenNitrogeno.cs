using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace abonosOrganicos.c_Nitrogeno
{
    public partial class f_ricosenNitrogeno : Form
    {
        public f_ricosenNitrogeno()
        {
            InitializeComponent();
        }
        private void f_ricosenNitrogeno_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            try
            { 
            for (int i = 0; i < matricesGenerales.matrizNitrogeno.Length - 1; i++)
            {
                if (matricesGenerales.matrizNitrogeno[i] != null)
                {
                    dgvResultado.Rows.Add(matricesGenerales.matrizNitrogeno[i].getMaterial(), matricesGenerales.matrizNitrogeno[i].getMO(), matricesGenerales.matrizNitrogeno[i].getC(), matricesGenerales.matrizNitrogeno[i].getN(), matricesGenerales.matrizNitrogeno[i].getCN(), matricesGenerales.matrizNitrogeno[i].getPO(), matricesGenerales.matrizNitrogeno[i].getKO());
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
