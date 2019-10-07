using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HamburguesaBuilder.Models;

namespace HamburguesaBuilder.Builder
{
    public class SandwichMexicano : SandwichBuilder
    {
        public SandwichMexicano(CarneEnum carne, PanEnum pan)
        {
            _sandwich = new Sandwich
            {
                Tipo = "Sandwich",
                Carne = carne,
                Pan = pan,
                Nombre = "Mexicano",
                Ingredientes = new List<string>()
            };
        }

        public override void PasoPrepararPrecio()
        {
            _sandwich.Precio = 79.00;
        }

        public override void PasoAñadirPapas()
        {
            _sandwich.Papas = "SI";
        }

        public override void PasoPrepararIngredientes()
        {
            _sandwich.Ingredientes.Add("Chorizo");
            _sandwich.Ingredientes.Add("Jalapeño");
            _sandwich.Ingredientes.Add("Frijoles");
            _sandwich.Ingredientes.Add("Chicharron");
            _sandwich.Ingredientes.Add("Jitomate");
            _sandwich.Ingredientes.Add("Lechuga");
            _sandwich.Ingredientes.Add("Aguacate");
            _sandwich.Ingredientes.Add("Queso Asadero");
        }
    }
}
