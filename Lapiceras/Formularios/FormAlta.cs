using Librerias;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Formularios
{
    public partial class FormAlta : Form
    {
        Lapicera nuevaLapicera;
        public FormAlta()
        {
            InitializeComponent();
        }

        private void FormAlta_Load(object sender, EventArgs e)
        {
            cbx_color.DataSource = Lapicera.ListaDeColores();
        }

        private void btn_crear_Click(object sender, EventArgs e)
        {
            string marca = string.Empty;
            Color color = Color.FromName(cbx_color.Text);
            string precioString= tbx_precio.Text;
            int precio;

            foreach (RadioButton rb in grbx_marca.Controls)
            {
                if (rb.Checked)
                {
                    marca = rb.Text;
                    break;
                }
            }

            if (Funcion.validarString(marca))
            {
                MessageBox.Show("Seleccione una marca");
            }
            else if (Funcion.validarColor(color))
            {
                MessageBox.Show("Seleccione una marca");
            }
            else if (!int.TryParse(precioString, out precio))
            {
                MessageBox.Show("Ingrese un precio válido");
            }
            else
            {
                nuevaLapicera = new Lapicera(color, precio, marca);
                DialogResult = DialogResult.OK;
            }     
            

        }

        public Lapicera LaLapicera
        {
            get { return nuevaLapicera; }
        }
    }
}
