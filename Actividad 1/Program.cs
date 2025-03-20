using System;
using System.Reflection.Metadata.Ecma335;

namespace hola_mundo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Computadora lacaprichosa = new Computadora();
            lacaprichosa.procesador = "Ryzen 5 5600g";
            lacaprichosa.placaMadre = "MSI B450m pro-vdh max";
            lacaprichosa.fuente = "corsair CX550F RGB";
            lacaprichosa.encender();
            Console.WriteLine(lacaprichosa.procesador);
        }
    }
    public class Computadora
    {
        public string procesador;
        public string placaMadre;
        public string fuente;
        

        public void encender()
        {
            Console.WriteLine("Se esta encendiendo la pc");
        }
        public void apagar()
        {
            Console.WriteLine("Se esta apagando la pc"); 
        }
        public void reiniciar()
        {
            Console.WriteLine("Se esta reiniciando la pc");
        }
    }

    public class auto
    {
        public string Motor;
        public string caballosDeFuerza;
        public string tipoDeTransmision;
        public string modelo;

        public void encender()
        {
            Console.WriteLine("El auto esta arrancando");
        }
        public void freno()
        {
            Console.WriteLine("El auto esta frenando");
        }
        public void reversa()
        {
            Console.WriteLine("El auto esta en reversa");
        }
    }
}