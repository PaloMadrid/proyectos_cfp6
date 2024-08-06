
using Mis_clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsV1
{
    public partial class FormEscribir1 : Form
    {
        private List<Lapicera> misLapiceras = new List<Lapicera>();
        private Lapicera lapiceraSeleccionada;



        public FormEscribir1()
        {
            InitializeComponent();
        }

        private void btn_escribir_Click(object sender, EventArgs e)
        {
            string textoIngresado = txbx_texto.Text;

            seleccionarLapicera((Lapicera)lst_lapiceras.SelectedItem);
                 
            consumirTinta(textoIngresado, lapiceraSeleccionada);

            txbx_texto.Clear();
        }

        private void seleccionarLapicera(Lapicera lapiceraSeleccionada)
        {
            

            //analizar que haya seleccionado un item de la lista
            if (lst_lapiceras.SelectedItem != null)
            {
                //Obtener el objeto seleccionado del ListBox
                this.lapiceraSeleccionada = (Lapicera)lst_lapiceras.SelectedItem;

            }
            else
            {
                MessageBox.Show("Por favor, selecciona una lapicera antes de escribir.");
            }


            
        }

        private void FormEscribir_Load(object sender, EventArgs e)
        {
            this.misLapiceras = Lapicera.ListaDeLapiceras();
            this.lst_lapiceras.DataSource = this.misLapiceras;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_recargar_Click(object sender, EventArgs e)
        {            
            seleccionarLapicera((Lapicera)lst_lapiceras.SelectedItem);

            lapiceraSeleccionada.Recargar();

            MessageBox.Show($"La lapicera se ha recargado. Nivel de tinta: {lapiceraSeleccionada.NivelDeTinta}");
        }

        private static void consumirTinta(string textoIngresado, Lapicera lapiceraSeleccionada)
        {
            if (lapiceraSeleccionada.Escribir(textoIngresado))
            {
                MessageBox.Show($"la lapicera escribio {textoIngresado}. \nNivel de tinta: {lapiceraSeleccionada.NivelDeTinta}");

            }
            else
            {
                MessageBox.Show($"El nivel de tinta actual no es suficiente para escribir: " +
                    $"\n{textoIngresado}. " +
                    $"\nNivel de tinta:{lapiceraSeleccionada.NivelDeTinta}." +
                    $"\nTinta necesaria: {Funcion.ContarCaracteres(textoIngresado)}. ");
            }
        }


        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
