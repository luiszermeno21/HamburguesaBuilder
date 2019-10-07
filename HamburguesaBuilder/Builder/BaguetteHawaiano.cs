using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HamburguesaBuilder.Models;

namespace HamburguesaBuilder.Builder
{
    public class BaguetteHawaiano : BaguetteBuilder
    {
        public BaguetteHawaiano(CarneEnum carne, PanEnum pan)
        {
            _baguette = new Baguette
            {
                Tipo = "Baguette",
                Carne = carne,
                Pan = pan,
                Nombre = "Hawaiano",
                Ingredientes = new List<string>()
            };
        }

        public override void PasoPrepararPrecio()
        {
            _baguette.Precio = 54.00;
        }

        public override void PasoAñadirPapas()
        {
            _baguette.Papas = "NO";
        }

        public override void PasoPrepararIngredientes()
        {
            _baguette.Ingredientes.Add("Jamón");
            _baguette.Ingredientes.Add("Piña");
            _baguette.Ingredientes.Add("Lechuga");
            _baguette.Ingredientes.Add("Cebolla");
            _baguette.Ingredientes.Add("Queso Amarillo");
        }
    }
}
