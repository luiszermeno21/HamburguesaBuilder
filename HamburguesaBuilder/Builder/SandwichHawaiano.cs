using HamburguesaBuilder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamburguesaBuilder.Builder
{
    public class SandwichHawaiano : SandwichBuilder
    {
        public SandwichHawaiano(CarneEnum carne, PanEnum pan)
        {
            _sandwich= new Sandwich
            {
                Tipo = "Sandwich",
                Carne = carne,
                Pan = pan,
                Nombre = "Hawaiano",
                Ingredientes = new List<string>()
            };
        }

        public override void PasoPrepararPrecio()
        {
            _sandwich.Precio = 39.00;
        }

        public override void PasoAñadirPapas()
        {
            _sandwich.Papas = "NO";
        }

        public override void PasoPrepararIngredientes()
        {
            _sandwich.Ingredientes.Add("Jamón");
            _sandwich.Ingredientes.Add("Piña");
            _sandwich.Ingredientes.Add("Lechuga");
            _sandwich.Ingredientes.Add("Cebolla");
            _sandwich.Ingredientes.Add("Queso Amarillo");
        }
    }
}
