using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HamburguesaBuilder.Models;

namespace HamburguesaBuilder.Builder
{
    public class BaguetteCubano : BaguetteBuilder
    {
        public BaguetteCubano(CarneEnum carne, PanEnum pan)
        {
            _baguette = new Baguette
            {
                Tipo = "Baguette",
                Carne = carne,
                Pan = pan,
                Nombre = "Cuabano",
                Ingredientes = new List<string>()
            };
        }

        public override void PasoPrepararPrecio()
        {
            _baguette.Precio = 109.00;
        }

        public override void PasoAñadirPapas()
        {
            _baguette.Papas = "SI";
        }

        public override void PasoPrepararIngredientes()
        {
            _baguette.Ingredientes.Add("Milanesa");
            _baguette.Ingredientes.Add("Jamón");
            _baguette.Ingredientes.Add("Chicharrón");
            _baguette.Ingredientes.Add("Salchicha");
            _baguette.Ingredientes.Add("Chorizo");
            _baguette.Ingredientes.Add("Jitomate");
            _baguette.Ingredientes.Add("Lechuga");
            _baguette.Ingredientes.Add("Aguacate");
            _baguette.Ingredientes.Add("Queso Cheddar");
            _baguette.Ingredientes.Add("Queso Asadero");
        }
    }
}
