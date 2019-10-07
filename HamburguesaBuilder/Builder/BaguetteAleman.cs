using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HamburguesaBuilder.Models;

namespace HamburguesaBuilder.Builder
{
    public class BaguetteAleman : BaguetteBuilder
    {
        public BaguetteAleman(CarneEnum carne, PanEnum pan)
        {
            _baguette = new Baguette
            {
                Tipo = "Baguette",
                Carne = carne,
                Pan = pan,
                Nombre = "Alemán",
                Ingredientes = new List<string>()
            };
        }

        public override void PasoPrepararPrecio()
        {
            _baguette.Precio = 90.00;
        }

        public override void PasoAñadirPapas()
        {
            _baguette.Papas = "SI";
        }

        public override void PasoPrepararIngredientes()
        {
            _baguette.Ingredientes.Add("Salchicha Alemana");
            _baguette.Ingredientes.Add("Cebolla");
            _baguette.Ingredientes.Add("Jitomate");
            _baguette.Ingredientes.Add("Lechuga");
            _baguette.Ingredientes.Add("Pimiento");
            _baguette.Ingredientes.Add("Queso Gorgonzola");
        }
    }
}
