using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class GuardaString
    {
        public static Boolean Guardar(this String texto, String archivo)
        {
            Boolean retorno = true;

            try
            {
                StreamWriter streamWriter = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\" + archivo, true);
                streamWriter.Write(texto);
                streamWriter.Close();
            }
            catch (Exception)
            {
                retorno = false;
            }
            
            return retorno;
        }
    }
}
