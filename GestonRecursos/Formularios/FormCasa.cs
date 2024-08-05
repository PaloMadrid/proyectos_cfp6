using Librerias;
using System.Data;

namespace Mis_Forms
{
    public partial class FormCasa : Form
    {
        public FormCasa()
        {
            InitializeComponent();
        }

        private void FormCasa_Load(object sender, EventArgs e)
        {
            // Maximiza la ventana del form
            this.WindowState = FormWindowState.Maximized;


        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {            
            //cerrar todos los forms
            Application.Exit();
        }

        public void SetData(DataTable dataTable)
        {
            this.dtg_partidaActual.DataSource = dataTable;
        }
    }
}
