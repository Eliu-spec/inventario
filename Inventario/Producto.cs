using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Inventario
{
    public class Producto
    {
        //Atributos
        private string nombre;
        private int numerodeserie;
        private string categoria;
        private int precio;
        private int disponibles;


        //Encapsulamiento
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public int NumeroDeSerie
        {
            get { return numerodeserie; }
            set { numerodeserie = value; }
        }
        public string Categoria
        {
            get { return categoria; }
            set { categoria = value; }
        }
        public int Precio
        {
            get { return precio; }
            set { precio = value; }
        }
        public int Disponibles
        {
            get { return disponibles; }
            set { disponibles = value; }
        }

        //Constructor
        public Producto(string nombre, int numerodeserie, string categoria, int precio, int dispobibles)
        {
            Nombre = nombre;
            NumeroDeSerie = numerodeserie;
            Categoria = categoria;
            Precio = precio;
            Disponibles = dispobibles;
        }

        //Metodos
        public void Informacion()
        {
            Console.WriteLine($"El producto es: {Nombre}");
            Console.WriteLine($"Su numero de serie es: {NumeroDeSerie}");
            Console.WriteLine($"Su categoria es: {Categoria}");
            Console.WriteLine($"Su precio indivudal es: {Precio}");
            Console.WriteLine($"Total en el inventario: {Disponibles}");
        }

        public void PrecioConDescuento(int descuento)
        {
            int preciofinal = Precio - descuento;
            {
                Console.WriteLine($"El precio con descuento es: {preciofinal} ");
            }
        }

        public void ValorTotalDelInventario()
        {
            int valortotal = precio * disponibles;
            {
                Console.WriteLine($"El total del inventario es : {valortotal}");
            }
        }

        public void PreciodelEnvio(int envio)
        {
            int PrecioEnvio = Precio + envio;
            {
                Console.WriteLine($"El precio final del producto con envio será: {PrecioEnvio}");
            }
        }

        public void PrecioconImpuesto(int impuesto)
        {
            int Conimpuesto = Precio + impuesto;
            {
                Console.WriteLine($"El precio con impuesto incluido es: {Conimpuesto}");
            }
        }
    }
}