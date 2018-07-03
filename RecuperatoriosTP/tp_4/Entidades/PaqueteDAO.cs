using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;

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

            PaqueteDAO._comando.Connection = PaqueteDAO._conexion;

            try
            {
                // ABRO LA CONEXION A LA BD
                PaqueteDAO._conexion.Open();

                // LE PASO LA INSTRUCCION SQL
                PaqueteDAO._comando = new SqlCommand("INSERT INTO [correo-sp-2017].[dbo].[Paquetes]([direccionEntrega],[trackingID],[alumno]) VALUES(" + "'" + p.DireccionEntrega + "','" + p.TrackingID + "','" + "Noguera Marcelo'" + ")", PaqueteDAO._conexion);
                //INSERT INTO [correo-sp-2017].[dbo].[Paquetes]([direccionEntrega],[trackingID],[alumno]) VALUES('direccion','6442','Noguera Marcelo');

                // EJECUTO EL COMMAND
                if (PaqueteDAO._comando.ExecuteNonQuery() != 0)
                {
                    todoOk = true;
                }

            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (PaqueteDAO._conexion.State == ConnectionState.Open)
                {
                    PaqueteDAO._conexion.Close();               
                }
            }

            return todoOk;
 
        }

        static PaqueteDAO()
        {
            PaqueteDAO._conexion = new SqlConnection(Properties.Settings.Default.MiConexion);
        }
    }
}
