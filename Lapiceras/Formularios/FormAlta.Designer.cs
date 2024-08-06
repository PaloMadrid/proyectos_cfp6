namespace Formularios
{
    partial class FormAlta
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
            grbx_marca = new GroupBox();
            rb_pelikan = new RadioButton();
            rb_parker = new RadioButton();
            rb_filgo = new RadioButton();
            rb_fabbercastle = new RadioButton();
            rb_bic = new RadioButton();
            cbx_color = new ComboBox();
            btn_cancelar = new Button();
            btn_crear = new Button();
            label2 = new Label();
            label1 = new Label();
            grbx_lapicera = new GroupBox();
            tbx_precio = new TextBox();
            grbx_marca.SuspendLayout();
            grbx_lapicera.SuspendLayout();
            SuspendLayout();
            // 
            // grbx_marca
            // 
            grbx_marca.Controls.Add(rb_pelikan);
            grbx_marca.Controls.Add(rb_parker);
            grbx_marca.Controls.Add(rb_filgo);
            grbx_marca.Controls.Add(rb_fabbercastle);
            grbx_marca.Controls.Add(rb_bic);
            grbx_marca.Location = new Point(23, 131);
            grbx_marca.Name = "grbx_marca";
            grbx_marca.Size = new Size(200, 142);
            grbx_marca.TabIndex = 10;
            grbx_marca.TabStop = false;
            grbx_marca.Text = "Marca";
            // 
            // rb_pelikan
            // 
            rb_pelikan.AccessibleDescription = "";
            rb_pelikan.AutoSize = true;
            rb_pelikan.Location = new Point(15, 117);
            rb_pelikan.Name = "rb_pelikan";
            rb_pelikan.Size = new Size(63, 19);
            rb_pelikan.TabIndex = 4;
            rb_pelikan.Text = "Pelikan";
            rb_pelikan.UseVisualStyleBackColor = true;
            // 
            // rb_parker
            // 
            rb_parker.AccessibleDescription = "";
            rb_parker.AutoSize = true;
            rb_parker.Location = new Point(15, 92);
            rb_parker.Name = "rb_parker";
            rb_parker.Size = new Size(58, 19);
            rb_parker.TabIndex = 3;
            rb_parker.Text = "Parker";
            rb_parker.UseVisualStyleBackColor = true;
            // 
            // rb_filgo
            // 
            rb_filgo.AccessibleDescription = "";
            rb_filgo.AutoSize = true;
            rb_filgo.Location = new Point(15, 67);
            rb_filgo.Name = "rb_filgo";
            rb_filgo.Size = new Size(51, 19);
            rb_filgo.TabIndex = 2;
            rb_filgo.Text = "Filgo";
            rb_filgo.UseVisualStyleBackColor = true;
            // 
            // rb_fabbercastle
            // 
            rb_fabbercastle.AccessibleDescription = "";
            rb_fabbercastle.AutoSize = true;
            rb_fabbercastle.Location = new Point(15, 42);
            rb_fabbercastle.Name = "rb_fabbercastle";
            rb_fabbercastle.Size = new Size(93, 19);
            rb_fabbercastle.TabIndex = 1;
            rb_fabbercastle.Text = "FabberCastle";
            rb_fabbercastle.UseVisualStyleBackColor = true;
            // 
            // rb_bic
            // 
            rb_bic.AccessibleDescription = "";
            rb_bic.AutoSize = true;
            rb_bic.Location = new Point(15, 17);
            rb_bic.Name = "rb_bic";
            rb_bic.Size = new Size(41, 19);
            rb_bic.TabIndex = 0;
            rb_bic.Text = "Bic";
            rb_bic.UseVisualStyleBackColor = true;
            // 
            // cbx_color
            // 
            cbx_color.AccessibleDescription = "";
            cbx_color.DropDownStyle = ComboBoxStyle.DropDownList;
            cbx_color.FormattingEnabled = true;
            cbx_color.Location = new Point(85, 50);
            cbx_color.Name = "cbx_color";
            cbx_color.Size = new Size(121, 23);
            cbx_color.TabIndex = 8;
            // 
            // btn_cancelar
            // 
            btn_cancelar.Location = new Point(148, 286);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(75, 23);
            btn_cancelar.TabIndex = 12;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.UseVisualStyleBackColor = true;
            // 
            // btn_crear
            // 
            btn_crear.Location = new Point(23, 286);
            btn_crear.Name = "btn_crear";
            btn_crear.Size = new Size(75, 23);
            btn_crear.TabIndex = 11;
            btn_crear.Text = "Crear";
            btn_crear.UseVisualStyleBackColor = true;
            btn_crear.Click += btn_crear_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 89);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 9;
            label2.Text = "Precio";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 53);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 7;
            label1.Text = "Color";
            // 
            // grbx_lapicera
            // 
            grbx_lapicera.Controls.Add(tbx_precio);
            grbx_lapicera.Location = new Point(23, 25);
            grbx_lapicera.Name = "grbx_lapicera";
            grbx_lapicera.Size = new Size(200, 100);
            grbx_lapicera.TabIndex = 13;
            grbx_lapicera.TabStop = false;
            grbx_lapicera.Text = "Lapicera";
            // 
            // tbx_precio
            // 
            tbx_precio.AccessibleDescription = "";
            tbx_precio.Location = new Point(62, 61);
            tbx_precio.Name = "tbx_precio";
            tbx_precio.PlaceholderText = "Escriba un precio";
            tbx_precio.Size = new Size(121, 23);
            tbx_precio.TabIndex = 2;
            // 
            // FormAlta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(238, 328);
            Controls.Add(grbx_marca);
            Controls.Add(cbx_color);
            Controls.Add(btn_cancelar);
            Controls.Add(btn_crear);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(grbx_lapicera);
            Name = "FormAlta";
            Text = "FormAlta";
            Load += FormAlta_Load;
            grbx_marca.ResumeLayout(false);
            grbx_marca.PerformLayout();
            grbx_lapicera.ResumeLayout(false);
            grbx_lapicera.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grbx_marca;
        private RadioButton rb_pelikan;
        private RadioButton rb_parker;
        private RadioButton rb_filgo;
        private RadioButton rb_fabbercastle;
        private RadioButton rb_bic;
        private ComboBox cbx_color;
        private Button btn_cancelar;
        private Button btn_crear;
        private Label label2;
        private Label label1;
        private GroupBox grbx_lapicera;
        private TextBox tbx_precio;
    }
}