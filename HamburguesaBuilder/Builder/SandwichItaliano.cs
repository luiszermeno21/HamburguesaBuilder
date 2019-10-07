using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HamburguesaBuilder.Models;

namespace HamburguesaBuilder.Builder
{
    public class SandwichItaliano : SandwichBuilder
    {
        public SandwichItaliano(CarneEnum carne, PanEnum pan)
        {
            _sandwich = new Sandwich
            {
                Tipo = "Sandwich",
                Carne = carne,
                Pan = pan,
                Nombre = "Italiano",
                Ingredientes = new List<string>()
            };
        }

        public override void PasoPrepararPrecio()
        {
            _sandwich.Precio = 59.00;
        }

        public override void PasoAñadirPapas()
        {
            _sandwich.Papas = "NO";
        }

        public override void PasoPrepararIngredientes()
        {
            _sandwich.Ingredientes.Add("Prosciuto");
            _sandwich.Ingredientes.Add("Salame");
            _sandwich.Ingredientes.Add("Jitomate");
            _sandwich.Ingredientes.Add("Lechuga Italiana");
            _sandwich.Ingredientes.Add("Pimiento");
            _sandwich.Ingredientes.Add("Queso Provolone");
        }
    }
}
