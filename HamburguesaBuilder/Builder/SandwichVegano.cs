using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HamburguesaBuilder.Models;

namespace HamburguesaBuilder.Builder
{
    public class SandwichVegano:SandwichBuilder
    {
        public SandwichVegano(CarneEnum carne, PanEnum pan)
        {
            _sandwich = new Sandwich
            {
                Tipo = "Sandwich",
                Carne = carne,
                Pan = pan,
                Nombre = "Vegana",
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
            _sandwich.Ingredientes.Add("Jitomate");
            _sandwich.Ingredientes.Add("Zanahoria");
            _sandwich.Ingredientes.Add("Lechuga Italiana");
            _sandwich.Ingredientes.Add("Cebolla");
            _sandwich.Ingredientes.Add("Tofu");
        }
    }
}
