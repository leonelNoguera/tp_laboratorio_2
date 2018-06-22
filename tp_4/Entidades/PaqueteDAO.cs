using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;

namespace Entidades
{
    /*USE [correo-sp-2017]
    GO
    SET ANSI_NULLS ON
    GO
    SET QUOTED_IDENTIFIER ON
    GO
    SET ANSI_PADDING ON
    GO
    CREATE TABLE [dbo].[Paquetes](
    [id] [int] IDENTITY(1,1) NOT NULL,
    [direccionEntrega] [varchar](500) NOT NULL,
    [trackingID] [varchar](50) NOT NULL,
    [alumno] [varchar](50) NOT NULL,
    CONSTRAINT [PK_Paquetes] PRIMARY KEY CLUSTERED
    (
    [id] ASC
    )WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON,
    ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
    ) ON [PRIMARY]
    GO
    SET ANSI_PADDING OFF
    GO*/
    public static class PaqueteDAO
    {
        private static SqlCommand _comando;
        private static SqlConnection _conexion;

        public static Boolean Insertar(Paquete p)
        {
            bool todoOk = false;

            String sql = "INSERT INTO Personas (direccionEntrega, trackingID, alumno) VALUES(";
            sql = sql + "'" + p.DireccionEntrega + "','" + p.TrackingID+ "'," + "Noguera Marcelo" + ")";

            try
            {
                // LE PASO LA INSTRUCCION SQL
                PaqueteDAO._comando.CommandText = sql;

                // ABRO LA CONEXION A LA BD
                PaqueteDAO._conexion.Open();

                // EJECUTO EL COMMAND
                PaqueteDAO._comando.ExecuteNonQuery();

                todoOk = true;

            }
            catch (Exception)
            {
                todoOk = false;
            }
            finally
            {
                if (todoOk)
                    PaqueteDAO._conexion.Close();               
            }
            return todoOk;
 
        }

        static PaqueteDAO()
        {
            // CREO UN OBJETO SQLCONECTION
            PaqueteDAO._conexion = new SqlConnection(Properties.Settings.Default.MiConexion);
            // CREO UN OBJETO SQLCOMMAND
            PaqueteDAO._comando = new SqlCommand();
            // INDICO EL TIPO DE COMANDO
            PaqueteDAO._comando.CommandType = System.Data.CommandType.Text;
            // ESTABLEZCO LA CONEXION
            PaqueteDAO._comando.Connection = PaqueteDAO._conexion;
        }
    }
}
