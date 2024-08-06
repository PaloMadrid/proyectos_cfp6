namespace formularios
{
    partial class FormEscribir
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
            txbx_texto = new TextBox();
            label1 = new Label();
            btn_escribir = new Button();
            btn_cancelar = new Button();
            lst_lapiceras = new ListBox();
            lst_escritura = new ListBox();
            lbl_lapiceras = new Label();
            label2 = new Label();
            label3 = new Label();
            btn_recargar = new Button();
            SuspendLayout();
            // 
            // txbx_texto
            // 
            txbx_texto.Location = new Point(21, 166);
            txbx_texto.Name = "txbx_texto";
            txbx_texto.Size = new Size(767, 23);
            txbx_texto.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 148);
            label1.Name = "label1";
            label1.Size = new Size(148, 15);
            label1.TabIndex = 1;
            label1.Text = "Escriba el texto que quiera:";
            // 
            // btn_escribir
            // 
            btn_escribir.Location = new Point(161, 197);
            btn_escribir.Name = "btn_escribir";
            btn_escribir.Size = new Size(75, 23);
            btn_escribir.TabIndex = 2;
            btn_escribir.Text = "Escribir";
            btn_escribir.UseVisualStyleBackColor = true;
            btn_escribir.Click += btn_escribir_Click;
            // 
            // btn_cancelar
            // 
            btn_cancelar.Location = new Point(548, 197);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(75, 23);
            btn_cancelar.TabIndex = 3;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.UseVisualStyleBackColor = true;
            btn_cancelar.Click += btn_cancelar_Click;
            // 
            // lst_lapiceras
            // 
            lst_lapiceras.FormattingEnabled = true;
            lst_lapiceras.ItemHeight = 15;
            lst_lapiceras.Location = new Point(21, 25);
            lst_lapiceras.Name = "lst_lapiceras";
            lst_lapiceras.Size = new Size(377, 109);
            lst_lapiceras.TabIndex = 4;
            // 
            // lst_escritura
            // 
            lst_escritura.FormattingEnabled = true;
            lst_escritura.ItemHeight = 15;
            lst_escritura.Location = new Point(404, 25);
            lst_escritura.Name = "lst_escritura";
            lst_escritura.Size = new Size(384, 109);
            lst_escritura.TabIndex = 5;
            // 
            // lbl_lapiceras
            // 
            lbl_lapiceras.AutoSize = true;
            lbl_lapiceras.Location = new Point(21, 9);
            lbl_lapiceras.Name = "lbl_lapiceras";
            lbl_lapiceras.Size = new Size(56, 15);
            lbl_lapiceras.TabIndex = 6;
            lbl_lapiceras.Text = "Lapiceras";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(442, 7);
            label2.Name = "label2";
            label2.Size = new Size(120, 15);
            label2.TabIndex = 6;
            label2.Text = "Escrito por el usuario:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(-178, 148);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 1;
            label3.Text = "Recargar";
            label3.Click += label3_Click;
            // 
            // btn_recargar
            // 
            btn_recargar.Location = new Point(372, 197);
            btn_recargar.Name = "btn_recargar";
            btn_recargar.Size = new Size(75, 23);
            btn_recargar.TabIndex = 7;
            btn_recargar.Text = "Recargar";
            btn_recargar.UseVisualStyleBackColor = true;
            btn_recargar.Click += btn_recargar_Click;
            // 
            // FormEscribir
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 239);
            Controls.Add(btn_recargar);
            Controls.Add(label2);
            Controls.Add(lbl_lapiceras);
            Controls.Add(lst_escritura);
            Controls.Add(lst_lapiceras);
            Controls.Add(btn_cancelar);
            Controls.Add(label3);
            Controls.Add(btn_escribir);
            Controls.Add(label1);
            Controls.Add(txbx_texto);
            Name = "FormEscribir";
            Text = "FormEscribir";
            Load += FormEscribir_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txbx_texto;
        private Label label1;
        private Button btn_escribir;
        private Button btn_cancelar;
        private ListBox lst_lapiceras;
        private ListBox lst_escritura;
        private Label lbl_lapiceras;
        private Label label2;
        private Label label3;
        private Button btn_recargar;
    }
}