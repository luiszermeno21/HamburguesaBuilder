using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamburguesaBuilder.Models
{
    public class Hamburguesa
    {
        public string Nombre { get; set; }
        public PanEnum Pan { get; set; }
        public List<string> Ingredientes { get; set; }
        public CarneEnum Carne { get; set; }
        public double Precio { get; set; }
        public string Papas { get; set; }

        public Hamburguesa()
        {

        }

        public Hamburguesa(PanEnum pan, string nombre, double precio, CarneEnum carne, List<string> ingredientes, string papas)
        //: this() //contructor manda a llamar al contructor base
        {
            Pan = pan;
            Nombre = nombre;
            Precio = precio;
            Carne = carne;
            Ingredientes = ingredientes;
            Papas = papas;
        }

        public override string ToString()
        {
            return $"Hamburguesa {Nombre} / Pan: {Pan}, Carne: {Carne}, Papas: {Papas}, Ingredientes: {string.Join("+", Ingredientes)}, Precio: {Precio}";
        }
    }
}
