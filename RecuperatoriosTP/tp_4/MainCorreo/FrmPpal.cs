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
        private Correo _correo = new Correo();

        private void FrmPpal_Load(object sender, EventArgs e)
        {
            this.Text = "Correo UTN por Marcelo.Noguera.2A";
        }

        private void ActualizarEstados()
        {
            /*El método ActualizarEstados limpiará los 3 ListBox y luego recorrerá la lista de paquetes agregando
            cada uno de ellos en el listado que corresponda.*/
            lstEstadoIngresado.Items.Clear();
            lstEstadoEnViaje.Items.Clear();
            lstEstadoEntregado.Items.Clear();

            foreach (Paquete item in this._correo.Paquetes)
            {
                switch (item.Estado)
                {
                    case Paquete.EEstado.Ingresado:
                        this.lstEstadoIngresado.Items.Add(item);
                        break;
                    case Paquete.EEstado.EnViaje:
                        this.lstEstadoEnViaje.Items.Add(item);
                        break;
                    case Paquete.EEstado.Entregado:
                        this.lstEstadoEntregado.Items.Add(item);
                        break;
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            /*El evento click del botón btnAgregar realizará las siguientes acciones en el siguiente orden:
            a. Creará un nuevo paquete y asociará al evento InformaEstado el método paq_InformaEstado.
            b. Agregará el paquete al correo, controlando las excepciones que puedan derivar de dicha
            acción.
            c. Llamará al método ActualizarEstados.*/
            Paquete p = new Paquete(this.txtDireccion.Text, this.mtxtTrackingID.Text);
            p.InformarEstado += this.paq_InformarEstado;

            try
            {
                this._correo += p;
            }
            catch (TrackingIdRepetidoException)
            {
                MessageBox.Show("El Tracking ID " + this.mtxtTrackingID.Text + " ya figura en la lista de envios.", "Paquete repetido");
            }
            this.ActualizarEstados();
        }

        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            this.MostrarInformacion<List<Paquete>>((IMostrar<List<Paquete>>)_correo);
        }

        public FrmPpal()
        {
            InitializeComponent();
        }

        private void FrmPpal_FormClosing(Object sender, FormClosingEventArgs e)
        {
            this._correo.FinEntregas();
        }

        private void MostrarInformacion<T>(IMostrar<T> elemento)
        {
            /*El método MostrarInformacion<T> evaluará que el atributo elemento no sea nulo y:
            a. Mostrará los datos de elemento en el rtbMostrar.
            b. Utilizará el método de extensión para guardar los datos en un archivo llamado salida.txt.*/
            if (elemento != null)
            {
                this.rtbMostrar.AppendText(elemento.MostrarDatos(elemento));
                GuardaString.Guardar(this.rtbMostrar.Text, "salida.txt");
            }
        }

        private void mostrarToolStripMenuItem_Click(Object sender, EventArgs e)
        {
            this.MostrarInformacion<Paquete>((IMostrar<Paquete>)lstEstadoEntregado.SelectedItem);
        }

        private void paq_InformarEstado(Object sender, EventArgs e)
        {
            //paq_InformaEstado llamará al método ActualizarEstados en el ELSE del siguiente código
            if (this.InvokeRequired)
            {
                Paquete.DelegadoEstado d = new Paquete.DelegadoEstado(paq_InformarEstado);
                this.Invoke( d, new object[] {sender, e} );
            }
            else
            {
                this.ActualizarEstados();
            }
        }

        private void mostrarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.MostrarInformacion<Paquete>((IMostrar<Paquete>)lstEstadoEntregado.SelectedItem);
        }
    }
}
