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

    }
}
