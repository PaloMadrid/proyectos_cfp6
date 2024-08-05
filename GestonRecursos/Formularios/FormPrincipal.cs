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
    public partial class FormPrincipal : Form
    {
        private List<Partida> partidas;
        Partida partidaSeleccionada;

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            this.partidas = new List<Partida>();
            this.partidas = Partida.listaDePartidas();
            CargarDGV();
        }


        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta;

            //respuesta = MessageBox.Show("Esta seguro que desea salir?", "", MessageBoxButtons.YesNo);
            //if (respuesta == DialogResult.Yes)
            {
                Close();
                //solo cierra formulario actual a menos que sea el principal que cierra todo
            }

        }

        private void btn_nuevaPartida_Click(object sender, EventArgs e)
        {
            FormCrear formAlta = new FormCrear();
            formAlta.ShowDialog();

            if (formAlta.DialogResult == DialogResult.OK)
            {
                Partida nueva = formAlta.PartidaNueva;
                partidas.Add(nueva);

                CargarDGV();

                this.partidaSeleccionada = nueva;

                cargarPartida();

            }

        }

        private void btn_cargarPartida_Click(object sender, EventArgs e)
        {
            // Verifica si hay filas seleccionadas
            if (dtg_partidas.SelectedRows.Count == 1)
            {
                // Obtén la primera fila seleccionada (puedes ajustar si hay múltiples filas seleccionadas)
                DataGridViewRow fila_seleccionada = dtg_partidas.SelectedRows[0];
                // Asegúrate de que la fila tiene el número esperado de columnas
                if (fila_seleccionada.Cells.Count >= 3) // Ajusta el número de columnas si es necesario
                {
                    // Extrae los valores de las celdas
                    string nombre = fila_seleccionada.Cells[0].Value.ToString(); // Primera columna para el nombre
                    string dificultad = fila_seleccionada.Cells[1].Value.ToString(); // Segunda columna para la dificultad

                    int dias = (int)fila_seleccionada.Cells[2].Value;

                    // Crea y devuelve una instancia de Partida

                    this.partidaSeleccionada = new Partida(nombre, dificultad, dias);

                    cargarPartida();
                }
            }
        }
        private void CargarDGV()
        {

            this.dtg_partidas.DataSource = null;
            this.dtg_partidas.DataSource = this.partidas;



        }

        private void cargarPartida()
        {
            DataTable datos = ConvertirPartidaADataTable();

            FormCasa formPartida = new FormCasa();

            //usa el metodo setdata creado en form secundario para setear los datos en el dtg del form secundario
            formPartida.SetData(datos);

            formPartida.ShowDialog();

        }

        public DataTable ConvertirPartidaADataTable()
        {
            DataTable dataTable = new DataTable();

            // Agregar columnas al DataTable
            dataTable.Columns.Add("Nombre", typeof(string));
            dataTable.Columns.Add("Dificultad", typeof(string));
            dataTable.Columns.Add("Dias", typeof(int));

            // Agregar una fila al DataTable
            DataRow fila = dataTable.NewRow();
            fila["Nombre"] = this.partidaSeleccionada.Nombre;
            fila["Dificultad"] = this.partidaSeleccionada.Dificultad;
            fila["Dias"] = this.partidaSeleccionada.Dias;
            dataTable.Rows.Add(fila);

            return dataTable;
        }

        public Partida PartidaSeleccionada
        {
            get
            {
                return this.partidaSeleccionada;
            }
        }

    }
}
