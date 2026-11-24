using System.ComponentModel;

namespace TallerMecanicoLosPinos
{
    public partial class Form1 : Form
    {

        private BindingList<RegistroServicio> registros =
        new BindingList<RegistroServicio>();

        public Form1()
        {
            InitializeComponent();

            ConfigurarDataGridView();


            try
            {
                registros = PersistenciaTxt.Cargar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cargar los registros: " + ex.Message
                );
            }

            dgvRegistros.DataSource = registros;


            btnAgregar.Click += btnAgregar_Click;
            btnEliminar.Click += btnEliminar_Click;
            btnLimpiar.Click += btnLimpiar_Click;
        }



        private void ConfigurarDataGridView()
        {
            dgvRegistros.AutoGenerateColumns = false;
            dgvRegistros.Columns.Clear();

            dgvRegistros.ReadOnly = true;
            dgvRegistros.AllowUserToAddRows = false;
            dgvRegistros.AllowUserToDeleteRows = false;
            dgvRegistros.MultiSelect = false;

            dgvRegistros.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvRegistros.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvRegistros.RowHeadersVisible = false;



            AgregarColumna("colCliente", "Cliente", "Cliente");
            AgregarColumna("colPatente", "Patente", "Patente");
            AgregarColumna("colVehiculo", "Vehículo", "Vehiculo");
            AgregarColumna("colServicio", "Servicio", "Servicio");
            AgregarColumna("colFecha", "Fecha", "Fecha");
            AgregarColumna(
                "colObservaciones",
                "Observaciones",
                "Observaciones"
            );

            dgvRegistros.Columns["colFecha"]
                .DefaultCellStyle.Format = "dd/MM/yyyy";
        }



        private void AgregarColumna(
            string nombre,
            string titulo,
            string propiedad)
        {
            DataGridViewTextBoxColumn columna =
                new DataGridViewTextBoxColumn();

            columna.Name = nombre;
            columna.HeaderText = titulo;
            columna.DataPropertyName = propiedad;

            dgvRegistros.Columns.Add(columna);
        }



        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCliente.Text) ||
                string.IsNullOrWhiteSpace(txtPatente.Text) ||
                string.IsNullOrWhiteSpace(txtVehiculo.Text) ||
                string.IsNullOrWhiteSpace(txtServicio.Text))
            {
                MessageBox.Show(
                    "Complete todos los campos obligatorios."
                );

                return;
            }


            RegistroServicio nuevoRegistro =
                new RegistroServicio();

            nuevoRegistro.Cliente = txtCliente.Text.Trim();
            nuevoRegistro.Patente = txtPatente.Text.Trim();
            nuevoRegistro.Vehiculo = txtVehiculo.Text.Trim();
            nuevoRegistro.Servicio = txtServicio.Text.Trim();
            nuevoRegistro.Fecha = dtpFecha.Value.Date;
            nuevoRegistro.Observaciones =
                txtObservaciones.Text.Trim();


            registros.Add(nuevoRegistro);


            if (GuardarRegistros())
            {
                MessageBox.Show(
                    "Registro agregado correctamente."
                );

                LimpiarCampos();
            }
            else
            {
                registros.Remove(nuevoRegistro);
            }
        }



        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvRegistros.SelectedRows.Count > 0)
            {
                int indice =
                    dgvRegistros.SelectedRows[0].Index;

                RegistroServicio eliminado =
                    registros[indice];

                registros.RemoveAt(indice);

                if (GuardarRegistros())
                {
                    MessageBox.Show(
                        "Registro eliminado correctamente."
                    );
                }
                else
                {
                    registros.Insert(indice, eliminado);
                }
            }
            else
            {
                MessageBox.Show(
                    "Seleccione un registro para eliminar."
                );
            }
        }



        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }



        private void LimpiarCampos()
        {
            txtCliente.Clear();
            txtPatente.Clear();
            txtVehiculo.Clear();
            txtServicio.Clear();
            txtObservaciones.Clear();

            dtpFecha.Value = DateTime.Today;

            txtCliente.Focus();
        }



        private bool GuardarRegistros()
        {
            try
            {
                PersistenciaTxt.Guardar(registros);

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No se pudieron guardar los registros.\n" +
                    ex.Message
                );

                return false;
            }
        }

        private void cmbservicio_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
