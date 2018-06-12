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
    public class PaqueteDAO
    {
        private SqlCommand _comando;
        private SqlConnection _conexion;

        public Boolean Insertar(Paquete p)
        {
            /*// CREO UN OBJETO SQLCONECTION
            this._conexion = new SqlConnection(Properties.Settings.Default.CadenaConexion);
            // CREO UN OBJETO SQLCOMMAND
            this._comando = new SqlCommand();
            // INDICO EL TIPO DE COMANDO
            this._comando.CommandType = System.Data.CommandType.Text;
            // ESTABLEZCO LA CONEXION
            this._comando.Connection = this._conexion;*/
            return false;
        }

        private PaqueteDAO()
        {

        }
    }
}
