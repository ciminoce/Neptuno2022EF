﻿using Neptuno2022EF.Entidades.Dtos.Cliente;
using Neptuno2022EF.Entidades.Dtos.Venta;
using Neptuno2022EF.Servicios.Interfaces;
using Neptuno2022EF.Windows.Helpers;
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
    public partial class frmVentas : Form
    {
        private readonly IServiciosVentas _servicio;
        private List<VentaListDto> lista;
        public frmVentas(IServiciosVentas servicio)
        {
            InitializeComponent();
            _servicio = servicio;
        }

        private void tsbCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmVentas_Load(object sender, EventArgs e)
        {
            try
            {
                lista = _servicio.GetVentas();
                MostrarDatosEnGrilla();
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void MostrarDatosEnGrilla()
        {
            GridHelper.LimpiarGrilla(dgvDatos);
            foreach (VentaListDto cliente in lista)
            {
                DataGridViewRow r = GridHelper.ConstruirFila(dgvDatos);
                GridHelper.SetearFila(r, cliente);
                GridHelper.AgregarFila(dgvDatos, r);
            }
        }

    }
}
