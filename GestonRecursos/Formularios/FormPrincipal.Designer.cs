namespace Mis_Forms
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            label1 = new Label();
            btn_nuevaPartida = new Button();
            btn_cargarPartida = new Button();
            btn_cerrar = new Button();
            dtg_partidas = new DataGridView();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dtg_partidas).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DarkGray;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("SimSun-ExtB", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(354, 54);
            label1.Name = "label1";
            label1.Size = new Size(226, 37);
            label1.TabIndex = 0;
            label1.Text = "El Jueguito";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_nuevaPartida
            // 
            btn_nuevaPartida.BackColor = SystemColors.ButtonShadow;
            btn_nuevaPartida.FlatStyle = FlatStyle.Popup;
            btn_nuevaPartida.Font = new Font("SimSun-ExtB", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_nuevaPartida.Location = new Point(59, 236);
            btn_nuevaPartida.Name = "btn_nuevaPartida";
            btn_nuevaPartida.Size = new Size(195, 47);
            btn_nuevaPartida.TabIndex = 1;
            btn_nuevaPartida.Text = "Nueva Partida";
            btn_nuevaPartida.TextAlign = ContentAlignment.MiddleLeft;
            btn_nuevaPartida.UseVisualStyleBackColor = false;
            btn_nuevaPartida.Click += btn_nuevaPartida_Click;
            // 
            // btn_cargarPartida
            // 
            btn_cargarPartida.BackColor = SystemColors.ButtonShadow;
            btn_cargarPartida.FlatStyle = FlatStyle.Popup;
            btn_cargarPartida.Font = new Font("SimSun-ExtB", 15.75F, FontStyle.Bold);
            btn_cargarPartida.Location = new Point(59, 302);
            btn_cargarPartida.Name = "btn_cargarPartida";
            btn_cargarPartida.Size = new Size(195, 44);
            btn_cargarPartida.TabIndex = 2;
            btn_cargarPartida.Text = "Cargar Partida";
            btn_cargarPartida.TextAlign = ContentAlignment.MiddleLeft;
            btn_cargarPartida.UseVisualStyleBackColor = false;
            btn_cargarPartida.Click += btn_cargarPartida_Click;
            // 
            // btn_cerrar
            // 
            btn_cerrar.BackColor = SystemColors.ButtonShadow;
            btn_cerrar.FlatStyle = FlatStyle.Popup;
            btn_cerrar.Font = new Font("SimSun-ExtB", 15.75F, FontStyle.Bold);
            btn_cerrar.Location = new Point(59, 367);
            btn_cerrar.Name = "btn_cerrar";
            btn_cerrar.Size = new Size(195, 44);
            btn_cerrar.TabIndex = 3;
            btn_cerrar.Text = "Cerrar";
            btn_cerrar.TextAlign = ContentAlignment.MiddleLeft;
            btn_cerrar.UseVisualStyleBackColor = false;
            btn_cerrar.Click += btn_cerrar_Click;
            // 
            // dtg_partidas
            // 
            dtg_partidas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtg_partidas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_partidas.Location = new Point(544, 261);
            dtg_partidas.Name = "dtg_partidas";
            dtg_partidas.Size = new Size(303, 175);
            dtg_partidas.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.DarkGray;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("SimSun-ExtB", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(544, 227);
            label2.Name = "label2";
            label2.Size = new Size(303, 31);
            label2.TabIndex = 0;
            label2.Text = "Partidas Guardadas";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(919, 530);
            Controls.Add(dtg_partidas);
            Controls.Add(btn_cerrar);
            Controls.Add(btn_cargarPartida);
            Controls.Add(btn_nuevaPartida);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormPrincipal";
            Load += FormPrincipal_Load;
            ((System.ComponentModel.ISupportInitialize)dtg_partidas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btn_nuevaPartida;
        private Button btn_cargarPartida;
        private Button btn_cerrar;
        private DataGridView dtg_partidas;
        private Label label2;
    }
}