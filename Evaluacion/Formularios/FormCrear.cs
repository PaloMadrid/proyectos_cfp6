using Evaluacion;
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
    public partial class FormCrear : Form
    {
        Computadora miPC;

        public FormCrear()
        {
            InitializeComponent();
        }

        private void FormCrear_Load(object sender, EventArgs e)
        {            
            this.cmbx_procesador.DataSource = Computadora.ListadoDeProcesadores();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            int numeroDeSerie=(int)num_numeroDeSerie.Value;
            string procesador = string.Empty;
            int ram = (int)this.num_ram.Value;
            int disco = (int)this.num_disco.Value;
            string so = string.Empty;
            string programa;

            procesador = this.cmbx_procesador.SelectedItem.ToString();

            foreach (RadioButton item in this.gpb_so.Controls)
            {
                if (item.Checked)
                {
                    so = item.Text;
                    break;
                }
            }

            if (validarDatos(procesador, "Seleccione un procesador"))
            {

                if (validarDatos(so, "Seleccione un Sistema Operativo"))
                {
                    this.miPC = new Computadora(disco, ram, procesador, so,numeroDeSerie);

                    foreach (CheckBox item in this.gpb_programas.Controls)
                    {
                        if (item.Checked)
                        {
                            programa = item.Text;

                            this.miPC.SetPrograma(programa);
                        }
                    }

                    this.DialogResult = DialogResult.OK;
                    Close();

                }
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        public bool validarDatos(string dato, string mensaje)
        {
            bool retorno = true;

            if (string.IsNullOrEmpty(dato))
            {
                MessageBox.Show(mensaje);
                retorno = false;
            }

            return retorno;
        }


        public Computadora MiPC
        {
            get
            {
                return miPC;
            }
        }
    }
}
