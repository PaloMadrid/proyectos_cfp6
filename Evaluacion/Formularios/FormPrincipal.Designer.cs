namespace Formularios
{
    partial class FormPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_mostrar = new Button();
            btn_agregar = new Button();
            dtg_computadoras = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dtg_computadoras).BeginInit();
            SuspendLayout();
            // 
            // btn_mostrar
            // 
            btn_mostrar.Location = new Point(430, 402);
            btn_mostrar.Name = "btn_mostrar";
            btn_mostrar.Size = new Size(75, 23);
            btn_mostrar.TabIndex = 4;
            btn_mostrar.Text = "Mostrar";
            btn_mostrar.UseVisualStyleBackColor = true;
            btn_mostrar.Click += btn_mostrar_Click;
            // 
            // btn_agregar
            // 
            btn_agregar.Location = new Point(317, 402);
            btn_agregar.Name = "btn_agregar";
            btn_agregar.Size = new Size(75, 23);
            btn_agregar.TabIndex = 5;
            btn_agregar.Text = "Agregar";
            btn_agregar.UseVisualStyleBackColor = true;
            btn_agregar.Click += btn_agregar_Click;
            // 
            // dtg_computadoras
            // 
            dtg_computadoras.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtg_computadoras.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_computadoras.Location = new Point(19, 26);
            dtg_computadoras.Name = "dtg_computadoras";
            dtg_computadoras.Size = new Size(762, 339);
            dtg_computadoras.TabIndex = 2;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_mostrar);
            Controls.Add(btn_agregar);
            Controls.Add(dtg_computadoras);
            Name = "FormPrincipal";
            Text = "Formulario Principal";
            Load += FormPrincipal_Load;
            ((System.ComponentModel.ISupportInitialize)dtg_computadoras).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btn_mostrar;
        private Button btn_agregar;
        private DataGridView dtg_computadoras;
    }
}
