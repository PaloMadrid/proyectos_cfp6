namespace Formularios
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
            btn_cancelar = new Button();
            btn_agregar = new Button();
            gpb_programas = new GroupBox();
            cb_avast = new CheckBox();
            cb_dropbox = new CheckBox();
            cb_office = new CheckBox();
            cb_winrar = new CheckBox();
            cb_adobe = new CheckBox();
            gpb_so = new GroupBox();
            rb_macos = new RadioButton();
            rb_linux = new RadioButton();
            rb_windows = new RadioButton();
            gpb_datos = new GroupBox();
            cmbx_procesador = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            label5 = new Label();
            label4 = new Label();
            num_numeroDeSerie = new NumericUpDown();
            label1 = new Label();
            num_ram = new NumericUpDown();
            num_disco = new NumericUpDown();
            gpb_programas.SuspendLayout();
            gpb_so.SuspendLayout();
            gpb_datos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)num_numeroDeSerie).BeginInit();
            ((System.ComponentModel.ISupportInitialize)num_ram).BeginInit();
            ((System.ComponentModel.ISupportInitialize)num_disco).BeginInit();
            SuspendLayout();
            // 
            // btn_cancelar
            // 
            btn_cancelar.Location = new Point(306, 414);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(75, 23);
            btn_cancelar.TabIndex = 9;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.UseVisualStyleBackColor = true;
            btn_cancelar.Click += btn_cancelar_Click;
            // 
            // btn_agregar
            // 
            btn_agregar.Location = new Point(440, 414);
            btn_agregar.Name = "btn_agregar";
            btn_agregar.Size = new Size(75, 23);
            btn_agregar.TabIndex = 8;
            btn_agregar.Text = "Agregar";
            btn_agregar.UseVisualStyleBackColor = true;
            btn_agregar.Click += btn_agregar_Click;
            // 
            // gpb_programas
            // 
            gpb_programas.Controls.Add(cb_avast);
            gpb_programas.Controls.Add(cb_dropbox);
            gpb_programas.Controls.Add(cb_office);
            gpb_programas.Controls.Add(cb_winrar);
            gpb_programas.Controls.Add(cb_adobe);
            gpb_programas.Location = new Point(461, 180);
            gpb_programas.Name = "gpb_programas";
            gpb_programas.Size = new Size(298, 176);
            gpb_programas.TabIndex = 13;
            gpb_programas.TabStop = false;
            gpb_programas.Text = "Programas";
            // 
            // cb_avast
            // 
            cb_avast.AutoSize = true;
            cb_avast.Location = new Point(13, 130);
            cb_avast.Name = "cb_avast";
            cb_avast.Size = new Size(55, 19);
            cb_avast.TabIndex = 4;
            cb_avast.Text = "Avast";
            cb_avast.UseVisualStyleBackColor = true;
            // 
            // cb_dropbox
            // 
            cb_dropbox.AutoSize = true;
            cb_dropbox.Location = new Point(13, 105);
            cb_dropbox.Name = "cb_dropbox";
            cb_dropbox.Size = new Size(72, 19);
            cb_dropbox.TabIndex = 3;
            cb_dropbox.Text = "Dropbox";
            cb_dropbox.UseVisualStyleBackColor = true;
            // 
            // cb_office
            // 
            cb_office.AutoSize = true;
            cb_office.Location = new Point(13, 30);
            cb_office.Name = "cb_office";
            cb_office.Size = new Size(58, 19);
            cb_office.TabIndex = 0;
            cb_office.Text = "Office";
            cb_office.UseVisualStyleBackColor = true;
            // 
            // cb_winrar
            // 
            cb_winrar.AutoSize = true;
            cb_winrar.Location = new Point(13, 80);
            cb_winrar.Name = "cb_winrar";
            cb_winrar.Size = new Size(61, 19);
            cb_winrar.TabIndex = 2;
            cb_winrar.Text = "Winrar";
            cb_winrar.UseVisualStyleBackColor = true;
            // 
            // cb_adobe
            // 
            cb_adobe.AutoSize = true;
            cb_adobe.Location = new Point(13, 55);
            cb_adobe.Name = "cb_adobe";
            cb_adobe.Size = new Size(100, 19);
            cb_adobe.TabIndex = 1;
            cb_adobe.Text = "Adobe Reader";
            cb_adobe.UseVisualStyleBackColor = true;
            // 
            // gpb_so
            // 
            gpb_so.Controls.Add(rb_macos);
            gpb_so.Controls.Add(rb_linux);
            gpb_so.Controls.Add(rb_windows);
            gpb_so.Location = new Point(461, 13);
            gpb_so.Name = "gpb_so";
            gpb_so.Size = new Size(298, 161);
            gpb_so.TabIndex = 12;
            gpb_so.TabStop = false;
            gpb_so.Text = "Sistema Operativo";
            // 
            // rb_macos
            // 
            rb_macos.AutoSize = true;
            rb_macos.Location = new Point(13, 94);
            rb_macos.Name = "rb_macos";
            rb_macos.Size = new Size(63, 19);
            rb_macos.TabIndex = 2;
            rb_macos.TabStop = true;
            rb_macos.Text = "MacOS";
            rb_macos.UseVisualStyleBackColor = false;
            // 
            // rb_linux
            // 
            rb_linux.AutoSize = true;
            rb_linux.Location = new Point(13, 62);
            rb_linux.Name = "rb_linux";
            rb_linux.Size = new Size(54, 19);
            rb_linux.TabIndex = 1;
            rb_linux.TabStop = true;
            rb_linux.Text = "Linux";
            rb_linux.UseVisualStyleBackColor = true;
            // 
            // rb_windows
            // 
            rb_windows.AutoSize = true;
            rb_windows.Location = new Point(13, 32);
            rb_windows.Name = "rb_windows";
            rb_windows.Size = new Size(74, 19);
            rb_windows.TabIndex = 0;
            rb_windows.TabStop = true;
            rb_windows.Text = "Windows";
            rb_windows.UseVisualStyleBackColor = true;
            // 
            // gpb_datos
            // 
            gpb_datos.Controls.Add(cmbx_procesador);
            gpb_datos.Controls.Add(label3);
            gpb_datos.Controls.Add(label2);
            gpb_datos.Controls.Add(label5);
            gpb_datos.Controls.Add(label4);
            gpb_datos.Controls.Add(num_numeroDeSerie);
            gpb_datos.Controls.Add(label1);
            gpb_datos.Controls.Add(num_ram);
            gpb_datos.Controls.Add(num_disco);
            gpb_datos.Location = new Point(41, 30);
            gpb_datos.Name = "gpb_datos";
            gpb_datos.Size = new Size(340, 224);
            gpb_datos.TabIndex = 7;
            gpb_datos.TabStop = false;
            gpb_datos.Text = "Hardware";
            // 
            // cmbx_procesador
            // 
            cmbx_procesador.AccessibleDescription = "";
            cmbx_procesador.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbx_procesador.FormattingEnabled = true;
            cmbx_procesador.Location = new Point(123, 88);
            cmbx_procesador.Name = "cmbx_procesador";
            cmbx_procesador.Size = new Size(189, 23);
            cmbx_procesador.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 161);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 3;
            label3.Text = "Disco";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 125);
            label2.Name = "label2";
            label2.Size = new Size(82, 15);
            label2.TabIndex = 2;
            label2.Text = "Memoria Ram";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, -21);
            label5.Name = "label5";
            label5.Size = new Size(66, 15);
            label5.TabIndex = 1;
            label5.Text = "Procesador";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 55);
            label4.Name = "label4";
            label4.Size = new Size(95, 15);
            label4.TabIndex = 1;
            label4.Text = "Numero de Serie";
            // 
            // num_numeroDeSerie
            // 
            num_numeroDeSerie.Location = new Point(123, 53);
            num_numeroDeSerie.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            num_numeroDeSerie.Name = "num_numeroDeSerie";
            num_numeroDeSerie.Size = new Size(189, 23);
            num_numeroDeSerie.TabIndex = 1;
            num_numeroDeSerie.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 91);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 1;
            label1.Text = "Procesador";
            // 
            // num_ram
            // 
            num_ram.Location = new Point(123, 123);
            num_ram.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            num_ram.Name = "num_ram";
            num_ram.Size = new Size(189, 23);
            num_ram.TabIndex = 1;
            num_ram.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // num_disco
            // 
            num_disco.Location = new Point(123, 159);
            num_disco.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            num_disco.Name = "num_disco";
            num_disco.Size = new Size(189, 23);
            num_disco.TabIndex = 2;
            num_disco.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // FormCrear
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_cancelar);
            Controls.Add(btn_agregar);
            Controls.Add(gpb_programas);
            Controls.Add(gpb_so);
            Controls.Add(gpb_datos);
            Name = "FormCrear";
            Text = "FormCrear";
            Load += FormCrear_Load;
            gpb_programas.ResumeLayout(false);
            gpb_programas.PerformLayout();
            gpb_so.ResumeLayout(false);
            gpb_so.PerformLayout();
            gpb_datos.ResumeLayout(false);
            gpb_datos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)num_numeroDeSerie).EndInit();
            ((System.ComponentModel.ISupportInitialize)num_ram).EndInit();
            ((System.ComponentModel.ISupportInitialize)num_disco).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_cancelar;
        private Button btn_agregar;
        private GroupBox gpb_programas;
        private CheckBox cb_avast;
        private CheckBox cb_dropbox;
        private CheckBox cb_office;
        private CheckBox cb_winrar;
        private CheckBox cb_adobe;
        private GroupBox gpb_so;
        private RadioButton rb_macos;
        private RadioButton rb_linux;
        private RadioButton rb_windows;
        private GroupBox gpb_datos;
        private Label label3;
        private Label label2;
        private Label label1;
        private NumericUpDown num_disco;
        private ComboBox cmbx_procesador;
        private NumericUpDown num_ram;
        private Label label5;
        private Label label4;
        private NumericUpDown num_numeroDeSerie;
    }
}