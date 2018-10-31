using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coordenadas
{
    public class Coordenada
    {
        public Double latitud { get; set; }
        public Double longitud { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            bool Continuar = true;

            Console.WriteLine("Ingrese coordenadas (latitud, longitud) o S para salir:");
            Console.WriteLine("Ejemplo:13.2555.13.4888");
            List<Coordenada> coordenadas = new List<Coordenada>();
            while (Continuar)
            {
                String salida = Console.ReadLine();
                if (salida.ToLower().Equals("s"))
                {
                    Continuar = false;
                    continue;
                }
                if (salida.Split(',').Length != 2)
                {
                    continue; 
                }
                Double latitud;
                Double longitud;
                Coordenada micoordenada = new Coordenada()
                {
                    latitud = Double.TryParse(salida.Split(',')[0], out latitud) ? latitud:0,
                    longitud = Double.TryParse(salida.Split(',')[1], out longitud) ? longitud : 0,
                };
                coordenadas.Add(micoordenada);
                
            }

            Console.WriteLine("Adios... tu has ongresado: {0} coordenadas", coordenadas.Count);
            Console.ReadKey();
        }
    }
}
