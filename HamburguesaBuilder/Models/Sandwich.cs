using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamburguesaBuilder.Models
{
    public class Sandwich : Food
    {
        public string Tipo { get; set; }
        public string Nombre { get; set; }
        public PanEnum Pan { get; set; }
        public List<string> Ingredientes { get; set; }
        public CarneEnum Carne { get; set; }
        public double Precio { get; set; }
        public string Papas { get; set; }

        public Sandwich()
        {

        }

        public Sandwich(CarneEnum carne, PanEnum pan, string nombre, double precio, List<string> ingredientes, string papas)
        //: this() //contructor manda a llamar al contructor base
        {
            Carne = carne;
            Pan = pan;
            Nombre = nombre;
            Precio = precio;
            Ingredientes = ingredientes;
            Papas = papas;
        }

        public override string ToString()
        {
            return $"Sandwich {Nombre} / Pan: {Pan}, Papas: {Papas}, Ingredientes: {string.Join("+", Ingredientes)}, Precio: {Precio}";
        }

        public string Descripción()
        {
            if(Papas == "SI")
                return $"Delicioso Sandwich de: {string.Join(", ", Ingredientes)}, en un pan {Pan}, acompañado con Papas";
            else
                return $"Delicioso Sandwich de: {string.Join(", ", Ingredientes)}, en un pan {Pan}";
        }
    }
}
