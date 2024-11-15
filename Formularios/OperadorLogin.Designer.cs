namespace AutomatizaciónDeTiendas.Formularios
{
    partial class OperadorLogin
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
            lblId = new Label();
            lblContraseña = new Label();
            txtId = new TextBox();
            txtPassword = new TextBox();
            btnIngresar = new Button();
            SuspendLayout();
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Unispace", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblId.Location = new Point(224, 119);
            lblId.Name = "lblId";
            lblId.Size = new Size(26, 18);
            lblId.TabIndex = 0;
            lblId.Text = "ID";
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Font = new Font("Unispace", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblContraseña.Location = new Point(224, 166);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(98, 18);
            lblContraseña.TabIndex = 1;
            lblContraseña.Text = "Contraseña";
            // 
            // txtId
            // 
            txtId.Font = new Font("Unispace", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtId.Location = new Point(360, 114);
            txtId.Name = "txtId";
            txtId.Size = new Size(125, 25);
            txtId.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = SystemColors.Window;
            txtPassword.Font = new Font("Unispace", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPassword.ForeColor = SystemColors.WindowText;
            txtPassword.Location = new Point(360, 161);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(125, 25);
            txtPassword.TabIndex = 3;
            // 
            // btnIngresar
            // 
            btnIngresar.Font = new Font("Unispace", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIngresar.Location = new Point(360, 262);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(94, 29);
            btnIngresar.TabIndex = 4;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // OperadorLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnIngresar);
            Controls.Add(txtPassword);
            Controls.Add(txtId);
            Controls.Add(lblContraseña);
            Controls.Add(lblId);
            Name = "OperadorLogin";
            Text = "OperadorLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblId;
        private Label lblContraseña;
        private TextBox txtId;
        private TextBox txtPassword;
        private Button btnIngresar;
    }
}