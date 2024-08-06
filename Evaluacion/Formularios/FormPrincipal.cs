using Evaluacion;

namespace Formularios
{
    public partial class FormPrincipal : Form
    {
        private List<Computadora> misPcs;
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            misPcs = new List<Computadora>();
            CargarDTG();

        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            FormCrear formAlta = new FormCrear();
            formAlta.ShowDialog();

            if (formAlta.DialogResult == DialogResult.OK)
            {
                Computadora laPC = formAlta.MiPC;
                misPcs.Add(laPC);
                CargarDTG();

            }
        }
        private void btn_mostrar_Click(object sender, EventArgs e)
        {
            CargarDTG();
        }

        public void CargarDTG()
        {
            this.dtg_computadoras.DataSource = null;
            this.dtg_computadoras.DataSource = this.misPcs;

        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            if (dtg_computadoras.SelectedRows.Count == 1)
            {

                Computadora pcSeleccionada = (Computadora)dtg_computadoras.CurrentRow.DataBoundItem;

                //Computadora pcSeleccionada = (Computadora)dtg_computadoras.CurrentRow.DataBoundItem as Computadora;

                FormModificar formModificar = new FormModificar(pcSeleccionada);
                formModificar.ShowDialog();

                if (formModificar.DialogResult == DialogResult.OK)
                {
                    int index = this.misPcs.FindIndex(x => x.NumeroDeSerie == formModificar.MiPC.NumeroDeSerie);

                    this.misPcs[index] = formModificar.MiPC;
                }
            }

        }
    }
}
