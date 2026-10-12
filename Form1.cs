using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ClinicaSePriceApp
{
     partial class Form1 : Form
    {
        // Lista para almacenar los pacientes registrados en memoria
        private List<Paciente> listaPacientes = new List<Paciente>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string dni = txtDni.Text.Trim();
            string nombre = txtNombre.Text.Trim();
            string apellido = txtApellido.Text.Trim();
            string obraSocial = txtObraSocial.Text.Trim();

            if (string.IsNullOrEmpty(dni) || string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(apellido))
            {
                MessageBox.Show("Por favor, completa los campos obligatorios.", "Clínica SePrice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Paciente nuevoPaciente = new Paciente
            {
                Dni = dni,
                Nombre = nombre,
                Apellido = apellido,
                ObraSocial = obraSocial
            };

            listaPacientes.Add(nuevoPaciente);

            dgvPacientes.DataSource = null;
            dgvPacientes.DataSource = listaPacientes;

            txtDni.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtObraSocial.Clear();

            MessageBox.Show("¡Paciente registrado con éxito!", "Clínica SePrice", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}