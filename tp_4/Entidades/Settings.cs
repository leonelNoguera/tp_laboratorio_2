using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Settings : ApplicationSettingsBase
    {
        private Settings _defaultInstance;

        public String CadenaConexion
        {
            get
            {
                return "";
            }
            set
            {

            }
        }

        public Settings Default
        {
            get
            {
                return this;
            }
        }
    }
}
