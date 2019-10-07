using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HamburguesaBuilder.Models;

namespace HamburguesaBuilder.Builder
{
    public class BaguetteItaliano : BaguetteBuilder
    {
        public BaguetteItaliano(CarneEnum carne, PanEnum pan)
        {
            _baguette = new Baguette
            {
                Tipo = "Baguette",
                Carne = carne,
                Pan = pan,
                Nombre = "Italiano",
                Ingredientes = new List<string>()
            };
        }

        public override void PasoPrepararPrecio()
        {
            _baguette.Precio = 64.00;
        }

        public override void PasoAñadirPapas()
        {
            _baguette.Papas = "NO";
        }

        public override void PasoPrepararIngredientes()
        {
            _baguette.Ingredientes.Add("Prosciuto");
            _baguette.Ingredientes.Add("Salame");
            _baguette.Ingredientes.Add("Jitomate");
            _baguette.Ingredientes.Add("Lechuga Italiana");
            _baguette.Ingredientes.Add("Pimiento");
            _baguette.Ingredientes.Add("Queso Provolone");
        }
    }
}
