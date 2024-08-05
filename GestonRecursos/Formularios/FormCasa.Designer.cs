namespace Mis_Forms
{
    partial class FormCasa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCasa));
            btn_cancelar = new Button();
            dtg_partidaActual = new DataGridView();
            btn_salir = new Button();
            grbx_personajes = new GroupBox();
            cb_milena = new CheckBox();
            cb_elena = new CheckBox();
            cb_jonny = new CheckBox();
            cb_sonya = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)dtg_partidaActual).BeginInit();
            grbx_personajes.SuspendLayout();
            SuspendLayout();
            // 
            // btn_cancelar
            // 
            btn_cancelar.Location = new Point(342, 12);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(110, 51);
            btn_cancelar.TabIndex = 0;
            btn_cancelar.Text = "Volver";
            btn_cancelar.UseVisualStyleBackColor = true;
            btn_cancelar.Click += btn_cancelar_Click;
            // 
            // dtg_partidaActual
            // 
            dtg_partidaActual.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtg_partidaActual.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_partidaActual.Location = new Point(12, 12);
            dtg_partidaActual.Name = "dtg_partidaActual";
            dtg_partidaActual.Size = new Size(324, 51);
            dtg_partidaActual.TabIndex = 1;
            // 
            // btn_salir
            // 
            btn_salir.Location = new Point(497, 12);
            btn_salir.Name = "btn_salir";
            btn_salir.Size = new Size(110, 51);
            btn_salir.TabIndex = 0;
            btn_salir.Text = "Salir";
            btn_salir.UseVisualStyleBackColor = true;
            btn_salir.Click += btn_salir_Click;
            // 
            // grbx_personajes
            // 
            grbx_personajes.Controls.Add(cb_milena);
            grbx_personajes.Controls.Add(cb_elena);
            grbx_personajes.Controls.Add(cb_jonny);
            grbx_personajes.Controls.Add(cb_sonya);
            grbx_personajes.Location = new Point(32, 98);
            grbx_personajes.Name = "grbx_personajes";
            grbx_personajes.Size = new Size(200, 122);
            grbx_personajes.TabIndex = 2;
            grbx_personajes.TabStop = false;
            grbx_personajes.Text = "personajes disponibles";
            // 
            // cb_milena
            // 
            cb_milena.AutoSize = true;
            cb_milena.Location = new Point(27, 92);
            cb_milena.Name = "cb_milena";
            cb_milena.Size = new Size(62, 19);
            cb_milena.TabIndex = 3;
            cb_milena.Text = "Milena";
            cb_milena.UseVisualStyleBackColor = true;
            // 
            // cb_elena
            // 
            cb_elena.AutoSize = true;
            cb_elena.Location = new Point(27, 67);
            cb_elena.Name = "cb_elena";
            cb_elena.Size = new Size(73, 19);
            cb_elena.TabIndex = 2;
            cb_elena.Text = "Sub Zero";
            cb_elena.UseVisualStyleBackColor = true;
            // 
            // cb_jonny
            // 
            cb_jonny.AutoSize = true;
            cb_jonny.Location = new Point(27, 42);
            cb_jonny.Name = "cb_jonny";
            cb_jonny.Size = new Size(57, 19);
            cb_jonny.TabIndex = 1;
            cb_jonny.Text = "Jonny";
            cb_jonny.UseVisualStyleBackColor = true;
            // 
            // cb_sonya
            // 
            cb_sonya.AutoSize = true;
            cb_sonya.Location = new Point(27, 17);
            cb_sonya.Name = "cb_sonya";
            cb_sonya.Size = new Size(58, 19);
            cb_sonya.TabIndex = 0;
            cb_sonya.Text = "Sonya";
            cb_sonya.UseVisualStyleBackColor = true;
            // 
            // FormCasa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(919, 530);
            Controls.Add(grbx_personajes);
            Controls.Add(dtg_partidaActual);
            Controls.Add(btn_salir);
            Controls.Add(btn_cancelar);
            Name = "FormCasa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            Load += FormCasa_Load;
            ((System.ComponentModel.ISupportInitialize)dtg_partidaActual).EndInit();
            grbx_personajes.ResumeLayout(false);
            grbx_personajes.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_cancelar;
        private DataGridView dtg_partidaActual;
        private Button btn_salir;
        private GroupBox grbx_personajes;
        private CheckBox cb_milena;
        private CheckBox cb_elena;
        private CheckBox cb_jonny;
        private CheckBox cb_sonya;
    }
}
