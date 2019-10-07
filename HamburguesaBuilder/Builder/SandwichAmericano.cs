using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HamburguesaBuilder.Models;

namespace HamburguesaBuilder.Builder
{
    public class SandwichAmericano : SandwichBuilder
    {
        public SandwichAmericano(CarneEnum carne, PanEnum pan)
        {
            _sandwich = new Sandwich
            {
                Tipo = "Sandwich",
                Carne = carne,
                Pan = pan,
                Nombre = "Americano",
                Ingredientes = new List<string>()
            };
        }

        public override void PasoPrepararPrecio()
        {
            _sandwich.Precio = 69.00;
        }

        public override void PasoAñadirPapas()
        {
            _sandwich.Papas = "SI";
        }

        public override void PasoPrepararIngredientes()
        {
            _sandwich.Ingredientes.Add("Tocino");
            _sandwich.Ingredientes.Add("Aros de Cebolla");
            _sandwich.Ingredientes.Add("Jitomate");
            _sandwich.Ingredientes.Add("Lechuga");
            _sandwich.Ingredientes.Add("Pepinillos");
            _sandwich.Ingredientes.Add("Queso Cheddar");
        }
    }
}
