using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class ConexionBaseDatos
    {
        private bool ConexionAbierta;
        private string Archivo = "test.txt";

        public ConexionBaseDatos()
        {
            ConexionAbierta = true;
        }
        /*public ConexionBaseDatos()
        {
            ConexionAbierta = false;
            using StreamWriter writer = new StreamWriter(Archivo);
            writer.WriteLine("Conexión abierta");
        }*/
        public void CerrarConexion()
        {
            if (ConexionAbierta)
            {

            }
        }
        public void AbrirConexion()
        {
            if (!ConexionAbierta)
            {

            }
        }
        ~ConexionBaseDatos()
        {
            
                using StreamWriter writer = new StreamWriter(Archivo, true);
                writer.WriteLine("La conexión se cerró automáticamente");

                if (ConexionAbierta) { 
                CerrarConexion();
                Console.WriteLine($"El destructor fue llamado");
            }

        }

    }
}
