namespace TallerMecanicoLosPinos.Forms
{
    partial class FormPrincipal
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
            tabPrincipal = new TabControl();
            tabClientes = new TabPage();
            btnLimpiarCliente = new Button();
            btnEliminarCliente = new Button();
            btnActualizarCliente = new Button();
            btnGuardarCliente = new Button();
            dgvClientes = new DataGridView();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtCorreoCliente = new TextBox();
            txtTelefonoCliente = new TextBox();
            txtNombreCliente = new TextBox();
            txtRutCliente = new TextBox();
            tabVehiculos = new TabPage();
            dgvVehiculos = new DataGridView();
            btnLimpiarVehiculo = new Button();
            btnEliminarVehiculo = new Button();
            btnActualizarVehiculo = new Button();
            btnGuardarVehiculo = new Button();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            nudAnioVehiculo = new NumericUpDown();
            txtModeloVehiculo = new TextBox();
            txtMarcaVehiculo = new TextBox();
            txtPatenteVehiculo = new TextBox();
            cmbClienteVehiculo = new ComboBox();
            tabOrdenes = new TabPage();
            label19 = new Label();
            dgvOrdenes = new DataGridView();
            btnBuscarOrden = new Button();
            btnCancelarOrden = new Button();
            btnCambiarEstado = new Button();
            btnCrearOrden = new Button();
            label18 = new Label();
            label17 = new Label();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            txtBuscarOrden = new TextBox();
            cmbFiltroEstado = new ComboBox();
            cmbNuevoEstado = new ComboBox();
            nudCostoEstimado = new NumericUpDown();
            txtMecanico = new TextBox();
            txtDiagnostico = new TextBox();
            txtDescripcionFalla = new TextBox();
            txtTipoServicio = new TextBox();
            cmbVehiculoOrden = new ComboBox();
            tabReportes = new TabPage();
            dgvReporteEstado = new DataGridView();
            btnActualizarReporte = new Button();
            label22 = new Label();
            label21 = new Label();
            label20 = new Label();
            lblOrdenesEntregadas = new Label();
            lblOrdenesActivas = new Label();
            lblTotalOrdenes = new Label();
            tabPrincipal.SuspendLayout();
            tabClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            tabVehiculos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVehiculos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudAnioVehiculo).BeginInit();
            tabOrdenes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrdenes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudCostoEstimado).BeginInit();
            tabReportes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReporteEstado).BeginInit();
            SuspendLayout();
            // 
            // tabPrincipal
            // 
            tabPrincipal.Controls.Add(tabClientes);
            tabPrincipal.Controls.Add(tabVehiculos);
            tabPrincipal.Controls.Add(tabOrdenes);
            tabPrincipal.Controls.Add(tabReportes);
            tabPrincipal.Dock = DockStyle.Fill;
            tabPrincipal.Location = new Point(0, 0);
            tabPrincipal.Name = "tabPrincipal";
            tabPrincipal.SelectedIndex = 0;
            tabPrincipal.Size = new Size(1182, 703);
            tabPrincipal.TabIndex = 0;
            // 
            // tabClientes
            // 
            tabClientes.Controls.Add(btnLimpiarCliente);
            tabClientes.Controls.Add(btnEliminarCliente);
            tabClientes.Controls.Add(btnActualizarCliente);
            tabClientes.Controls.Add(btnGuardarCliente);
            tabClientes.Controls.Add(dgvClientes);
            tabClientes.Controls.Add(label4);
            tabClientes.Controls.Add(label3);
            tabClientes.Controls.Add(label2);
            tabClientes.Controls.Add(label1);
            tabClientes.Controls.Add(txtCorreoCliente);
            tabClientes.Controls.Add(txtTelefonoCliente);
            tabClientes.Controls.Add(txtNombreCliente);
            tabClientes.Controls.Add(txtRutCliente);
            tabClientes.Location = new Point(4, 29);
            tabClientes.Name = "tabClientes";
            tabClientes.Padding = new Padding(3);
            tabClientes.Size = new Size(1174, 670);
            tabClientes.TabIndex = 0;
            tabClientes.Text = "Clientes";
            tabClientes.UseVisualStyleBackColor = true;
            // 
            // btnLimpiarCliente
            // 
            btnLimpiarCliente.Location = new Point(402, 155);
            btnLimpiarCliente.Name = "btnLimpiarCliente";
            btnLimpiarCliente.Size = new Size(94, 29);
            btnLimpiarCliente.TabIndex = 12;
            btnLimpiarCliente.Text = "Limpiar";
            btnLimpiarCliente.UseVisualStyleBackColor = true;
            // 
            // btnEliminarCliente
            // 
            btnEliminarCliente.Location = new Point(302, 155);
            btnEliminarCliente.Name = "btnEliminarCliente";
            btnEliminarCliente.Size = new Size(94, 29);
            btnEliminarCliente.TabIndex = 11;
            btnEliminarCliente.Text = "Eliminar";
            btnEliminarCliente.UseVisualStyleBackColor = true;
            // 
            // btnActualizarCliente
            // 
            btnActualizarCliente.Location = new Point(202, 155);
            btnActualizarCliente.Name = "btnActualizarCliente";
            btnActualizarCliente.Size = new Size(94, 29);
            btnActualizarCliente.TabIndex = 10;
            btnActualizarCliente.Text = "Actualizar";
            btnActualizarCliente.UseVisualStyleBackColor = true;
            // 
            // btnGuardarCliente
            // 
            btnGuardarCliente.Location = new Point(102, 155);
            btnGuardarCliente.Name = "btnGuardarCliente";
            btnGuardarCliente.Size = new Size(94, 29);
            btnGuardarCliente.TabIndex = 9;
            btnGuardarCliente.Text = "Guardar";
            btnGuardarCliente.UseVisualStyleBackColor = true;
            // 
            // dgvClientes
            // 
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Location = new Point(102, 190);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.RowHeadersWidth = 51;
            dgvClientes.Size = new Size(833, 436);
            dgvClientes.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(746, 64);
            label4.Name = "label4";
            label4.Size = new Size(54, 20);
            label4.TabIndex = 7;
            label4.Text = "Correo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(530, 64);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 6;
            label3.Text = "Teléfono";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(315, 64);
            label2.Name = "label2";
            label2.Size = new Size(132, 20);
            label2.TabIndex = 5;
            label2.Text = "Nombre completo";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(102, 64);
            label1.Name = "label1";
            label1.Size = new Size(31, 20);
            label1.TabIndex = 4;
            label1.Text = "Rut";
            // 
            // txtCorreoCliente
            // 
            txtCorreoCliente.Location = new Point(746, 87);
            txtCorreoCliente.Name = "txtCorreoCliente";
            txtCorreoCliente.Size = new Size(189, 27);
            txtCorreoCliente.TabIndex = 3;
            // 
            // txtTelefonoCliente
            // 
            txtTelefonoCliente.Location = new Point(530, 87);
            txtTelefonoCliente.Name = "txtTelefonoCliente";
            txtTelefonoCliente.Size = new Size(189, 27);
            txtTelefonoCliente.TabIndex = 2;
            // 
            // txtNombreCliente
            // 
            txtNombreCliente.Location = new Point(315, 87);
            txtNombreCliente.Name = "txtNombreCliente";
            txtNombreCliente.Size = new Size(189, 27);
            txtNombreCliente.TabIndex = 1;
            // 
            // txtRutCliente
            // 
            txtRutCliente.Location = new Point(102, 87);
            txtRutCliente.Name = "txtRutCliente";
            txtRutCliente.Size = new Size(184, 27);
            txtRutCliente.TabIndex = 0;
            // 
            // tabVehiculos
            // 
            tabVehiculos.Controls.Add(dgvVehiculos);
            tabVehiculos.Controls.Add(btnLimpiarVehiculo);
            tabVehiculos.Controls.Add(btnEliminarVehiculo);
            tabVehiculos.Controls.Add(btnActualizarVehiculo);
            tabVehiculos.Controls.Add(btnGuardarVehiculo);
            tabVehiculos.Controls.Add(label9);
            tabVehiculos.Controls.Add(label8);
            tabVehiculos.Controls.Add(label7);
            tabVehiculos.Controls.Add(label6);
            tabVehiculos.Controls.Add(label5);
            tabVehiculos.Controls.Add(nudAnioVehiculo);
            tabVehiculos.Controls.Add(txtModeloVehiculo);
            tabVehiculos.Controls.Add(txtMarcaVehiculo);
            tabVehiculos.Controls.Add(txtPatenteVehiculo);
            tabVehiculos.Controls.Add(cmbClienteVehiculo);
            tabVehiculos.Location = new Point(4, 29);
            tabVehiculos.Name = "tabVehiculos";
            tabVehiculos.Padding = new Padding(3);
            tabVehiculos.Size = new Size(1174, 670);
            tabVehiculos.TabIndex = 1;
            tabVehiculos.Text = "Vehículos";
            tabVehiculos.UseVisualStyleBackColor = true;
            // 
            // dgvVehiculos
            // 
            dgvVehiculos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVehiculos.Location = new Point(536, 161);
            dgvVehiculos.Name = "dgvVehiculos";
            dgvVehiculos.RowHeadersWidth = 51;
            dgvVehiculos.Size = new Size(630, 501);
            dgvVehiculos.TabIndex = 14;
            // 
            // btnLimpiarVehiculo
            // 
            btnLimpiarVehiculo.Location = new Point(390, 319);
            btnLimpiarVehiculo.Name = "btnLimpiarVehiculo";
            btnLimpiarVehiculo.Size = new Size(94, 29);
            btnLimpiarVehiculo.TabIndex = 13;
            btnLimpiarVehiculo.Text = "Limpiar";
            btnLimpiarVehiculo.UseVisualStyleBackColor = true;
            // 
            // btnEliminarVehiculo
            // 
            btnEliminarVehiculo.Location = new Point(390, 284);
            btnEliminarVehiculo.Name = "btnEliminarVehiculo";
            btnEliminarVehiculo.Size = new Size(94, 29);
            btnEliminarVehiculo.TabIndex = 12;
            btnEliminarVehiculo.Text = "Eliminar";
            btnEliminarVehiculo.UseVisualStyleBackColor = true;
            // 
            // btnActualizarVehiculo
            // 
            btnActualizarVehiculo.Location = new Point(390, 249);
            btnActualizarVehiculo.Name = "btnActualizarVehiculo";
            btnActualizarVehiculo.Size = new Size(94, 29);
            btnActualizarVehiculo.TabIndex = 11;
            btnActualizarVehiculo.Text = "Actualizar";
            btnActualizarVehiculo.UseVisualStyleBackColor = true;
            // 
            // btnGuardarVehiculo
            // 
            btnGuardarVehiculo.Location = new Point(390, 214);
            btnGuardarVehiculo.Name = "btnGuardarVehiculo";
            btnGuardarVehiculo.Size = new Size(94, 29);
            btnGuardarVehiculo.TabIndex = 10;
            btnGuardarVehiculo.Text = "Guardar";
            btnGuardarVehiculo.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(105, 423);
            label9.Name = "label9";
            label9.Size = new Size(36, 20);
            label9.TabIndex = 9;
            label9.Text = "Año";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(105, 352);
            label8.Name = "label8";
            label8.Size = new Size(61, 20);
            label8.TabIndex = 8;
            label8.Text = "Modelo";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(105, 282);
            label7.Name = "label7";
            label7.Size = new Size(50, 20);
            label7.TabIndex = 7;
            label7.Text = "Marca";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(105, 214);
            label6.Name = "label6";
            label6.Size = new Size(136, 20);
            label6.TabIndex = 6;
            label6.Text = "Patente del camión";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(105, 72);
            label5.Name = "label5";
            label5.Size = new Size(164, 20);
            label5.TabIndex = 5;
            label5.Text = "Seleccionar propietario";
            // 
            // nudAnioVehiculo
            // 
            nudAnioVehiculo.Location = new Point(105, 446);
            nudAnioVehiculo.Name = "nudAnioVehiculo";
            nudAnioVehiculo.Size = new Size(150, 27);
            nudAnioVehiculo.TabIndex = 4;
            // 
            // txtModeloVehiculo
            // 
            txtModeloVehiculo.Location = new Point(105, 375);
            txtModeloVehiculo.Name = "txtModeloVehiculo";
            txtModeloVehiculo.Size = new Size(125, 27);
            txtModeloVehiculo.TabIndex = 3;
            // 
            // txtMarcaVehiculo
            // 
            txtMarcaVehiculo.Location = new Point(105, 305);
            txtMarcaVehiculo.Name = "txtMarcaVehiculo";
            txtMarcaVehiculo.Size = new Size(125, 27);
            txtMarcaVehiculo.TabIndex = 2;
            // 
            // txtPatenteVehiculo
            // 
            txtPatenteVehiculo.Location = new Point(105, 237);
            txtPatenteVehiculo.Name = "txtPatenteVehiculo";
            txtPatenteVehiculo.Size = new Size(125, 27);
            txtPatenteVehiculo.TabIndex = 1;
            // 
            // cmbClienteVehiculo
            // 
            cmbClienteVehiculo.FormattingEnabled = true;
            cmbClienteVehiculo.Location = new Point(105, 95);
            cmbClienteVehiculo.Name = "cmbClienteVehiculo";
            cmbClienteVehiculo.Size = new Size(151, 28);
            cmbClienteVehiculo.TabIndex = 0;
            // 
            // tabOrdenes
            // 
            tabOrdenes.Controls.Add(label19);
            tabOrdenes.Controls.Add(dgvOrdenes);
            tabOrdenes.Controls.Add(btnBuscarOrden);
            tabOrdenes.Controls.Add(btnCancelarOrden);
            tabOrdenes.Controls.Add(btnCambiarEstado);
            tabOrdenes.Controls.Add(btnCrearOrden);
            tabOrdenes.Controls.Add(label18);
            tabOrdenes.Controls.Add(label17);
            tabOrdenes.Controls.Add(label16);
            tabOrdenes.Controls.Add(label15);
            tabOrdenes.Controls.Add(label14);
            tabOrdenes.Controls.Add(label13);
            tabOrdenes.Controls.Add(label12);
            tabOrdenes.Controls.Add(label11);
            tabOrdenes.Controls.Add(label10);
            tabOrdenes.Controls.Add(txtBuscarOrden);
            tabOrdenes.Controls.Add(cmbFiltroEstado);
            tabOrdenes.Controls.Add(cmbNuevoEstado);
            tabOrdenes.Controls.Add(nudCostoEstimado);
            tabOrdenes.Controls.Add(txtMecanico);
            tabOrdenes.Controls.Add(txtDiagnostico);
            tabOrdenes.Controls.Add(txtDescripcionFalla);
            tabOrdenes.Controls.Add(txtTipoServicio);
            tabOrdenes.Controls.Add(cmbVehiculoOrden);
            tabOrdenes.Location = new Point(4, 29);
            tabOrdenes.Name = "tabOrdenes";
            tabOrdenes.Padding = new Padding(3);
            tabOrdenes.Size = new Size(1174, 670);
            tabOrdenes.TabIndex = 2;
            tabOrdenes.Text = "Órdenes de Servicios";
            tabOrdenes.UseVisualStyleBackColor = true;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(571, 277);
            label19.Name = "label19";
            label19.Size = new Size(101, 20);
            label19.TabIndex = 23;
            label19.Text = "Lista: Ordenes";
            // 
            // dgvOrdenes
            // 
            dgvOrdenes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrdenes.Location = new Point(571, 300);
            dgvOrdenes.Name = "dgvOrdenes";
            dgvOrdenes.RowHeadersWidth = 51;
            dgvOrdenes.Size = new Size(595, 362);
            dgvOrdenes.TabIndex = 22;
            // 
            // btnBuscarOrden
            // 
            btnBuscarOrden.Location = new Point(422, 588);
            btnBuscarOrden.Name = "btnBuscarOrden";
            btnBuscarOrden.Size = new Size(94, 29);
            btnBuscarOrden.TabIndex = 21;
            btnBuscarOrden.Text = "Buscar";
            btnBuscarOrden.UseVisualStyleBackColor = true;
            // 
            // btnCancelarOrden
            // 
            btnCancelarOrden.Location = new Point(422, 398);
            btnCancelarOrden.Name = "btnCancelarOrden";
            btnCancelarOrden.Size = new Size(143, 29);
            btnCancelarOrden.TabIndex = 20;
            btnCancelarOrden.Text = "Cancelar orden";
            btnCancelarOrden.UseVisualStyleBackColor = true;
            // 
            // btnCambiarEstado
            // 
            btnCambiarEstado.Location = new Point(571, 193);
            btnCambiarEstado.Name = "btnCambiarEstado";
            btnCambiarEstado.Size = new Size(143, 29);
            btnCambiarEstado.TabIndex = 19;
            btnCambiarEstado.Text = "Actualizar estado";
            btnCambiarEstado.UseVisualStyleBackColor = true;
            // 
            // btnCrearOrden
            // 
            btnCrearOrden.Location = new Point(448, 363);
            btnCrearOrden.Name = "btnCrearOrden";
            btnCrearOrden.Size = new Size(99, 29);
            btnCrearOrden.TabIndex = 18;
            btnCrearOrden.Text = "Crear Orden";
            btnCrearOrden.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(1012, 228);
            label18.Name = "label18";
            label18.Size = new Size(119, 20);
            label18.TabIndex = 17;
            label18.Text = "Filtro por estado";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(571, 134);
            label17.Name = "label17";
            label17.Size = new Size(138, 20);
            label17.TabIndex = 16;
            label17.Text = "Estado al actualizar";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(36, 134);
            label16.Name = "label16";
            label16.Size = new Size(138, 20);
            label16.TabIndex = 15;
            label16.Text = "Seleccionar camión";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(225, 523);
            label15.Name = "label15";
            label15.Size = new Size(113, 20);
            label15.TabIndex = 14;
            label15.Text = "Costo estimado";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(422, 522);
            label14.Name = "label14";
            label14.Size = new Size(70, 20);
            label14.TabIndex = 13;
            label14.Text = "Buscador";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(36, 523);
            label13.Name = "label13";
            label13.Size = new Size(138, 20);
            label13.TabIndex = 12;
            label13.Text = "Mecánico asignado";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(36, 425);
            label12.Name = "label12";
            label12.Size = new Size(89, 20);
            label12.TabIndex = 11;
            label12.Text = "Diagnostico";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(36, 341);
            label11.Name = "label11";
            label11.Size = new Size(157, 20);
            label11.TabIndex = 10;
            label11.Text = "Descripcion de la falla";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(36, 262);
            label10.Name = "label10";
            label10.Size = new Size(116, 20);
            label10.TabIndex = 9;
            label10.Text = "Tipo de Servicio";
            // 
            // txtBuscarOrden
            // 
            txtBuscarOrden.Location = new Point(422, 545);
            txtBuscarOrden.Name = "txtBuscarOrden";
            txtBuscarOrden.Size = new Size(125, 27);
            txtBuscarOrden.TabIndex = 8;
            // 
            // cmbFiltroEstado
            // 
            cmbFiltroEstado.FormattingEnabled = true;
            cmbFiltroEstado.Location = new Point(1012, 251);
            cmbFiltroEstado.Name = "cmbFiltroEstado";
            cmbFiltroEstado.Size = new Size(151, 28);
            cmbFiltroEstado.TabIndex = 7;
            // 
            // cmbNuevoEstado
            // 
            cmbNuevoEstado.FormattingEnabled = true;
            cmbNuevoEstado.Location = new Point(571, 159);
            cmbNuevoEstado.Name = "cmbNuevoEstado";
            cmbNuevoEstado.Size = new Size(151, 28);
            cmbNuevoEstado.TabIndex = 6;
            // 
            // nudCostoEstimado
            // 
            nudCostoEstimado.Location = new Point(225, 546);
            nudCostoEstimado.Name = "nudCostoEstimado";
            nudCostoEstimado.Size = new Size(150, 27);
            nudCostoEstimado.TabIndex = 5;
            // 
            // txtMecanico
            // 
            txtMecanico.Location = new Point(36, 546);
            txtMecanico.Name = "txtMecanico";
            txtMecanico.Size = new Size(125, 27);
            txtMecanico.TabIndex = 4;
            // 
            // txtDiagnostico
            // 
            txtDiagnostico.Location = new Point(36, 448);
            txtDiagnostico.Multiline = true;
            txtDiagnostico.Name = "txtDiagnostico";
            txtDiagnostico.Size = new Size(337, 34);
            txtDiagnostico.TabIndex = 3;
            // 
            // txtDescripcionFalla
            // 
            txtDescripcionFalla.Location = new Point(36, 364);
            txtDescripcionFalla.Multiline = true;
            txtDescripcionFalla.Name = "txtDescripcionFalla";
            txtDescripcionFalla.Size = new Size(337, 34);
            txtDescripcionFalla.TabIndex = 2;
            // 
            // txtTipoServicio
            // 
            txtTipoServicio.Location = new Point(36, 285);
            txtTipoServicio.Name = "txtTipoServicio";
            txtTipoServicio.Size = new Size(337, 27);
            txtTipoServicio.TabIndex = 1;
            // 
            // cmbVehiculoOrden
            // 
            cmbVehiculoOrden.FormattingEnabled = true;
            cmbVehiculoOrden.Location = new Point(36, 159);
            cmbVehiculoOrden.Name = "cmbVehiculoOrden";
            cmbVehiculoOrden.Size = new Size(151, 28);
            cmbVehiculoOrden.TabIndex = 0;
            // 
            // tabReportes
            // 
            tabReportes.Controls.Add(dgvReporteEstado);
            tabReportes.Controls.Add(btnActualizarReporte);
            tabReportes.Controls.Add(label22);
            tabReportes.Controls.Add(label21);
            tabReportes.Controls.Add(label20);
            tabReportes.Controls.Add(lblOrdenesEntregadas);
            tabReportes.Controls.Add(lblOrdenesActivas);
            tabReportes.Controls.Add(lblTotalOrdenes);
            tabReportes.Location = new Point(4, 29);
            tabReportes.Name = "tabReportes";
            tabReportes.Padding = new Padding(3);
            tabReportes.Size = new Size(1174, 670);
            tabReportes.TabIndex = 3;
            tabReportes.Text = "Reportes";
            tabReportes.UseVisualStyleBackColor = true;
            // 
            // dgvReporteEstado
            // 
            dgvReporteEstado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReporteEstado.Location = new Point(572, 61);
            dgvReporteEstado.Name = "dgvReporteEstado";
            dgvReporteEstado.RowHeadersWidth = 51;
            dgvReporteEstado.Size = new Size(594, 396);
            dgvReporteEstado.TabIndex = 7;
            // 
            // btnActualizarReporte
            // 
            btnActualizarReporte.Location = new Point(349, 141);
            btnActualizarReporte.Name = "btnActualizarReporte";
            btnActualizarReporte.Size = new Size(150, 29);
            btnActualizarReporte.TabIndex = 6;
            btnActualizarReporte.Text = "Actualizar reportes";
            btnActualizarReporte.UseVisualStyleBackColor = true;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(31, 229);
            label22.Name = "label22";
            label22.Size = new Size(145, 20);
            label22.TabIndex = 5;
            label22.Text = "Órdenes entregadas:";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(31, 159);
            label21.Name = "label21";
            label21.Size = new Size(116, 20);
            label21.TabIndex = 4;
            label21.Text = "Órdenes activas:";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(31, 90);
            label20.Name = "label20";
            label20.Size = new Size(123, 20);
            label20.TabIndex = 3;
            label20.Text = "Total de órdenes:";
            // 
            // lblOrdenesEntregadas
            // 
            lblOrdenesEntregadas.AutoSize = true;
            lblOrdenesEntregadas.Location = new Point(173, 229);
            lblOrdenesEntregadas.Name = "lblOrdenesEntregadas";
            lblOrdenesEntregadas.Size = new Size(17, 20);
            lblOrdenesEntregadas.TabIndex = 2;
            lblOrdenesEntregadas.Text = "0";
            // 
            // lblOrdenesActivas
            // 
            lblOrdenesActivas.AutoSize = true;
            lblOrdenesActivas.Location = new Point(153, 159);
            lblOrdenesActivas.Name = "lblOrdenesActivas";
            lblOrdenesActivas.Size = new Size(17, 20);
            lblOrdenesActivas.TabIndex = 1;
            lblOrdenesActivas.Text = "0";
            // 
            // lblTotalOrdenes
            // 
            lblTotalOrdenes.AutoSize = true;
            lblTotalOrdenes.Location = new Point(159, 90);
            lblTotalOrdenes.Name = "lblTotalOrdenes";
            lblTotalOrdenes.Size = new Size(17, 20);
            lblTotalOrdenes.TabIndex = 0;
            lblTotalOrdenes.Text = "0";
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 703);
            Controls.Add(tabPrincipal);
            Name = "FormPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormPrincipal";
            WindowState = FormWindowState.Minimized;
            tabPrincipal.ResumeLayout(false);
            tabClientes.ResumeLayout(false);
            tabClientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            tabVehiculos.ResumeLayout(false);
            tabVehiculos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVehiculos).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudAnioVehiculo).EndInit();
            tabOrdenes.ResumeLayout(false);
            tabOrdenes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrdenes).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudCostoEstimado).EndInit();
            tabReportes.ResumeLayout(false);
            tabReportes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReporteEstado).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabPrincipal;
        private TabPage tabClientes;
        private TabPage tabVehiculos;
        private TabPage tabOrdenes;
        private TabPage tabReportes;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtCorreoCliente;
        private TextBox txtTelefonoCliente;
        private TextBox txtNombreCliente;
        private TextBox txtRutCliente;
        private DataGridView dgvClientes;
        private NumericUpDown nudAnioVehiculo;
        private TextBox txtModeloVehiculo;
        private TextBox txtMarcaVehiculo;
        private TextBox txtPatenteVehiculo;
        private ComboBox cmbClienteVehiculo;
        private Button btnLimpiarCliente;
        private Button btnEliminarCliente;
        private Button btnActualizarCliente;
        private Button btnGuardarCliente;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Button btnLimpiarVehiculo;
        private Button btnEliminarVehiculo;
        private Button btnActualizarVehiculo;
        private Button btnGuardarVehiculo;
        private DataGridView dgvVehiculos;
        private TextBox txtMecanico;
        private TextBox txtDiagnostico;
        private TextBox txtDescripcionFalla;
        private TextBox txtTipoServicio;
        private ComboBox cmbVehiculoOrden;
        private TextBox txtBuscarOrden;
        private ComboBox cmbFiltroEstado;
        private ComboBox cmbNuevoEstado;
        private NumericUpDown nudCostoEstimado;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label18;
        private Label label17;
        private Label label16;
        private Label label15;
        private Label label19;
        private DataGridView dgvOrdenes;
        private Button btnBuscarOrden;
        private Button btnCancelarOrden;
        private Button btnCambiarEstado;
        private Button btnCrearOrden;
        private Label label21;
        private Label label20;
        private Label lblOrdenesEntregadas;
        private Label lblOrdenesActivas;
        private Label lblTotalOrdenes;
        private Label label22;
        private DataGridView dgvReporteEstado;
        private Button btnActualizarReporte;
    }
}