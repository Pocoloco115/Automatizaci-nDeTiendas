namespace AutomatizaciónDeTiendas.Formularios
{
    partial class Registrarse
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
            btnIngresar = new Button();
            btnCancelar = new Button();
            lblNombre = new Label();
            textBox1 = new TextBox();
            lblPassword = new Label();
            textBox2 = new TextBox();
            btnRegistrarse = new Button();
            SuspendLayout();
            // 
            // btnIngresar
            // 
            btnIngresar.Font = new Font("Unispace", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIngresar.Location = new Point(491, 291);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(94, 29);
            btnIngresar.TabIndex = 0;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Unispace", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.Location = new Point(157, 291);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 29);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Unispace", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombre.Location = new Point(230, 147);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(71, 18);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Nombre:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(357, 142);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 3;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Unispace", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPassword.Location = new Point(230, 188);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(107, 18);
            lblPassword.TabIndex = 5;
            lblPassword.Text = "Contraseña:";
            lblPassword.Click += lblPassword_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(357, 183);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 6;
            // 
            // btnRegistrarse
            // 
            btnRegistrarse.Font = new Font("Unispace", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrarse.Location = new Point(304, 291);
            btnRegistrarse.Name = "btnRegistrarse";
            btnRegistrarse.Size = new Size(134, 29);
            btnRegistrarse.TabIndex = 7;
            btnRegistrarse.Text = "Registrarse";
            btnRegistrarse.UseVisualStyleBackColor = true;
            // 
            // Registrarse
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRegistrarse);
            Controls.Add(textBox2);
            Controls.Add(lblPassword);
            Controls.Add(textBox1);
            Controls.Add(lblNombre);
            Controls.Add(btnCancelar);
            Controls.Add(btnIngresar);
            Name = "Registrarse";
            Text = "Registrarse";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnIngresar;
        private Button btnCancelar;
        private Label lblNombre;
        private TextBox textBox1;
        private Label lblPassword;
        private TextBox textBox2;
        private Button btnRegistrarse;
    }
}