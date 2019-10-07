using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HamburguesaBuilder.Models;
namespace HamburguesaBuilder.Builder
{
    public class SandwichAleman : SandwichBuilder
    {
        public SandwichAleman(CarneEnum carne, PanEnum pan)
        {
            _sandwich = new Sandwich
            {
                Tipo = "Sandwich",
                Carne = carne,
                Pan = pan,
                Nombre = "Alemán",
                Ingredientes = new List<string>()
            };
        }

        public override void PasoPrepararPrecio()
        {
            _sandwich.Precio = 85.00;
        }

        public override void PasoAñadirPapas()
        {
            _sandwich.Papas = "SI";
        }

        public override void PasoPrepararIngredientes()
        {
            _sandwich.Ingredientes.Add("Salchicha Alemana");
            _sandwich.Ingredientes.Add("Cebolla");
            _sandwich.Ingredientes.Add("Jitomate");
            _sandwich.Ingredientes.Add("Lechuga");
            _sandwich.Ingredientes.Add("Pimiento");
            _sandwich.Ingredientes.Add("Queso Gorgonzola");
        }
    }
}
