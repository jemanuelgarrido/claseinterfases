
using interfaces.INTERFACES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemplosInterfacez.Clases
{
    internal class ClsCarro : ICarro
    {
        public string Marca { get; set; }
        public string Color { get; set; }
        public int Modelo { get; set; }

        public string Acelerar(int cuanto)
        {
            Console.WriteLine($"Vas a {cuanto}");
            return "Acelerar";
        }

        public void EncederCarro()
        {
            Console.WriteLine("El carro esta encendido");
        }

        public string GetVelocidadActual()
        {
            Console.WriteLine("Vas a 100kph");
            return "velocidad";
        }
        
    }
}

