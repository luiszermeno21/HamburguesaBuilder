using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HamburguesaBuilder.Models;

namespace HamburguesaBuilder.Builder
{
    public class SandwichCubano : SandwichBuilder
    {
        public SandwichCubano(CarneEnum carne, PanEnum pan)
        {
            _sandwich = new Sandwich
            {
                Tipo = "Sandwich",
                Carne = carne,
                Pan = pan,
                Nombre = "Cuabano",
                Ingredientes = new List<string>()
            };
        }

        public override void PasoPrepararPrecio()
        {
            _sandwich.Precio = 99.00;
        }

        public override void PasoAñadirPapas()
        {
            _sandwich.Papas = "SI";
        }

        public override void PasoPrepararIngredientes()
        {
            _sandwich.Ingredientes.Add("Milanesa");
            _sandwich.Ingredientes.Add("Jamón");
            _sandwich.Ingredientes.Add("Chicharrón");
            _sandwich.Ingredientes.Add("Salchicha");
            _sandwich.Ingredientes.Add("Chorizo");
            _sandwich.Ingredientes.Add("Jitomate");
            _sandwich.Ingredientes.Add("Lechuga");
            _sandwich.Ingredientes.Add("Aguacate");
            _sandwich.Ingredientes.Add("Queso Cheddar");
            _sandwich.Ingredientes.Add("Queso Asadero");
        }
    }
}
