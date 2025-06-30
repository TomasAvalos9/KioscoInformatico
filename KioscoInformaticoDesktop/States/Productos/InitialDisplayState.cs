using Desktop.Interfaces;
using KioscoInformaticoDesktop.Views;
using Service.Interfaces;
using Service.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop.States.Productos
{
    public class InitialDisplayState : IFormState
    {
        ProductosView _form;
        public InitialDisplayState(ProductosView form) 
        {
            _form = form ?? throw new ArgumentNullException(nameof(form), "El formulario no puede ser nulo");
        }
      
        public async void OnBuscar()
        {
          await UpdateUI();
        }
        public async Task UpdateUI()
        {
            var productos = await _form.productoService.GetAllAsync(""); 
            _form.ListProductos.DataSource = productos;
            _form.dataGridProductosView.DataSource = _form.ListProductos;
            _form.tabControl.SelectTab(_form.tabPageLista);
        }
        public void OnSalir()
        {
            _form.Close();
        }

        public void OnCancelar() { }
        public void OnGuardar() { }
        public void OnAgregar() { }
        public void OnModificar() { }
        public void OnEliminar() { }

    }
}
