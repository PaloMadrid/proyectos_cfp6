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

namespace Formularios
{
    public partial class FormModificar : Form
    {
        Computadora miPC;
        public FormModificar()
        {
            InitializeComponent();
        }
        public FormModificar(Computadora pcSeleccionada)
            :this()
        {
            this.miPC= pcSeleccionada;
        }

        private void FormModificar_Load(object sender, EventArgs e)
        {
            this.cmbx_procesador.DataSource = Computadora.ListadoDeProcesadores();

            //cargar los valores en form modificar
            num_numeroDeSerie.Value =(int)this.miPC.NumeroDeSerie;
            cmbx_procesador.ValueMember = this.miPC.Procesador;
            num_ram.Value = (int)this.miPC.MemoriaRam;
            num_disco.Value=(int)this.miPC.CapacidadDisco;
            


            //foreach (RadioButton item in this.gpb_so.Controls)
            //{
            //    if (item.AccessibleDescription==this.miPC.So)
            //    {
            //        item.Checked=true;
            //        break;
            //    }
            //}
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
