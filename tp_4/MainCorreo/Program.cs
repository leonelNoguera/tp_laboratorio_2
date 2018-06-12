using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace MainCorreo
{
    static class Program
    {
        static void Main()
        {
            //String connectionStr = "Data Source=[Instancia Del Servidor];Initial Catalog=correo-sp-2017;Integrated Security=True";
            //SqlConnection conexion = new SqlConnection(connectionStr);



            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmPpal());
        }
    }
}
