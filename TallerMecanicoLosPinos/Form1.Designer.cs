namespace TallerMecanicoLosPinos
{
    partial class Form1
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
            label1 = new Label();
            txtCliente = new TextBox();
            txtPatente = new TextBox();
            txtVehiculo = new TextBox();
            txtServicio = new TextBox();
            txtObservaciones = new TextBox();
            dtpFecha = new DateTimePicker();
            dgvRegistros = new DataGridView();
            btnAgregar = new Button();
            btnEliminar = new Button();
            btnLimpiar = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            cmbservicio = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvRegistros).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(298, 9);
            label1.Name = "label1";
            label1.Size = new Size(143, 15);
            label1.TabIndex = 0;
            label1.Text = "Taller Mecanico Los Pinos";
            // 
            // txtCliente
            // 
            txtCliente.Location = new Point(88, 80);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(192, 23);
            txtCliente.TabIndex = 1;
            // 
            // txtPatente
            // 
            txtPatente.Location = new Point(512, 80);
            txtPatente.Name = "txtPatente";
            txtPatente.Size = new Size(192, 23);
            txtPatente.TabIndex = 2;
            // 
            // txtVehiculo
            // 
            txtVehiculo.Location = new Point(88, 149);
            txtVehiculo.Name = "txtVehiculo";
            txtVehiculo.Size = new Size(192, 23);
            txtVehiculo.TabIndex = 3;
            // 
            // txtServicio
            // 
            txtServicio.Location = new Point(512, 149);
            txtServicio.Name = "txtServicio";
            txtServicio.Size = new Size(192, 23);
            txtServicio.TabIndex = 4;
            // 
            // txtObservaciones
            // 
            txtObservaciones.Location = new Point(88, 257);
            txtObservaciones.Name = "txtObservaciones";
            txtObservaciones.Size = new Size(616, 23);
            txtObservaciones.TabIndex = 5;
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(88, 209);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(200, 23);
            dtpFecha.TabIndex = 6;
            // 
            // dgvRegistros
            // 
            dgvRegistros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRegistros.Location = new Point(88, 338);
            dgvRegistros.Name = "dgvRegistros";
            dgvRegistros.Size = new Size(616, 150);
            dgvRegistros.TabIndex = 7;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(88, 299);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 8;
            btnAgregar.Text = "agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(169, 299);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 9;
            btnEliminar.Text = "eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(250, 299);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 10;
            btnLimpiar.Text = "limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(88, 62);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 11;
            label2.Text = "Cliente";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(88, 131);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 12;
            label3.Text = "Vehiculo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(512, 62);
            label4.Name = "label4";
            label4.Size = new Size(47, 15);
            label4.TabIndex = 13;
            label4.Text = "Patente";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(512, 131);
            label5.Name = "label5";
            label5.Size = new Size(48, 15);
            label5.TabIndex = 14;
            label5.Text = "Servicio";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(88, 239);
            label6.Name = "label6";
            label6.Size = new Size(84, 15);
            label6.TabIndex = 15;
            label6.Text = "Observaciones";
            // 
            // cmbservicio
            // 
            cmbservicio.FormattingEnabled = true;
            cmbservicio.Items.AddRange(new object[] { "cambio de aceite", "mantenimiento", "revision de frenos", "revision motor" });
            cmbservicio.Location = new Point(512, 178);
            cmbservicio.Name = "cmbservicio";
            cmbservicio.Size = new Size(121, 23);
            cmbservicio.TabIndex = 16;
            cmbservicio.SelectedIndexChanged += cmbservicio_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 521);
            Controls.Add(cmbservicio);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnLimpiar);
            Controls.Add(btnEliminar);
            Controls.Add(btnAgregar);
            Controls.Add(dgvRegistros);
            Controls.Add(dtpFecha);
            Controls.Add(txtObservaciones);
            Controls.Add(txtServicio);
            Controls.Add(txtVehiculo);
            Controls.Add(txtPatente);
            Controls.Add(txtCliente);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvRegistros).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtCliente;
        private TextBox txtPatente;
        private TextBox txtVehiculo;
        private TextBox txtServicio;
        private TextBox txtObservaciones;
        private DateTimePicker dtpFecha;
        private DataGridView dgvRegistros;
        private Button btnAgregar;
        private Button btnEliminar;
        private Button btnLimpiar;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox cmbservicio;
    }
}
