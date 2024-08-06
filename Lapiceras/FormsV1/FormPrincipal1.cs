using FormsV1;
using Mis_clases;

namespace FormsV1
{
    public partial class FormPrincipal1 : Form
    {
        private List<Lapicera> misLapiceras = new List<Lapicera>();
        public FormPrincipal1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            this.misLapiceras = Lapicera.ListaDeLapiceras();
            CargarDGV();

        }

        private void btn_mostrar_Click(object sender, EventArgs e)
        {
            CargarDGV();


        }

        private void CargarDGV()
        {

            //this.dtg_lapiceras.DataSource = null;
            //this.dtg_lapiceras.DataSource = this.misLapiceras;

        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            FormCrear1 formAlta = new FormCrear1();
            formAlta.ShowDialog();

            if (formAlta.DialogResult == DialogResult.OK)
            {
                Lapicera dato = formAlta.laLapicera;
                misLapiceras.Add(dato);

            }
        }

        private void btn_escribir_Click(object sender, EventArgs e)
        {
            //Lapicera seleccionada=(Lapicera)dtg_lapiceras.SelectedRows();

            FormEscribir1 formRedactar = new FormEscribir1();
            formRedactar.ShowDialog();



        }

        private void dtg_lapiceras_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
