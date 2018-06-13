using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Entidades;

namespace MainCorreo
{
    public partial class FrmPpal : Form
    {
        private void FrmPpal_Load(object sender, EventArgs e)
        {
            this.Text = "Correo UTN por Marcelo.Noguera.2A";
        }

        private void ActualizarEstados()
        {
            /*El método ActualizarEstados limpiará los 3 ListBox y luego recorrerá la lista de paquetes agregando
            cada uno de ellos en el listado que corresponda.*/
            lstEstadoIngresado.Text = "";
            lstEstadoEnViaje.Text = "";
            lstEstadoEntregado.Text = "";

            //lstEstadoIngresado.DataSource = ;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            /*El evento click del botón btnAgregar realizará las siguientes acciones en el siguiente orden:
            a. Creará un nuevo paquete y asociará al evento InformaEstado el método paq_InformaEstado.
            b. Agregará el paquete al correo, controlando las excepciones que puedan derivar de dicha
            acción.
            c. Llamará al método ActualizarEstados.*/
            Paquete p = new Paquete(txtDireccion.Text, mtxtTrackingID.Text);
            p.InformaEstado += new Paquete.DelegadoEstado(paq_InformaEstado);
        }

        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            //this.MostrarInformacion<List<Paquete>>((IMostrar<List<Paquete>>)correo);
        }

        /*protected override void Dispose(Boolean disposing)
        {

        }*/

        public FrmPpal()
        {
            InitializeComponent();
        }

        private void FrmPpal_FormClosing(Object sender, FormClosingEventArgs e)
        {
            
        }

        /*private void InitializeComponent()
        {

        }*/

        private void MostrarInformacion<T>(IMostrar<Paquete> elemento)
        {

        }

        private void mostrarToolStripMenuItem_Click(Object sender, EventArgs e)
        {
            this.MostrarInformacion<Paquete>((IMostrar<Paquete>)lstEstadoEntregado.SelectedItem);
        }

        private void paq_InformaEstado(Object sender, EventArgs e)
        {
            //paq_InformaEstado llamará al método ActualizarEstados en el ELSE del siguiente código
            if (this.InvokeRequired)
            {
                Paquete.DelegadoEstado d = new Paquete.DelegadoEstado(paq_InformaEstado);
                this.Invoke( d, new object[] {sender, e} );
            }
            else
            {
                this.ActualizarEstados();
            }
        }
    }
}
