using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HamburguesaBuilder.Models;

namespace HamburguesaBuilder.Builder
{
    public class BaguetteLight : BaguetteBuilder
    {
        public BaguetteLight(CarneEnum carne, PanEnum pan)
        {
            _baguette = new Baguette
            {
                Tipo = "Baguette",
                Carne = carne,
                Pan = pan,
                Nombre = "Light",
                Ingredientes = new List<string>()
            };
        }

        public override void PasoPrepararPrecio()
        {
            _baguette.Precio = 44.00;
        }

        public override void PasoAñadirPapas()
        {
            _baguette.Papas = "NO";
        }

        public override void PasoPrepararIngredientes()
        {
            _baguette.Ingredientes.Add("Jitomate");
            _baguette.Ingredientes.Add("Zanahoria");
            _baguette.Ingredientes.Add("Lechuga Italiana");
            _baguette.Ingredientes.Add("Cebolla");
            _baguette.Ingredientes.Add("Queso Panela");
        }
    }
}
