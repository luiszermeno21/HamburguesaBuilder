using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HamburguesaBuilder.Models;

namespace HamburguesaBuilder.Builder
{
    public class BaguetteMexicano : BaguetteBuilder
    {
        public BaguetteMexicano(CarneEnum carne, PanEnum pan)
        {
            _baguette = new Baguette
            {
                Tipo = "Baguette",
                Carne = carne,
                Pan = pan,
                Nombre = "Mexicano",
                Ingredientes = new List<string>()
            };
        }

        public override void PasoPrepararPrecio()
        {
            _baguette.Precio = 84.00;
        }

        public override void PasoAñadirPapas()
        {
            _baguette.Papas = "SI";
        }

        public override void PasoPrepararIngredientes()
        {
            _baguette.Ingredientes.Add("Chorizo");
            _baguette.Ingredientes.Add("Jalapeño");
            _baguette.Ingredientes.Add("Frijoles");
            _baguette.Ingredientes.Add("Chicharron");
            _baguette.Ingredientes.Add("Jitomate");
            _baguette.Ingredientes.Add("Lechuga");
            _baguette.Ingredientes.Add("Aguacate");
            _baguette.Ingredientes.Add("Queso Asadero");
        }
    }
}
