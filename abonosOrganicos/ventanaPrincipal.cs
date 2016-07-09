using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace abonosOrganicos
{
    public partial class ventanaPrincipal : Form
    {
        
        public ventanaPrincipal()
        {
            InitializeComponent();
            #region Cargando Datos
            try
            {
                matricesGenerales matriz = new matricesGenerales();
                matriz.insertarMatrizNitrogeno();
                matriz.insertarCarbonos();

                cbNitrogeno.Items.Clear();
                cbNitrogeno.Items.Clear();

                cbBuscar.Items.Clear();
                for (int i = 0; i < matricesGenerales.matrizNitrogeno.Length; i++)
                {
                    if (matricesGenerales.matrizNitrogeno[i] != null)
                    {
                        cbBuscar.Items.Add(matricesGenerales.matrizNitrogeno[i].getMaterial());
                        cbNitrogeno.Items.Add(matricesGenerales.matrizNitrogeno[i].getMaterial());
                    }
                }

                cbBuscarCarbono.Items.Clear();
                for (int i = 0; i < matricesGenerales.matrizCarbono.Length; i++)
                {
                    if (matricesGenerales.matrizCarbono[i] != null)
                    {
                        cbBuscarCarbono.Items.Add(matricesGenerales.matrizCarbono[i].getMaterial());
                        cbCarbono.Items.Add(matricesGenerales.matrizCarbono[i].getMaterial());
                    }
                }
                limpiarContentAgregar();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al mostrar los datos");
            }
            #endregion
        }

        private void ventanaPrincipal_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarContentAgregar();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            #region Insertando un Nuevo Material
            try
            {
                if (verificarTextBox() == true)
                {
                    string material = txtMaterial.Text;
                    double mo = Convert.ToDouble(txtMO.Text);
                    double c = Convert.ToDouble(txtC.Text);
                    double n = Convert.ToDouble(txtN.Text);
                    double cn = Convert.ToDouble(txtCN.Text);
                    double po = Convert.ToDouble(txtPO.Text);
                    double ko = Convert.ToDouble(txtKO.Text);
                    Boolean ext = false;
                    if (rbCarbono.Checked == true)
                    {
                        for (int i = 0; i < matricesGenerales.matrizCarbono.Length; i++)
                        {
                            if (matricesGenerales.matrizCarbono[i] == null && ext != true)
                            {
                                matricesGenerales.matrizCarbono[i] = new clsMatriz(material, mo, c, n, cn, po, ko);
                                ext = true;
                            }
                            if (i == matricesGenerales.matrizCarbono.Length - 1 && ext != true)
                            {
                                Array.Resize(ref matricesGenerales.matrizCarbono, 5);
                            }
                        }
                    }
                    else if (rbNitrogeno.Checked == true)
                    {
                        for (int i = 0; i < matricesGenerales.matrizNitrogeno.Length; i++)
                        {
                            if (matricesGenerales.matrizNitrogeno[i] == null && ext != true)
                            {
                                matricesGenerales.matrizNitrogeno[i] = new clsMatriz(material, mo, c, n, cn, po, ko);
                                ext = true;
                            }
                            if (i == matricesGenerales.matrizNitrogeno.Length - 1 && ext != true)
                            {
                                Array.Resize(ref matricesGenerales.matrizNitrogeno, 5);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Te faltan datos por ingresar!");
                }
                cbBuscar.Items.Clear();
                for (int i = 0; i < matricesGenerales.matrizNitrogeno.Length; i++)
                {
                    if (matricesGenerales.matrizNitrogeno[i] != null)
                    {
                        cbBuscar.Items.Add(matricesGenerales.matrizNitrogeno[i].getMaterial());
                    }
                }

                cbBuscarCarbono.Items.Clear();
                for (int i = 0; i < matricesGenerales.matrizCarbono.Length; i++)
                {
                    if (matricesGenerales.matrizCarbono[i] != null)
                    {
                        cbBuscarCarbono.Items.Add(matricesGenerales.matrizCarbono[i].getMaterial());
                    }
                }
                limpiarContentAgregar();
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un error con la inserccion de datos");
            }
            #endregion
        }
        public Boolean verificarTextBox()
        {
            Boolean resultado = false;
            if(!String.IsNullOrWhiteSpace(txtC.Text)&&!String.IsNullOrWhiteSpace(txtCN.Text) && !String.IsNullOrWhiteSpace(txtKO.Text) && !String.IsNullOrWhiteSpace(txtMaterial.Text) && !String.IsNullOrWhiteSpace(txtMO.Text) && !String.IsNullOrWhiteSpace(txtN.Text) && !String.IsNullOrWhiteSpace(txtPO.Text))
            {
                return true;
            }
            return resultado;
        }
        public void limpiarContentAgregar()
        {
            txtMaterial.Text = "";
            txtMO.Text = "";
            txtC.Text = "";
            txtN.Text = "";
            txtCN.Text = "";
            txtPO.Text = "";
            txtKO.Text = "";
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            #region Buscando Material Rico en Nitrogeno
            if (!String.IsNullOrWhiteSpace(cbBuscar.Text))
            {
                Boolean ext = false;
                for (int i = 0; i < matricesGenerales.matrizNitrogeno.Length || ext != true; i++)
                {
                    if (matricesGenerales.matrizNitrogeno[i] != null)
                    {
                        if ((matricesGenerales.matrizNitrogeno[i].getMaterial() == cbBuscar.Text) && (ext != true))
                        {
                            txtBMaterial.Text = matricesGenerales.matrizNitrogeno[i].getMaterial();
                            txtBMO.Text = Convert.ToString(matricesGenerales.matrizNitrogeno[i].getMO());
                            txtBC.Text = Convert.ToString(matricesGenerales.matrizNitrogeno[i].getC());
                            txtBN.Text = Convert.ToString(matricesGenerales.matrizNitrogeno[i].getN());
                            txtBCN.Text = Convert.ToString(matricesGenerales.matrizNitrogeno[i].getCN());
                            txtBPO.Text = Convert.ToString(matricesGenerales.matrizNitrogeno[i].getPO());
                            txtBKO.Text = Convert.ToString(matricesGenerales.matrizNitrogeno[i].getKO());
                            ext = true;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione algún elemento de la lista");
            }
            #endregion
        }

        private void btnBuscarC_Click(object sender, EventArgs e)
        {
            #region Buscando Material Rico en Carbono
            try
            {
                if (!String.IsNullOrWhiteSpace(cbBuscarCarbono.Text))
                {
                    Boolean ext = false;
                    for (int i = 0; i < matricesGenerales.matrizCarbono.Length || ext != true; i++)
                    {
                        if (matricesGenerales.matrizCarbono[i] != null)
                        {
                            if ((matricesGenerales.matrizCarbono[i].getMaterial() == cbBuscarCarbono.Text) && (ext != true))
                            {
                                txtCMaterial.Text = matricesGenerales.matrizCarbono[i].getMaterial();
                                txtCMO.Text = Convert.ToString(matricesGenerales.matrizCarbono[i].getMO());
                                txtCC.Text = Convert.ToString(matricesGenerales.matrizCarbono[i].getC());
                                txtCCN.Text = Convert.ToString(matricesGenerales.matrizCarbono[i].getN());
                                txtCCNN.Text = Convert.ToString(matricesGenerales.matrizCarbono[i].getCN());
                                txtCPO.Text = Convert.ToString(matricesGenerales.matrizCarbono[i].getPO());
                                txtCKO.Text = Convert.ToString(matricesGenerales.matrizCarbono[i].getKO());
                                ext = true;
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione algún elemento de la lista");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un error en la busqueda");
            }
            #endregion
        }

        private void btnImprimirCarbono_Click(object sender, EventArgs e)
        {
            c_Carbono.f_ricosenCarbono form = new c_Carbono.f_ricosenCarbono();
            form.ShowDialog();
        }

        private void btnImprimirNitrogeno_Click(object sender, EventArgs e)
        {
            c_Nitrogeno.f_ricosenNitrogeno form = new c_Nitrogeno.f_ricosenNitrogeno();
            form.ShowDialog();
        }
        #region KeyPress
        private void txtMaterial_KeyPress(object sender, KeyPressEventArgs e)
        {
            matricesGenerales.SoloLetras(e);
        }
        private void txtMO_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            matricesGenerales.SoloNumeros(e);
        }
        private void txtC_KeyPress(object sender, KeyPressEventArgs e)
        {
            matricesGenerales.SoloNumeros(e);
        }

        private void txtN_KeyPress(object sender, KeyPressEventArgs e)
        {
            matricesGenerales.SoloNumeros(e);
        }

        private void txtCN_KeyPress(object sender, KeyPressEventArgs e)
        {
            matricesGenerales.SoloNumeros(e);
        }

        private void txtPO_KeyPress(object sender, KeyPressEventArgs e)
        {
            matricesGenerales.SoloNumeros(e);
        }

        private void txtKO_KeyPress(object sender, KeyPressEventArgs e)
        {
            matricesGenerales.SoloNumeros(e);
        }
        #endregion
        private void txtKO_KeyDown(object sender, KeyEventArgs e)
        {
            #region Insertando Nuevo Material
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (verificarTextBox() == true)
                    {
                        string material = txtMaterial.Text;
                        double mo = Convert.ToDouble(txtMO.Text);
                        double c = Convert.ToDouble(txtC.Text);
                        double n = Convert.ToDouble(txtN.Text);
                        double cn = Convert.ToDouble(txtCN.Text);
                        double po = Convert.ToDouble(txtPO.Text);
                        double ko = Convert.ToDouble(txtKO.Text);

                        double rComposicion = c / n;
                        string resultado = "";

                        if ((rComposicion > 25 && rComposicion < 30) || (rComposicion > 30 && rComposicion < 35))
                        {
                            resultado = "Composición Equilibrada";
                        }
                        else if (rComposicion == 30)
                        {
                            resultado = "Composición Optimizada";
                        }
                        else if (rComposicion <= 25 || rComposicion >= 35)
                        {
                            resultado = "Composición no Aprobada";
                        }
                        Boolean ext = false;
                        if (rbCarbono.Checked == true)
                        {
                            for (int i = 0; i < matricesGenerales.matrizCarbono.Length; i++)
                            {
                                if (matricesGenerales.matrizCarbono[i] == null && ext != true)
                                {
                                    matricesGenerales.matrizCarbono[i] = new clsMatriz(material, mo, c, n, cn, po, ko);
                                    ext = true;
                                }
                                if (i == matricesGenerales.matrizCarbono.Length - 1 && ext != true)
                                {
                                    Array.Resize(ref matricesGenerales.matrizCarbono, 5);
                                }
                            }
                        }
                        else if (rbNitrogeno.Checked == true)
                        {
                            for (int i = 0; i < matricesGenerales.matrizNitrogeno.Length; i++)
                            {
                                if (matricesGenerales.matrizNitrogeno[i] == null && ext != true)
                                {
                                    matricesGenerales.matrizNitrogeno[i] = new clsMatriz(material, mo, c, n, cn, po, ko);
                                    ext = true;
                                }
                                if (i == matricesGenerales.matrizNitrogeno.Length - 1 && ext != true)
                                {
                                    Array.Resize(ref matricesGenerales.matrizNitrogeno, 5);
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Te faltan datos por ingresar!");
                    }
                    cbBuscar.Items.Clear();
                    for (int i = 0; i < matricesGenerales.matrizNitrogeno.Length; i++)
                    {
                        if (matricesGenerales.matrizNitrogeno[i] != null)
                        {
                            cbBuscar.Items.Add(matricesGenerales.matrizNitrogeno[i].getMaterial());
                        }
                    }

                    cbBuscarCarbono.Items.Clear();
                    for (int i = 0; i < matricesGenerales.matrizCarbono.Length; i++)
                    {
                        if (matricesGenerales.matrizCarbono[i] != null)
                        {
                            cbBuscarCarbono.Items.Add(matricesGenerales.matrizCarbono[i].getMaterial());
                        }
                    }
                    limpiarContentAgregar();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un error con la inserccion de datos");
            }
            #endregion
        }

        private void contactoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("alan_hernandezgarcia@hotmail.com");
        }

        private void label24_Click(object sender, EventArgs e)
        {

        }
        private void btnResolver_Click_1(object sender, EventArgs e)
        {
            #region Resolviendo Formula
            double nn= 0.0, cn = 0.0, nc = 0.0, cc = 0.0, x = 0.0;

            if (!String.IsNullOrWhiteSpace(cbNitrogeno.Text) && !String.IsNullOrWhiteSpace(cbCarbono.Text))
            {
                Boolean ext = false;
                try
                {
                    for (int i = 0; i < matricesGenerales.matrizNitrogeno.Length || ext != true; i++)
                    {
                        if (matricesGenerales.matrizNitrogeno[i] != null)
                        {
                            if ((matricesGenerales.matrizNitrogeno[i].getMaterial() == cbNitrogeno.Text) && (ext != true))
                            {
                                nn = matricesGenerales.matrizNitrogeno[i].getN();
                                cn = matricesGenerales.matrizNitrogeno[i].getC();
                                ext = true;
                            }
                        }
                    }


                    ext = false;

                    for (int i = 0; i < matricesGenerales.matrizCarbono.Length || ext != true; i++)
                    {
                        if (matricesGenerales.matrizCarbono[i] != null)
                        {
                            if ((matricesGenerales.matrizCarbono[i].getMaterial() == cbCarbono.Text) && (ext != true))
                            {
                                nc = matricesGenerales.matrizCarbono[i].getN();
                                cc = matricesGenerales.matrizCarbono[i].getC();
                                ext = true;
                            }
                        }
                    }
                    double resultadoN = (30 * nn) - cn;
                    double resultadoC = cc - (30 * nc);
                    double resultado = resultadoN / resultadoC;
                    txtResultadoComp.Text = Convert.ToString(resultado);


                }
                catch (Exception)
                {
                    MessageBox.Show("Error al resolver la formula");
                }
                
            }
            else
            {
                MessageBox.Show("Te falta seleccionar algún campo!");
            }
            #endregion
        }
    }
}
