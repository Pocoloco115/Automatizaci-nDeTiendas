namespace AutomatizaciónDeTiendas
{
    partial class LogIn
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
            lblBienvenida = new Label();
            label1 = new Label();
            btnCliente = new Button();
            btnOperador = new Button();
            SuspendLayout();
            // 
            // lblBienvenida
            // 
            lblBienvenida.AutoSize = true;
            lblBienvenida.Font = new Font("Unispace", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBienvenida.Location = new Point(294, 131);
            lblBienvenida.Name = "lblBienvenida";
            lblBienvenida.Size = new Size(215, 18);
            lblBienvenida.TabIndex = 0;
            lblBienvenida.Text = "Bienvenido a Autotienda";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Unispace", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(317, 177);
            label1.Name = "label1";
            label1.Size = new Size(161, 18);
            label1.TabIndex = 1;
            label1.Text = "Selecciona tu rol";
            // 
            // btnCliente
            // 
            btnCliente.BackColor = SystemColors.ActiveBorder;
            btnCliente.Font = new Font("Unispace", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCliente.Location = new Point(207, 266);
            btnCliente.Name = "btnCliente";
            btnCliente.Size = new Size(94, 29);
            btnCliente.TabIndex = 2;
            btnCliente.Text = "Cliente";
            btnCliente.UseVisualStyleBackColor = false;
            btnCliente.Click += btnCliente_Click;
            // 
            // btnOperador
            // 
            btnOperador.BackColor = SystemColors.ActiveBorder;
            btnOperador.Font = new Font("Unispace", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOperador.Location = new Point(511, 266);
            btnOperador.Name = "btnOperador";
            btnOperador.Size = new Size(94, 29);
            btnOperador.TabIndex = 3;
            btnOperador.Text = "Operador";
            btnOperador.UseVisualStyleBackColor = false;
            btnOperador.Click += btnOperador_Click;
            // 
            // LogIn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnOperador);
            Controls.Add(btnCliente);
            Controls.Add(label1);
            Controls.Add(lblBienvenida);
            Name = "LogIn";
            Text = "Form1";
            Load += LogIn_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBienvenida;
        private Label label1;
        private Button btnCliente;
        private Button btnOperador;
    }
}
