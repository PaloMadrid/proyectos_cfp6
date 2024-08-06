namespace Formularios
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
            btn_recargar = new Button();
            label2 = new Label();
            lst_escritura = new ListBox();
            btn_cancelar = new Button();
            btn_escribir = new Button();
            txbx_texto = new TextBox();
            label1 = new Label();
            label3 = new Label();
            num_cantidad = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)num_cantidad).BeginInit();
            SuspendLayout();
            // 
            // btn_recargar
            // 
            btn_recargar.Location = new Point(570, 74);
            btn_recargar.Name = "btn_recargar";
            btn_recargar.Size = new Size(75, 23);
            btn_recargar.TabIndex = 13;
            btn_recargar.Text = "Recargar";
            btn_recargar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(59, 120);
            label2.Name = "label2";
            label2.Size = new Size(120, 15);
            label2.TabIndex = 12;
            label2.Text = "Escrito por el usuario:";
            // 
            // lst_escritura
            // 
            lst_escritura.FormattingEnabled = true;
            lst_escritura.ItemHeight = 15;
            lst_escritura.Location = new Point(22, 138);
            lst_escritura.Name = "lst_escritura";
            lst_escritura.Size = new Size(762, 94);
            lst_escritura.TabIndex = 11;
            // 
            // btn_cancelar
            // 
            btn_cancelar.Location = new Point(670, 74);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(75, 23);
            btn_cancelar.TabIndex = 10;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.UseVisualStyleBackColor = true;
            // 
            // btn_escribir
            // 
            btn_escribir.Location = new Point(473, 74);
            btn_escribir.Name = "btn_escribir";
            btn_escribir.Size = new Size(75, 23);
            btn_escribir.TabIndex = 9;
            btn_escribir.Text = "Escribir";
            btn_escribir.UseVisualStyleBackColor = true;
            btn_escribir.Click += btn_escribir_Click;
            // 
            // txbx_texto
            // 
            txbx_texto.Location = new Point(12, 31);
            txbx_texto.Name = "txbx_texto";
            txbx_texto.Size = new Size(767, 23);
            txbx_texto.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 9);
            label1.Name = "label1";
            label1.Size = new Size(88, 15);
            label1.TabIndex = 12;
            label1.Text = "Texto a escribir:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 78);
            label3.Name = "label3";
            label3.Size = new Size(182, 15);
            label3.TabIndex = 12;
            label3.Text = "O escriba cuantos caracteres son:";
            // 
            // num_cantidad
            // 
            num_cantidad.Location = new Point(200, 76);
            num_cantidad.Name = "num_cantidad";
            num_cantidad.Size = new Size(45, 23);
            num_cantidad.TabIndex = 14;
            // 
            // FormEscribir
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 244);
            Controls.Add(num_cantidad);
            Controls.Add(btn_recargar);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(lst_escritura);
            Controls.Add(btn_cancelar);
            Controls.Add(btn_escribir);
            Controls.Add(txbx_texto);
            Name = "FormEscribir";
            Text = "FormEscribir";
            Load += FormEscribir_Load;
            ((System.ComponentModel.ISupportInitialize)num_cantidad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_recargar;
        private Label label2;
        private ListBox lst_escritura;
        private Button btn_cancelar;
        private Button btn_escribir;
        private TextBox txbx_texto;
        private Label label1;
        private Label label3;
        private NumericUpDown num_cantidad;
    }
}