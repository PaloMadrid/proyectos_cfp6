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

namespace Mis_Forms
{
    public partial class FormCrear : Form
    {
        Partida nuevaPartida;
        public FormCrear()
        {
            InitializeComponent();
        }

        private void FormCrear_Load(object sender, EventArgs e)
        {
            //@ lee la cadena de forma literal. otra forma escribir rutas es con \\:"E:\\Documentos\\a.gif" 
            picbox_fondo.Image = Image.FromFile(@"E:\personal\curso programacion\proyectos\GestonRecursos\Multimedia\ceniza.gif");
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            //Close();
        }

        private void btn_crear_Click(object sender, EventArgs e)
        {
            string dificultad = string.Empty;
            string nombre;

            //????
            string mensaje = "";

            nombre = txbx_nombre.Text;

            foreach (RadioButton item in grbx_dificultad.Controls)
            {
                if (item.Checked)
                {
                    dificultad = item.Text;

                    break;
                }

            }

            if (validarDatos(nombre))
            {
                MessageBox.Show("Escriba un nombre para la partida");
            }
            else if (validarDatos(dificultad))
            {
                MessageBox.Show("Elija una dificultad");
            }
            else
            {
               
                this.nuevaPartida = new Partida(nombre, dificultad);
                this.DialogResult = DialogResult.OK;

                //Close();
            }

        }

        public Partida PartidaNueva
        {
            get
            {
                return this.nuevaPartida;
            }
        }

        public bool validarDatos(string dato)
        {
            bool retorno = false ;
            string mensaje = "";

            if (string.IsNullOrEmpty(dato))
            {
                retorno = true;
                //MessageBox.Show(mensaje);
            }

            return retorno;
        }
    }
}
