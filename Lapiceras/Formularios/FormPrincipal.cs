using Librerias;

namespace Formularios
{
    public partial class FormPrincipal : Form
    {
        List<Lapicera> lasLapiceras;
        Lapicera nuevaLapicera;
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            lasLapiceras = new List<Lapicera>();

            CargarDTG();
        }



        public void CargarDTG()
        {
            dtg_lapiceras.DataSource = null;
            dtg_lapiceras.DataSource = lasLapiceras;
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            FormAlta formAlta = new FormAlta();
            formAlta.ShowDialog();

            if (formAlta.DialogResult == DialogResult.OK)
            {
                this.nuevaLapicera = formAlta.LaLapicera;
                lasLapiceras.Add(nuevaLapicera);
                CargarDTG();
            }
        }

        private void btn_escribir_Click(object sender, EventArgs e)
        {
            Lapicera seleccionada= (Lapicera)dtg_lapiceras.CurrentRow.DataBoundItem;
            
            FormEscribir formModificar = new FormEscribir(seleccionada);
            formModificar.ShowDialog();

            if (formModificar.DialogResult == DialogResult.OK)
            {
                //int index = this.lasLapiceras.FindIndex(x => x.id == formModificar.MiPC.NumeroDeSerie);

                //this.lasLapiceras[index] = formModificar.MiPC;
            }
        }
    }
}
