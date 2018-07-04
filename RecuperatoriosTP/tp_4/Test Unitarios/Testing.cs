using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;

namespace Test_Unitarios
{
    [TestClass]
    public class Testing
    {
        [TestMethod]
        [ExpectedException(typeof(TrackingIdRepetidoException))]
        public void RepeticionDePaquete()
        {
            Correo c = new Correo();
            Paquete p1 = new Paquete("paq0", "111-111-1112");
            c += p1;
            Paquete p2 = new Paquete("paq1", "111-111-1112");
            c += p2;
            Paquete p3 = new Paquete("paq2", "111-111-1112");
            c += p3;
        }

        [TestMethod]
        public void ListaYaInstanciada()
        {
            Correo c = new Correo();
            Paquete p = new Paquete("paq0", "111-111-1111");
            try
            {
                c.Paquetes.Add(p);
            }
            catch (NullReferenceException e)
            {
                Assert.Fail();
            }
        }
    }
}
