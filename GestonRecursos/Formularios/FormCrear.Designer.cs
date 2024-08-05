namespace Mis_Forms
{
    partial class FormCrear
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
            picbox_fondo = new PictureBox();
            grbx_dificultad = new GroupBox();
            rb_dificil = new RadioButton();
            rb_medio = new RadioButton();
            rb_facil = new RadioButton();
            label1 = new Label();
            txbx_nombre = new TextBox();
            btn_crear = new Button();
            btn_cancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)picbox_fondo).BeginInit();
            grbx_dificultad.SuspendLayout();
            SuspendLayout();
            // 
            // picbox_fondo
            // 
            picbox_fondo.Location = new Point(0, -3);
            picbox_fondo.Name = "picbox_fondo";
            picbox_fondo.Size = new Size(248, 325);
            picbox_fondo.TabIndex = 0;
            picbox_fondo.TabStop = false;
            // 
            // grbx_dificultad
            // 
            grbx_dificultad.BackColor = Color.Black;
            grbx_dificultad.Controls.Add(rb_dificil);
            grbx_dificultad.Controls.Add(rb_medio);
            grbx_dificultad.Controls.Add(rb_facil);
            grbx_dificultad.Font = new Font("SimSun-ExtB", 14.25F, FontStyle.Bold);
            grbx_dificultad.ForeColor = SystemColors.Control;
            grbx_dificultad.Location = new Point(22, 102);
            grbx_dificultad.Name = "grbx_dificultad";
            grbx_dificultad.Size = new Size(200, 118);
            grbx_dificultad.TabIndex = 1;
            grbx_dificultad.TabStop = false;
            grbx_dificultad.Text = "Dificultad";
            // 
            // rb_dificil
            // 
            rb_dificil.AutoSize = true;
            rb_dificil.Location = new Point(15, 72);
            rb_dificil.Name = "rb_dificil";
            rb_dificil.Size = new Size(104, 23);
            rb_dificil.TabIndex = 2;
            rb_dificil.TabStop = true;
            rb_dificil.Text = "Dificil";
            rb_dificil.UseVisualStyleBackColor = true;
            // 
            // rb_medio
            // 
            rb_medio.AutoSize = true;
            rb_medio.Location = new Point(15, 47);
            rb_medio.Name = "rb_medio";
            rb_medio.Size = new Size(82, 23);
            rb_medio.TabIndex = 1;
            rb_medio.TabStop = true;
            rb_medio.Text = "Medio";
            rb_medio.UseVisualStyleBackColor = true;
            // 
            // rb_facil
            // 
            rb_facil.AutoSize = true;
            rb_facil.Location = new Point(15, 22);
            rb_facil.Name = "rb_facil";
            rb_facil.Size = new Size(82, 23);
            rb_facil.TabIndex = 0;
            rb_facil.TabStop = true;
            rb_facil.Text = "Facil";
            rb_facil.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.Font = new Font("SimSun-ExtB", 14.25F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(22, 21);
            label1.Name = "label1";
            label1.Size = new Size(75, 19);
            label1.TabIndex = 3;
            label1.Text = "Nombre";
            // 
            // txbx_nombre
            // 
            txbx_nombre.BackColor = Color.LightGray;
            txbx_nombre.Font = new Font("SimSun-ExtB", 14.25F, FontStyle.Bold);
            txbx_nombre.Location = new Point(22, 49);
            txbx_nombre.Name = "txbx_nombre";
            txbx_nombre.Size = new Size(200, 26);
            txbx_nombre.TabIndex = 0;
            // 
            // btn_crear
            // 
            btn_crear.BackColor = SystemColors.ActiveCaptionText;
            btn_crear.Font = new Font("SimSun-ExtB", 12F, FontStyle.Bold);
            btn_crear.ForeColor = SystemColors.ControlLightLight;
            btn_crear.Location = new Point(22, 231);
            btn_crear.Name = "btn_crear";
            btn_crear.Size = new Size(87, 79);
            btn_crear.TabIndex = 5;
            btn_crear.Text = "Crear Partida";
            btn_crear.UseVisualStyleBackColor = false;
            btn_crear.Click += btn_crear_Click;
            // 
            // btn_cancelar
            // 
            btn_cancelar.BackColor = SystemColors.ActiveCaptionText;
            btn_cancelar.Font = new Font("SimSun-ExtB", 12F, FontStyle.Bold);
            btn_cancelar.ForeColor = SystemColors.ControlLightLight;
            btn_cancelar.Location = new Point(126, 231);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(96, 79);
            btn_cancelar.TabIndex = 6;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.UseVisualStyleBackColor = false;
            btn_cancelar.Click += btn_cancelar_Click;
            // 
            // FormCrear
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(246, 322);
            Controls.Add(btn_cancelar);
            Controls.Add(btn_crear);
            Controls.Add(txbx_nombre);
            Controls.Add(label1);
            Controls.Add(grbx_dificultad);
            Controls.Add(picbox_fondo);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormCrear";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormCrear";
            Load += FormCrear_Load;
            ((System.ComponentModel.ISupportInitialize)picbox_fondo).EndInit();
            grbx_dificultad.ResumeLayout(false);
            grbx_dificultad.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picbox_fondo;
        private GroupBox grbx_dificultad;
        private RadioButton rb_dificil;
        private RadioButton rb_medio;
        private RadioButton rb_facil;
        private Label label1;
        private TextBox txbx_nombre;
        private Button btn_crear;
        private Button btn_cancelar;
    }
}