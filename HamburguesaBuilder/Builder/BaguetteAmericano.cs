using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HamburguesaBuilder.Models;

namespace HamburguesaBuilder.Builder
{
    public class BaguetteAmericano : BaguetteBuilder
    {
        public BaguetteAmericano(CarneEnum carne, PanEnum pan)
        {
            _baguette = new Baguette
            {
                Tipo = "Baguette",
                Carne = carne,
                Pan = pan,
                Nombre = "Americano",
                Ingredientes = new List<string>()
            };
        }

        public override void PasoPrepararPrecio()
        {
            _baguette.Precio = 70.00;
        }

        public override void PasoAñadirPapas()
        {
            _baguette.Papas = "SI";
        }

        public override void PasoPrepararIngredientes()
        {
            _baguette.Ingredientes.Add("Tocino");
            _baguette.Ingredientes.Add("Aros de Cebolla");
            _baguette.Ingredientes.Add("Jitomate");
            _baguette.Ingredientes.Add("Lechuga");
            _baguette.Ingredientes.Add("Pepinillos");
            _baguette.Ingredientes.Add("Queso Cheddar");
        }
    }
}
