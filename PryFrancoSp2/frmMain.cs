using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryFrancoSp2
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lstTipo_SelectedIndexChanged(object sender, EventArgs e)
        {


            if (lstTipo.SelectedIndex != -1)
            {
                lstPersona.Enabled = true;

            }
            else
            {
                lstPersona.Enabled = false;
            }

            if (lstTipo.Text == "A")
            {
                lstPersona.Items.Clear();
                lstPersona.Items.Add(1);
                lstPersona.Items.Add(2);
                lstPersona.Items.Add(3);
                lstPersona.Items.Add(4);
            }

            if (lstTipo.Text == "B")
            {
                lstPersona.Items.Clear();
                lstPersona.Items.Add(1);
                lstPersona.Items.Add(2);
                lstPersona.Items.Add(3);
                lstPersona.Items.Add(4);
                lstPersona.Items.Add(5);
                lstPersona.Items.Add(6);
                lstPersona.Items.Add(7);
                lstPersona.Items.Add(8);

            }

        }

        private void lstPersona_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstPersona.Text != "")
            {
                txtDias.Enabled = true;

            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            float precio = 0;
            int personas =int.Parse(lstPersona.Text.ToString());
            int dias =int.Parse(lstPersona.Text.ToString());
            //selecion de precio
            if (lstTipo.Text == "A")
            {
                precio = 20;
                if (chkCocina.Checked)
                {
                    precio = precio + (dias * 1);
                }
                else if (chkHeladera.Checked)
                {
                    precio = precio + (float)(dias * 1.5);
                }
                else if (chkTelevision.Checked)
                {
                    precio = precio + (dias * 2);
                }
                precio = precio + ((personas * 1) * dias);
            }
            else if(lstTipo.Text == "B")
            {
                precio = 34;

                if (chkCocina.Checked)
                {
                    precio = precio + (dias * 1);

                }
                else if (chkHeladera.Checked)
                {
                    precio = precio + (float)(dias * 1.5);
                }
                else if (chkTelevision.Checked)
                {
                    precio = precio + (dias * 2);

                }
                precio = precio + ((personas * 1) * dias);

            }

            //agregado de precio por tarjetas
            if (optTarjeta.Checked && lstTarjetas.Text == "RED CARD")
            {
                precio = precio + (float)(precio * 0.1);
            }
            else if (optTarjeta.Checked && lstTarjetas.Text == "GREEN CARD" || lstTarjetas.Text == "BLUE CARD")
            {
                precio = precio + (float)(precio * 0.2);
            }

            MessageBox.Show("El coste total de la reserva es: " + precio);
            lstTarjetas.Items.Clear();
            lstTipo.SelectedIndex = 0;
            lstPersona.SelectedIndex = 0;
            chkCocina.Checked = false;
            chkHeladera.Checked = false;
            chkTelevision.Checked = false;
            optEfectivo.Checked = true;
            txtNombre.Text = "";
            txtTelefono.Text = "";
        }

        private void mrcFormadepago_Enter(object sender, EventArgs e)
        {

        }

        private void lblNombre_Click(object sender, EventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            txtDias.SelectedText = "1";
            lstTipo.SelectedIndex = 0;
            lstPersona.SelectedIndex = 0;   
        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtDias.Text) > 0 && txtNombre.Text != "" && txtTelefono.Text != "")
            {
                btnAceptar.Enabled = true;
            }
            else
            {
                btnAceptar.Enabled = false;
            }
        }

        private void lstTarjetas_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }

        private void optTarjeta_CheckedChanged(object sender, EventArgs e)
        {
            if (optTarjeta.Checked == true)
            {
                lstTarjetas.Enabled = true;
                lstTarjetas.SelectedIndex = 0;
            }
            else
            {
                lstTarjetas.Enabled = false;
                lstTarjetas.SelectedIndex = -1;

            }
            
            
            
            
            
            
            
            
            
            
        }
    }
}
