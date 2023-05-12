using Neptuno2022EF.Entidades.Dtos.Cliente;
using Neptuno2022EF.Entidades.Entidades;
using Neptuno2022EF.Servicios.Interfaces;
using Neptuno2022EF.Windows.Helpers;
using NuevaAppComercial2022.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Neptuno2022EF.Windows
{
    public partial class frmVentaAE : Form
    {
        private readonly IServiciosClientes _servicioCliente;
        public frmVentaAE(IServiciosClientes servicioCliente)
        {
            InitializeComponent();
            _servicioCliente = servicioCliente;
        }
        private Venta venta;
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            CombosHelper.CargarComboClientes(ref cboClientes);
            CombosHelper.CargarComboCategorias(ref cboCategorias);
        }
        private void CancelarButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        private Cliente cliente;
        private void cboClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboClientes.SelectedIndex > 0)
            {
                var clienteDto = (ClienteListDto)cboClientes.SelectedItem;
                cliente = _servicioCliente.GetClientePorId(clienteDto.ClienteId);
                MostrarDatosCliente();
            }
            else
            {
                LimpiarDatosCliente();
                cliente = null;
            }
        }

        private void LimpiarDatosCliente()
        {
            txtDireccion.Clear();
            txtCiudad.Clear();
            txtPais.Clear();
            txtCodigoPostal.Clear();
        }

        private void MostrarDatosCliente()
        {
            txtDireccion.Text = cliente.Direccion;
            txtCiudad.Text = cliente.Ciudad.NombreCiudad;
            txtPais.Text = cliente.Pais.NombrePais;
            txtCodigoPostal.Text = cliente.CodPostal;
        }
    }
}
