using Service.Services;
using Microsoft.Reporting.WinForms;
using Service.Interfaces;
using Service.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Desktop.Interfaces;
using Desktop.States.Clientes;

namespace KioscoInformaticoDesktop.Views
{
    public partial class ClientesView : Form
    {
        public IFormState initialDisplayState;
        public IFormState addState;
        public IFormState editState;
        public IFormState deleteState;
        public IFormState currentState;

        public IGenericService<Cliente> clienteService = new GenericService<Cliente>();
        public IGenericService<Localidad> localidadService = new GenericService<Localidad>();
        public BindingSource ListClientes = new BindingSource();
        public Cliente clienteCurrent;
        public ClientesView()
        {
            InitializeComponent();

            initialDisplayState = new InitialDisplayState(this);
            addState = new AddState(this);
            editState = new EditState(this);
            deleteState = new DeleteState(this);

            currentState = initialDisplayState;
            currentState.UpdateUI();
        }

        public void SetState(IFormState state)
        {
            currentState = state ?? throw new ArgumentNullException(nameof(state), "El estado no puede ser nulo");
        }
        private void iconButtonAgregar_Click(object sender, EventArgs e)
        {
            SetState(addState);
            currentState.OnAgregar();
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            currentState.OnGuardar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            currentState.OnCancelar();
        }

        private void iconButtOnModificarar_Click(object sender, EventArgs e)
        {
            SetState(editState);
            currentState.OnModificar();
        }

        private async void iconButtonEliminar_Click(object sender, EventArgs e)
        {
            SetState(deleteState);
            currentState.OnEliminar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            currentState.OnBuscar();

        }

        private void iconButtonSalir_Click(object sender, EventArgs e)
        {
            currentState.OnSalir();
        }

    }
}
