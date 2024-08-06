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

namespace Formularios
{
    public partial class FormEscribir : Form
    {
        List<string> escritura;
        Lapicera seleccionada;
        public FormEscribir()
        {
            InitializeComponent();
        }

        public FormEscribir(Lapicera seleccionada)
        {
            this.seleccionada = seleccionada;
        }

        private void FormEscribir_Load(object sender, EventArgs e)
        {
            escritura = new List<string>();
        }

        public void CargarLista()
        {
            lst_escritura.DataSource = null;
            lst_escritura.DataSource = escritura;
        }

        private void btn_escribir_Click(object sender, EventArgs e)
        {
            string texto = this.txbx_texto.Text;
             seleccionada = new Lapicera(Color.Red, 100, "Filgo");
            int cantidad = Funcion.ContarCaracteres(texto);

            if (string.IsNullOrEmpty(this.txbx_texto.Text))
            {
                if (int.IsPositive((int)num_cantidad.Value))
                cantidad=(int)num_cantidad.Value;
            }

            this.seleccionada.Escribir(cantidad);

            escritura.Add(texto);

            LimpiarCampos();

            MessageBox.Show($"Ha escrito correctamente. Tinta disponible: {this.seleccionada.NivelDeTinta}");
            CargarLista();

        }

        public void LimpiarCampos()
        {
            this.txbx_texto.Text=string.Empty;
            this.num_cantidad.Value=0;
        }
    }
}
