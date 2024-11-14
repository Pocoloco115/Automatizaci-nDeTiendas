namespace AutomatizaciónDeTiendas.Formularios
{
    partial class CrearCuenta
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
            lblNombre = new Label();
            lblPassword = new Label();
            txtNombre = new TextBox();
            txtPassword = new TextBox();
            lblConfirmacion = new Label();
            txtConfirmacion = new TextBox();
            txtId = new TextBox();
            btnCrearCuenta = new Button();
            btnGenerarId = new Button();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Unispace", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombre.Location = new Point(52, 66);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(71, 18);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre:";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Unispace", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPassword.Location = new Point(52, 105);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(107, 18);
            lblPassword.TabIndex = 1;
            lblPassword.Text = "Contraseña:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(264, 61);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 27);
            txtNombre.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(264, 100);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(125, 27);
            txtPassword.TabIndex = 3;
            // 
            // lblConfirmacion
            // 
            lblConfirmacion.AutoSize = true;
            lblConfirmacion.Font = new Font("Unispace", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblConfirmacion.Location = new Point(52, 150);
            lblConfirmacion.Name = "lblConfirmacion";
            lblConfirmacion.Size = new Size(215, 18);
            lblConfirmacion.TabIndex = 4;
            lblConfirmacion.Text = "Confirme su contraseña:";
            // 
            // txtConfirmacion
            // 
            txtConfirmacion.Location = new Point(264, 145);
            txtConfirmacion.Name = "txtConfirmacion";
            txtConfirmacion.Size = new Size(125, 27);
            txtConfirmacion.TabIndex = 5;
            // 
            // txtId
            // 
            txtId.Location = new Point(264, 196);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(125, 27);
            txtId.TabIndex = 7;
            // 
            // btnCrearCuenta
            // 
            btnCrearCuenta.BackColor = SystemColors.ActiveBorder;
            btnCrearCuenta.Font = new Font("Unispace", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCrearCuenta.Location = new Point(287, 297);
            btnCrearCuenta.Name = "btnCrearCuenta";
            btnCrearCuenta.Size = new Size(218, 83);
            btnCrearCuenta.TabIndex = 8;
            btnCrearCuenta.Text = "Crear cuenta";
            btnCrearCuenta.UseVisualStyleBackColor = false;
            btnCrearCuenta.Click += btnCrearCuenta_Click;
            // 
            // btnGenerarId
            // 
            btnGenerarId.BackColor = SystemColors.ActiveCaption;
            btnGenerarId.Font = new Font("Unispace", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGenerarId.Location = new Point(52, 196);
            btnGenerarId.Name = "btnGenerarId";
            btnGenerarId.Size = new Size(127, 29);
            btnGenerarId.TabIndex = 9;
            btnGenerarId.Text = "Generar Id";
            btnGenerarId.UseVisualStyleBackColor = false;
            btnGenerarId.Click += btnGenerarId_Click;
            // 
            // CrearCuenta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnGenerarId);
            Controls.Add(btnCrearCuenta);
            Controls.Add(txtId);
            Controls.Add(txtConfirmacion);
            Controls.Add(lblConfirmacion);
            Controls.Add(txtPassword);
            Controls.Add(txtNombre);
            Controls.Add(lblPassword);
            Controls.Add(lblNombre);
            Name = "CrearCuenta";
            Text = "CrearCuenta";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private Label lblPassword;
        private TextBox txtNombre;
        private TextBox txtPassword;
        private Label lblConfirmacion;
        private TextBox txtConfirmacion;
        private TextBox txtId;
        private Button btnCrearCuenta;
        private Button btnGenerarId;
    }
}